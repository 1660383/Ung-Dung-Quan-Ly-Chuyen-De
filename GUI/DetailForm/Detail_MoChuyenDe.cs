using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DetailForm
{
    public partial class Detail_MoChuyenDe : Form
    {
        List<DTO.ChuyenDe> dsChuyenDe = null;
        public Detail_MoChuyenDe()
        {
            InitializeComponent();
            GanDuLieuVaoListView();
            rbDanhSach.Checked = true;
        }
        UserControls.UC_CapNhatTrangThaiChuyenDe ucCapNhatTrangThaiChuyenDe;
        public Detail_MoChuyenDe(UserControls.UC_CapNhatTrangThaiChuyenDe ucCapNhatTrangThaiChuyenDe)
        {
            InitializeComponent();
            GanDuLieuVaoListView();
            rbDanhSach.Checked = true;
            this.ucCapNhatTrangThaiChuyenDe = ucCapNhatTrangThaiChuyenDe;
        }

        private void GanDuLieuVaoListView()
        {
            this.lvDsChuyenDe.Clear();
            this.dsChuyenDe = BUS.ChuyenDe.LayDSChuyenDe();
            if (this.dsChuyenDe != null)
            {
                foreach (DTO.ChuyenDe i in this.dsChuyenDe)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = i.TenChuyenDe;
                    item.Tag = i;
                    item.ImageIndex = 0;
                    lvDsChuyenDe.Items.Add(item);
                }
            }
        }




        private void rbBieuTuongLon_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDe.View = View.LargeIcon;
        }

        private void rbBieuTuongNho_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDe.View = View.SmallIcon;
        }

        private void rbDanhSach_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDe.View = View.List;

        }

        private void rbLat_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDe.View = View.Tile;
        }

        private void lvDsChuyenDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvDsChuyenDe.SelectedItems.Count > 0)
            {
                btnMo.Enabled = true;
                DTO.ChuyenDe chuyenDe = this.lvDsChuyenDe.SelectedItems[0].Tag as DTO.ChuyenDe;
                lblTenChuyenDe.Text = chuyenDe.TenChuyenDe;
                lblMaChuyenDe.Text = chuyenDe.MaChuyenDe;
                txtNganh.Text = BUS.Nganh.LayNganh(chuyenDe.MaNganh).TenNganh;
                cbHocKi.Text = "";
                nudNamHoc.Value = 0;
                nudSLNhom.Value = 0;
                nudSLSVToiDa.Value = 0;
                dtpBatDau.Value = dtpKetThuc.Value = DateTime.Now;
            }
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            DTO.GiaoVu gvu = BUS.Users.LayThongTinNguoiDung() as DTO.GiaoVu;
            if (gvu != null)
            {
                DTO.ThongTinChuyenDeMo chuyenDeMo = new DTO.ThongTinChuyenDeMo();
                chuyenDeMo.MaChuyenDe = lblMaChuyenDe.Text;
                chuyenDeMo.MaGiaoVu = gvu.MaGiaoVu;

                // Kiểm tragiá trị Học kì.
                if (String.IsNullOrEmpty(cbHocKi.Text) || cbHocKi.Text != "HK1" && cbHocKi.Text != "HK2")
                {
                    MessageBox.Show("Học kì có giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                chuyenDeMo.HocKy = cbHocKi.Text;
                // Kiểm tra giá trị năm học.
                if ((int)nudNamHoc.Value <= 0)
                {
                    MessageBox.Show("Năm học có giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                chuyenDeMo.NamHoc = (int)nudNamHoc.Value;

                // Kiểm tra giá trị sl sinh viên tối đa.
                if ((int)nudSLSVToiDa.Value < 0)
                {
                    MessageBox.Show("Số lượng sinh viên tối đa không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                chuyenDeMo.SlSinhVienToiDa = (int)nudSLSVToiDa.Value;

                // Kiểm tra giá trị sl nhóm tối đa.              
                if ((int)nudSLNhom.Value < 0)
                {
                    MessageBox.Show("Số lượng nhóm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                chuyenDeMo.SlNhomToiDa = (int)nudSLNhom.Value;

                // Kiểm tra thời gian bắt đầu, thời gian kết thúc.
                if (DateTime.Compare(dtpBatDau.Value, dtpKetThuc.Value) >= 0)
                {
                    MessageBox.Show("Thời gian bắt đầu phải sớm hơn thời gian kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                chuyenDeMo.ThoiGianBD = dtpBatDau.Value;
                chuyenDeMo.ThoiGianKT = dtpKetThuc.Value;
                chuyenDeMo.TrangThai = "mở";

                if (!BUS.HocKi.TonTai(new DTO.HocKi(chuyenDeMo.HocKy, chuyenDeMo.NamHoc)))
                {
                    if (!BUS.HocKi.ThemHocKy(new DTO.HocKi(chuyenDeMo.HocKy, chuyenDeMo.NamHoc)))
                    {
                        MessageBox.Show("Không thể tạo mới '" + chuyenDeMo.HocKy + " và " + chuyenDeMo.NamHoc + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (BUS.ThongTinChuyenDeMo.MoChuyenDe(chuyenDeMo))
                {
                    this.ucCapNhatTrangThaiChuyenDe.TaiDuLieuTuDB();
                    MessageBox.Show("Đã mở chuyên đề " + lblTenChuyenDe.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaDuLieuNhap();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra! Không thể mở chuyên đề hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void XoaDuLieuNhap()
        {
            btnMo.Enabled = false;
            lblTenChuyenDe.Text = "";
            lblMaChuyenDe.Text = "";
            txtNganh.Clear();
            cbHocKi.Text = "";
            nudSLSVToiDa.Value = 0;
            nudSLNhom.Value = 0;
            nudNamHoc.Value = 0;
            dtpBatDau.Value = dtpKetThuc.Value = DateTime.Now;
        }        
    }
}
