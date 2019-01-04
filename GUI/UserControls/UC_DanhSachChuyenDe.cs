using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UC_DanhSachChuyenDe : UserControl
    {
        private List<DTO.ChuyenDe> dsChuyenDe = null;
        private List<DTO.Nganh> dsNganh = null;
        public UC_DanhSachChuyenDe()
        {
            InitializeComponent();
            TaiDsChuyenDeVaoListView();
            TaiDsNganhVaoComboBox();
        }

        private void TaiDsChuyenDeVaoListView()
        {
            lvDsChuyenDe.Clear();
            dsChuyenDe = BUS.ChuyenDe.LayDSChuyenDe();
            foreach (DTO.ChuyenDe i in dsChuyenDe)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.TenChuyenDe;
                item.Tag = i;
                item.ImageIndex = 0;
                lvDsChuyenDe.Items.Add(item);
            }
        }

        private void TaiDsNganhVaoComboBox()
        {
            cbMaNganh.Items.Clear();
            dsNganh = BUS.Nganh.LayDanhSachNganh();
            foreach (DTO.Nganh i in dsNganh)
            {
                cbMaNganh.Items.Add(i.MaNganh+", "+i.TenNganh);
            }
            cbMaNganh.SelectedIndex = 0;
        }

        private void lvDsChuyenDe_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvDsChuyenDe.SelectedItems.Count > 0)
            {
                gbThongTinChiTiet.Enabled = true;
                DTO.ChuyenDe chuyenDe = lvDsChuyenDe.SelectedItems[0].Tag as DTO.ChuyenDe;
                txtMaChuyenDe.Text = chuyenDe.MaChuyenDe;
                txtTenChuyenDe.Text = chuyenDe.TenChuyenDe;
               
                for(int i = 0; i < dsNganh.Count; i++)
                {
                    if(dsNganh[i].MaNganh == chuyenDe.MaNganh)
                    {
                        cbMaNganh.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMaNganh.Text))
            {
                MessageBox.Show("Bạn chưa chọn Ngành cho Chuyên đề", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTenChuyenDe.Text))
            {
                MessageBox.Show("Tên chuyên đề không thể rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string _maNganh = cbMaNganh.Text.Split(new char[] { ',' })[0];
            DTO.ChuyenDe chuyenDe = new DTO.ChuyenDe(txtMaChuyenDe.Text, _maNganh, txtTenChuyenDe.Text);
            if (BUS.ChuyenDe.Sua(chuyenDe))
            {
                XoaDuLieu();
                TaiDsChuyenDeVaoListView();
                MessageBox.Show("Cập nhật chuyên đề thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật chuyên đề!. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maChuyenDe = null;
            if (!string.IsNullOrEmpty(txtMaChuyenDe.Text))
            {
                maChuyenDe = txtMaChuyenDe.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn xóa Chuyên đề \"" + txtTenChuyenDe.Text + "\"?", "Xóa chuyên đề", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BUS.ChuyenDe.Xoa(maChuyenDe))
                    {
                        TaiDsChuyenDeVaoListView();
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            XoaDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMaNganh.Text))
            {
                MessageBox.Show("Bạn chưa chọn Ngành cho Chuyên đề", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lvDsChuyenDe.SelectedItems.Clear();
                return;
            }
            if (string.IsNullOrEmpty(txtTenChuyenDe.Text))
            {
                MessageBox.Show("Tên chuyên đề không thể rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lvDsChuyenDe.SelectedItems.Clear();
                return;
            }
            string maChuyenDeMoi = BUS.ChuyenDe.TaoMaChuyenDe();
            string maChuyenDeCu = txtMaChuyenDe.Text;
            txtMaChuyenDe.Text = maChuyenDeMoi;
            string _maNganh = cbMaNganh.Text.Split(new char[] { ',' })[0];
            DTO.ChuyenDe chuyenDe = new DTO.ChuyenDe(maChuyenDeMoi, _maNganh, txtTenChuyenDe.Text);
            if (BUS.ChuyenDe.Them(chuyenDe))
            {
                TaiDsChuyenDeVaoListView();
                lvDsChuyenDe.SelectedItems.Clear();
                MessageBox.Show("Thêm chuyên đề thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtMaChuyenDe.Text = maChuyenDeCu;
                lvDsChuyenDe.SelectedItems.Clear();
                MessageBox.Show("Không thể thêm chuyên đề!. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            XoaDuLieu();
        }

        private void XoaDuLieu()
        {
            txtMaChuyenDe.Clear();
            txtTenChuyenDe.Clear();
            cbMaNganh.SelectedIndex = 0;
        }

        private void gbThongTinChiTiet_Enter(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lvDsChuyenDe.SelectedItems.Clear();
            txtMaChuyenDe.Clear();
            txtTenChuyenDe.Clear();
            cbMaNganh.SelectedIndex = 0;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbLat_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDe.View = View.Tile;
        }
    }
}
