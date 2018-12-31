using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.IO;
using System.Threading;

namespace GUI.UserControls
{
    public partial class UC_GiaoNoiDungChuyenDe : UserControl
    {

        DTO.NoiDungLopChuyenDe ndLopChuyenDe;
        DataTable dataTable;
        DataView dataView;
        List<DTO.GiaoVienThamGiaChuyenDe> dsChuyenDeGiaoVienThamGia;
        List<DTO.NoiDungLopChuyenDe> dsNoiDungLopChuyenDe;
        List<int> dsNamHoc;
        DetailForm.Detail_ChinhSuaNoiDungChuyenDe frmChinhSuaNoiDungChuyenDe;
        public UC_GiaoNoiDungChuyenDe()
        {
            InitializeComponent();
            gbCapNhatNoiDung.Enabled = false;
            rbBieuTuongLon.Checked = true;
            LayDsChuyenDeGiaoVienThamGia();
            GanDuLieuVaoListViewDsChuyenDeGiaoVienThamGia();
            GanDuLieuDeXuatTimKiem();
            GanDuLieuVaoCbNamHoc();
        }

        private void GanDuLieuDeXuatTimKiem()
        {
            foreach (DTO.GiaoVienThamGiaChuyenDe i in dsChuyenDeGiaoVienThamGia)
            {
                txtFilter.AutoCompleteCustomSource.Add((string)BUS.ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe);
            }
        }

        private void GanDuLieuVaoCbNamHoc()
        {
            cbNamHoc.Items.Clear();
            dsNamHoc = new List<int>();
            foreach (DTO.GiaoVienThamGiaChuyenDe i in dsChuyenDeGiaoVienThamGia)
            {
                if (dsNamHoc.BinarySearch(i.NamHoc) < 0)
                {
                    dsNamHoc.Add(i.NamHoc);
                    cbNamHoc.Items.Add(i.NamHoc);
                }
            }

        }


        /// <summary>
        /// Lấy danh sách chuyên đề mà giáo viên tham gia.
        /// </summary>
        private void LayDsChuyenDeGiaoVienThamGia()
        {
            this.dsChuyenDeGiaoVienThamGia = BUS.GiaoVienThamGiaChuyenDe.LayDsChuyenDeGiaoVienThamGia();
            this.dataTable = new DataTable();
            this.dataTable.Columns.Add("TenChuyenDe");
            this.dataTable.Columns.Add("MaChuyenDe");
            this.dataTable.Columns.Add("HocKy");
            this.dataTable.Columns.Add("NamHoc");

            foreach (DTO.GiaoVienThamGiaChuyenDe i in dsChuyenDeGiaoVienThamGia)
            {
                DTO.ChuyenDe chuyenDe = BUS.ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe);
                this.dataTable.Rows.Add(chuyenDe.TenChuyenDe.Trim(), chuyenDe.MaChuyenDe.Trim(), i.MaHocKy, i.NamHoc);
            }
            this.dataView = new DataView(this.dataTable);
        }



        /// <summary>
        /// Lấy danh sách nội dung của 1 chuyên đề mà giáo viên tham gia.
        /// </summary>
        /// <param name="chyendeGVTG"> Chuyên đề mà giáo viên tham gia.</param>
        private void LayDsNoiDungLopChuyenCuaMotChuyenDeGiaoVienThamGia(DTO.GiaoVienThamGiaChuyenDe chyendeGVTG)
        {
            this.dsNoiDungLopChuyenDe = BUS.NoiDungLopChuyenDe.LayDSNoiDungChuyenDe(chyendeGVTG);
            if (this.dsNoiDungLopChuyenDe == null)
            {
                return;
            }
            this.dataTable = new DataTable();
            this.dataTable.Columns.Add("TenChuyenDe");
            this.dataTable.Columns.Add("MaChuyenDe");
            this.dataTable.Columns.Add("HocKy");
            this.dataTable.Columns.Add("NamHoc");

            foreach (DTO.GiaoVienThamGiaChuyenDe i in dsChuyenDeGiaoVienThamGia)
            {
                DTO.ChuyenDe chuyenDe = BUS.ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe);
                this.dataTable.Rows.Add(chuyenDe.TenChuyenDe.Trim(), chuyenDe.MaChuyenDe.Trim(), i.MaHocKy, i.NamHoc);
            }
            this.dataView = new DataView(this.dataTable);
        }

        private void GanDuLieuVaoListViewDsChuyenDeGiaoVienThamGia()
        {
            this.lvDsChuyenDeThamGia.Clear();
            foreach (DataRow row in this.dataView.ToTable().Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row[0].ToString();
                item.ImageIndex = 0;
                item.Tag = BUS.GiaoVienThamGiaChuyenDe.LayChuyenDeGiaoVienThamGia(row[1].ToString());
                this.lvDsChuyenDeThamGia.Items.Add(item);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDuongDan.Text = ofd.FileName;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDuongDan.Text))
            {
                MessageBox.Show("Hãy chọn tập tin bạn cần upload!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.Compare(dtpBatDau.Value, dtpKetThuc.Value) > 0)
            {
                MessageBox.Show("Thời gian không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string[] token = txtDuongDan.Text.Split(new char[] { '\\', '.' });
                DTO.GiaoVienThamGiaChuyenDe i = lvDsChuyenDeThamGia.SelectedItems[0].Tag as DTO.GiaoVienThamGiaChuyenDe;
                if (i != null)
                {
                    this.ndLopChuyenDe = new DTO.NoiDungLopChuyenDe();
                    this.ndLopChuyenDe.MaNoiDung = BUS.NoiDungLopChuyenDe.TaoMaNoiDungLopChuyenDeTuDong();
                    this.ndLopChuyenDe.MaGiaoVien = i.MaGiaoVienThamGia;
                    this.ndLopChuyenDe.MaNoiDungChuyenDeGiao = lblMaChuyenDe.Text;
                    this.ndLopChuyenDe.MaChuyenDe = lblMaChuyenDe.Text;
                    this.ndLopChuyenDe.ThoiGianBatDau = dtpBatDau.Value;
                    this.ndLopChuyenDe.ThoiGianKetThuc = dtpKetThuc.Value;
                    this.ndLopChuyenDe.TenNoiDung = token[token.Length - 2];
                    this.ndLopChuyenDe.TheLoai = token[token.Length - 1];
                    this.ndLopChuyenDe.Nam = int.Parse(lblNamHoc.Text);
                    this.ndLopChuyenDe.MaHocKy = lblHocKy.Text;
                    this.ndLopChuyenDe.NoiDungChuyenDe = File.ReadAllBytes(txtDuongDan.Text);
                    this.ndLopChuyenDe.Icon = BUS.NoiDungLopChuyenDe.ImageToBytes(Icon.ExtractAssociatedIcon(txtDuongDan.Text).ToBitmap());

                    bool ketqua = BUS.NoiDungLopChuyenDe.LuuTapTinVaoDataBase(this.ndLopChuyenDe);
                    if (ketqua)
                    {
                        if (this.dsNoiDungLopChuyenDe != null)
                        {
                            GanDuLieuVaoListViewDSNoiDungLopChuyenDe();
                        }
                        MessageBox.Show("Thêm nội dung mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được nội dung mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                lvNoiDungChuyenDe.Clear();
                MessageBox.Show("Có lỗi xảy ra trong quá trình xữ lý!.\n Hãy chọn lại chuyên đề cần thêm nội dung!");
            }
            btnHuy_Click(null, null);
        }

        private void lvNoiDungChuyenDe_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lvNoiDungChuyenDe_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvNoiDungChuyenDe.SelectedItems.Count > 0 && e.Button == MouseButtons.Right)
            {
                DTO.NoiDungLopChuyenDe item = lvNoiDungChuyenDe.SelectedItems[0].Tag as DTO.NoiDungLopChuyenDe;
                if (item != null)
                {
                    lvNoiDungChuyenDe.ContextMenuStrip.Show(e.Location);
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now;
            txtDuongDan.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miXoa_Click(object sender, EventArgs e)
        {
            if (lvNoiDungChuyenDe.SelectedItems.Count > 0)
            {
                DTO.NoiDungLopChuyenDe item = lvNoiDungChuyenDe.SelectedItems[0].Tag as DTO.NoiDungLopChuyenDe;

                DialogResult result = MessageBox.Show("Bạn có muốn xóa '" + lvNoiDungChuyenDe.SelectedItems[0].Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool kq = BUS.NoiDungLopChuyenDe.XoaNoiDungChuyenDe(item.MaNoiDung);
                    if (kq)
                    {
                        if (lvDsChuyenDeThamGia.SelectedItems.Count > 0)
                        {
                            DTO.GiaoVienThamGiaChuyenDe i = lvDsChuyenDeThamGia.SelectedItems[0].Tag as DTO.GiaoVienThamGiaChuyenDe;

                            lblTenChuyenDe.Text = BUS.ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe;
                            lblMaChuyenDe.Text = i.MaChuyenDe;
                            lblHocKy.Text = i.MaHocKy;
                            lblNamHoc.Text = i.NamHoc.ToString();
                            this.dsNoiDungLopChuyenDe = BUS.NoiDungLopChuyenDe.LayDSNoiDungChuyenDe(i);
                            GanDuLieuVaoListViewDSNoiDungLopChuyenDe();
                        }
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể hoàn thành yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có nối dung nào được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miThongTin_Click(object sender, EventArgs e)
        {
            if (lvNoiDungChuyenDe.SelectedItems.Count > 0)
            {
                DTO.NoiDungLopChuyenDe item = lvNoiDungChuyenDe.SelectedItems[0].Tag as DTO.NoiDungLopChuyenDe;
                new DetailForm.Detail_NoiDungLopChuyenDe(item).ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có nối dung nào được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbBieuTuongLon_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDeThamGia.View = View.LargeIcon;
        }

        private void rbBieuTuongNho_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDeThamGia.View = View.SmallIcon;
        }

        private void rbDanhSach_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDeThamGia.View = View.List;
        }

        private void rbLat_CheckedChanged(object sender, EventArgs e)
        {
            lvDsChuyenDeThamGia.View = View.Tile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miChinhSua_Click(object sender, EventArgs e)
        {
            if (lvNoiDungChuyenDe.SelectedItems.Count > 0)
            {
                DTO.NoiDungLopChuyenDe item = lvNoiDungChuyenDe.SelectedItems[0].Tag as DTO.NoiDungLopChuyenDe;
                new DetailForm.Detail_ChinhSuaNoiDungChuyenDe(item).ShowDialog();
                GanDuLieuVaoListViewDSNoiDungLopChuyenDe();
            }
            else
            {
                MessageBox.Show("Không có nối dung nào được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miTaiXuong_Click(object sender, EventArgs e)
        {
            if (lvNoiDungChuyenDe.SelectedItems.Count > 0)
            {
                DTO.NoiDungLopChuyenDe item = lvNoiDungChuyenDe.SelectedItems[0].Tag as DTO.NoiDungLopChuyenDe;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = item.TenNoiDung + "." + item.TheLoai;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileNames[0], BUS.NoiDungLopChuyenDe.LayNoiDungChuyenDe(item.MaNoiDung));
                }
            }
            else
            {
                MessageBox.Show("Không có nối dung nào được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void miLamMoi_Click(object sender, EventArgs e)
        {
            lvDsChuyenDeThamGia_SelectedIndexChanged(null, null);
        }

        private void lvDsChuyenDeThamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDsChuyenDeThamGia.SelectedItems.Count > 0)
            {
                DTO.GiaoVienThamGiaChuyenDe i = lvDsChuyenDeThamGia.SelectedItems[0].Tag as DTO.GiaoVienThamGiaChuyenDe;
                if (i != null)
                {
                    gbCapNhatNoiDung.Enabled = true;
                    lblTenChuyenDe.Text = BUS.ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe;
                    lblMaChuyenDe.Text = i.MaChuyenDe;
                    lblHocKy.Text = i.MaHocKy;
                    lblNamHoc.Text = i.NamHoc.ToString();
                    GanDuLieuVaoListViewDSNoiDungLopChuyenDe();
                }
                else
                {
                    gbCapNhatNoiDung.Enabled = false;
                }
            }
        }

        private void GanDuLieuVaoListViewDSNoiDungLopChuyenDe()
        {
            if (lvDsChuyenDeThamGia.SelectedItems.Count > 0)
            {
                DTO.GiaoVienThamGiaChuyenDe chuyenDeThanGia = lvDsChuyenDeThamGia.SelectedItems[0].Tag as DTO.GiaoVienThamGiaChuyenDe;

                this.dsNoiDungLopChuyenDe = BUS.NoiDungLopChuyenDe.LayDSNoiDungChuyenDe(chuyenDeThanGia);
                this.lvNoiDungChuyenDe.Clear();
                imageList2.Images.Clear();
                if (this.dsNoiDungLopChuyenDe != null)
                {
                    foreach (DTO.NoiDungLopChuyenDe i in this.dsNoiDungLopChuyenDe)
                    {
                        byte[] bytes = BUS.NoiDungLopChuyenDe.LayIconNoiDung(i.MaNoiDung);
                        imageList2.Images.Add(BUS.NoiDungLopChuyenDe.BytesToImage(bytes));
                        ListViewItem item = new ListViewItem();
                        item.Text = i.TenNoiDung + "." + i.TheLoai;
                        item.ImageIndex = imageList2.Images.Count - 1;
                        item.Tag = i;
                        this.lvNoiDungChuyenDe.Items.Add(item);
                    }
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string query = (txtFilter.Text != txtFilter.Hint) ? txtFilter.Text : "";
            dataView.RowFilter = String.Format("TenChuyenDe like '%{0}%'", query);
            GanDuLieuVaoListViewDsChuyenDeGiaoVienThamGia();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
