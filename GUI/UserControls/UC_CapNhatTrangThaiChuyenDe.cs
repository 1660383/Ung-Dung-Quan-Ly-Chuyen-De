using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using BUS;

namespace GUI.UserControls
{
    public partial class UC_CapNhatTrangThaiChuyenDe : UserControl
    {
        private PopupNotifier popup;
        private DataView dataView;
        private DataTable dataTable;
        private List<DTO.DTO_ThongTinChuyenDeMo> dsChuyenDeGVThamGiaDangMo;
        private List<DTO.DTO_ChuyenDeGiaoVienThamGia> dsChuyenDeGiaoVienThamGia;
        private List<int> dsNamHoc;
        public UC_CapNhatTrangThaiChuyenDe()
        {
            InitializeComponent();
            TaiVaKhoiTaoDuLieuTuDataBase();
            this.popup = new PopupNotifier();
            this.popup.AnimationDuration = 100;
            this.popup.IsRightToLeft = true;
            this.components.Add(popup);
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            groupBox2.Hide();
            btnCapNhat.Enabled = true;
            rbBieuTuongLon.Checked = true;
        }

        private void GanDuLieuVaoCbNamHoc()
        {
            cbNamHoc.Items.Clear();
            dsNamHoc = new List<int>();
            foreach (DTO.DTO_ThongTinChuyenDeMo i in dsChuyenDeGVThamGiaDangMo)
            {
                if (dsNamHoc.BinarySearch(i.NamHoc) < 0)
                {
                    dsNamHoc.Add(i.NamHoc);
                    cbNamHoc.Items.Add(i.NamHoc);
                }
            }
        }

        private void TaiVaKhoiTaoDuLieuTuDataBase()
        {
            LayThongTinCacChuyenDeGiaoVienThamGia();
            LayThongTinCacChuyenDeMoGiaoVienThamGia();
            KhoiTaoDuLieuChoFilter();
            GanDuLieuVaoListView();
            GanDuLieuVaoCbNamHoc();
            GanDuLieuDeXuatTimKiem();
        }
        private void LayThongTinCacChuyenDeGiaoVienThamGia()
        {
            this.dsChuyenDeGiaoVienThamGia = BUS_ChuyenDeGiaoVienThamGia.LayDsChuyenDeGiaoVienThamGia();

        }

        private void KhoiTaoDuLieuChoFilter()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("MaChuyenDe");
            dataTable.Columns.Add("TenChuyenDe");
            dataTable.Columns.Add("HocKy");
            dataTable.Columns.Add("NamHoc");

            foreach (DTO.DTO_ThongTinChuyenDeMo i in dsChuyenDeGVThamGiaDangMo)
            {
                dataTable.Rows.Add(i.MaChuyenDe, BUS_ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe, i.HocKy, i.NamHoc);
            }
            dataView = new DataView(dataTable);
        }

        private void LayThongTinCacChuyenDeMoGiaoVienThamGia()
        {
            this.dsChuyenDeGVThamGiaDangMo = BUS.BUS_ThongTinChuyenDeMo.LayDsThongTinChuyenDeMoGiaoVienThamGia(this.dsChuyenDeGiaoVienThamGia);

        }

        private void GanDuLieuDeXuatTimKiem()
        {
            foreach (DTO.DTO_ThongTinChuyenDeMo i in dsChuyenDeGVThamGiaDangMo)
            {
                txtSearch.AutoCompleteCustomSource.Add(BUS.BUS_ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe);
            }
        }

        private void GanDuLieuNamDeXuatChoCbBox()
        {
            foreach ( int i in dsNamHoc)
            {
                cbNamHoc.AutoCompleteCustomSource.Add(i.ToString());
            }
        }
        private void XoaDuLieuForm()
        {
            lblTenChuyenDe.Text = "";
            lblMaChuyenDe.Text = "";
            nudSLNhomToiDa.Value = 0;
            nudSLSinhVienToiDa.Value = 0;
            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(nudSLNhomToiDa.Value >= 0)
            {
                chuyenDeMo.SlNhomToiDa = (int)nudSLNhomToiDa.Value;
            }else
            {
                MessageBox.Show("Số lượng Nhóm không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudSLSinhVienToiDa.Value >= 0)
            {
                chuyenDeMo.SlSinhVienToiDa = (int)nudSLSinhVienToiDa.Value;
            }
            else
            {
                MessageBox.Show("Số lượng Sinh viên không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.Compare(dtpBatDau.Value, dtpKetThuc.Value) <=0)
            {
                chuyenDeMo.ThoiGianBD = dtpBatDau.Value;
                chuyenDeMo.ThoiGianKT = dtpKetThuc.Value;
            }else
            {
                MessageBox.Show("Thời khoản thời gian không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool ketqua = BUS_ThongTinChuyenDeMo.CapNhatThongTinChuyenDeMo(chuyenDeMo);
            if (ketqua)
            {
                CapNhatDuLieu();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Cập nhật thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void rbBieuTuongLon_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbBieuTuongLon.Checked)
            {
                this.lvChuyenDeMo.View = View.LargeIcon;
            }
        }

        private void rbBieuTuongNho_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbBieuTuongNho.Checked)
            {
                this.lvChuyenDeMo.View = View.SmallIcon;
            }
        }

        private void rbDanhSach_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbDanhSach.Checked)
            {
                this.lvChuyenDeMo.View = View.List;
            }
        }

        private void rbLat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbLat.Checked)
            {
                this.lvChuyenDeMo.View = View.Tile;
            }
        }

        private void lblTenChuyenDe_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 500;
            toolTip.AutoPopDelay = 5000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.lblTenChuyenDe, this.lblTenChuyenDe.Text);
        }
        DTO.DTO_ThongTinChuyenDeMo chuyenDeMo = null;
        private void lvChuyenDeMo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            chuyenDeMo = e.Item.Tag as DTO.DTO_ThongTinChuyenDeMo;
            if (chuyenDeMo != null)
            {
                lblTenChuyenDe.Text = e.Item.Text;
                nudSLSinhVienToiDa.Value = chuyenDeMo.SlSinhVienToiDa;
                nudSLNhomToiDa.Value = chuyenDeMo.SlNhomToiDa;
                dtpBatDau.Value = chuyenDeMo.ThoiGianBD;
                dtpKetThuc.Value = chuyenDeMo.ThoiGianKT;
                lblMaChuyenDe.Text = chuyenDeMo.MaChuyenDe;
                groupBox2.Show();

            }
            else
            {
                chuyenDeMo = null;
                groupBox2.Hide();
            }
        }

        private void lvChuyenDeMo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = (txtSearch.Text != txtSearch.Hint) ? txtSearch.Text : "";            
            dataView.RowFilter = String.Format("TenChuyenDe like '%{0}%'", query);
            GanDuLieuVaoListView();
        }

        private void CapNhatDuLieu()
        {
            TaiVaKhoiTaoDuLieuTuDataBase();
        }
        private void GanDuLieuVaoListView()
        {
            lvChuyenDeMo.Clear();
            foreach (DataRow row in dataView.ToTable().Rows)
            {
                for (int i = 0; i < this.dsChuyenDeGVThamGiaDangMo.Count; i++)
                {
                    if (this.dsChuyenDeGVThamGiaDangMo[i].MaChuyenDe == row[0].ToString()
                        && this.dsChuyenDeGVThamGiaDangMo[i].HocKy == row[2].ToString()
                        && this.dsChuyenDeGVThamGiaDangMo[i].NamHoc == int.Parse(row[3].ToString()))
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = BUS_ChuyenDe.LayThongTinChuyenDe(this.dsChuyenDeGVThamGiaDangMo[i].MaChuyenDe).TenChuyenDe;
                        item.Tag = this.dsChuyenDeGVThamGiaDangMo[i];
                        item.ImageIndex = 0;
                        lvChuyenDeMo.Items.Add(item);
                    }
                }

            }


        }

        private void cbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = cbHocKi.Items[cbHocKi.SelectedIndex].ToString();
            dataView.RowFilter = String.Format("HocKy like '%{0}%'", query);
            GanDuLieuVaoListView();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = cbNamHoc.Items[cbNamHoc.SelectedIndex].ToString();
            dataView.RowFilter = String.Format("NamHoc = {0}", int.Parse(query));
            GanDuLieuVaoListView();
        }


        private void cbHocKi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
            }
        }



        // private void Filt
    }
}
