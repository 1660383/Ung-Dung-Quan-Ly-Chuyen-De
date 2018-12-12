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

namespace GUI.UserControls
{
    public partial class UC_GiaoNoiDungChuyenDe : UserControl
    {
        
        DTO.DTO_NoiDungLopChuyenDe ndLopChuyenDe;
        DataTable dataTable, dataTable1;
        DataView dataView, dataView1;
        List<DTO.DTO_ChuyenDeGiaoVienThamGia> dsChuyenDeGiaoVienThamGia;
        List<DTO.DTO_NoiDungLopChuyenDe> dsNoiDungLopChuyenDe;

        public UC_GiaoNoiDungChuyenDe()
        {
            InitializeComponent();
            gbCapNhatNoiDung.Enabled = false;
            LayDsChuyenDeGiaoVienThamGia();
            GanDuLieuVaoListViewDsChuyenDeGiaoVienThamGia();
        }

        /// <summary>
        /// Lấy danh sách chuyên đề mà giáo viên tham gia.
        /// </summary>
        private void LayDsChuyenDeGiaoVienThamGia()
        {
            this.dsChuyenDeGiaoVienThamGia = BUS.BUS_ChuyenDeGiaoVienThamGia.LayDsChuyenDeGiaoVienThamGia();
            this.dataTable = new DataTable();
            this.dataTable.Columns.Add("TenChuyenDe");
            this.dataTable.Columns.Add("MaChuyenDe");
            this.dataTable.Columns.Add("HocKy");
            this.dataTable.Columns.Add("NamHoc");

            foreach (DTO.DTO_ChuyenDeGiaoVienThamGia i in dsChuyenDeGiaoVienThamGia)
            {
                var chuyenDe = BUS.BUS_ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe);
                this.dataTable.Rows.Add(chuyenDe.TenChuyenDe.Trim(), chuyenDe.MaChuyenDe.Trim(), i.MaHocKy, i.NamHoc);
            }
            this.dataView = new DataView(this.dataTable);
        }

        /// <summary>
        /// Lấy danh sách nội dung của 1 chuyên đề mà giáo viên tham gia.
        /// </summary>
        /// <param name="chyendeGVTG"> Chuyên đề mà giáo viên tham gia.</param>
        private void LayDsNoiDungLopChuyenCuaMotChuyenDeGiaoVienThamGia(DTO.DTO_ChuyenDeGiaoVienThamGia chyendeGVTG)
        {
            this.dsNoiDungLopChuyenDe = BUS.BUS_NoiDungLopChuyenDe.LayDSNoiDungChuyenDe(chyendeGVTG);
            if (this.dsNoiDungLopChuyenDe == null)
            {
                return;
            } 
            this.dataTable = new DataTable();
            this.dataTable.Columns.Add("TenChuyenDe");
            this.dataTable.Columns.Add("MaChuyenDe");
            this.dataTable.Columns.Add("HocKy");
            this.dataTable.Columns.Add("NamHoc");

            foreach (var i in dsChuyenDeGiaoVienThamGia)
            {
                var chuyenDe = BUS.BUS_ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe);
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
                item.Tag = BUS.BUS_ChuyenDeGiaoVienThamGia.LayChuyenDeGiaoVienThamGia(row[1].ToString());
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
                var i = lvDsChuyenDeThamGia.SelectedItems[0].Tag as DTO.DTO_ChuyenDeGiaoVienThamGia;
                this.ndLopChuyenDe = new DTO.DTO_NoiDungLopChuyenDe();
                this.ndLopChuyenDe.MaNoiDung = BUS.BUS_NoiDungLopChuyenDe.TaoMaNoiDungLopChuyenDeTuDong();
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
                bool ketqua = BUS.BUS_NoiDungLopChuyenDe.LuuTapTinVaoDataBase(this.ndLopChuyenDe);
                if (ketqua)
                {
                    MessageBox.Show("Thêm nội dung mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thêm được nội dung mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình xữ lý");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now;
            txtDuongDan.Text = "";
        }

        private void lvDsChuyenDeThamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDsChuyenDeThamGia.SelectedItems.Count > 0)
            {
                var i = lvDsChuyenDeThamGia.SelectedItems[0].Tag as DTO.DTO_ChuyenDeGiaoVienThamGia;
                if (i != null)
                {
                    gbCapNhatNoiDung.Enabled = true;
                    lblTenChuyenDe.Text = BUS.BUS_ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe;
                    lblMaChuyenDe.Text = i.MaChuyenDe;
                    lblHocKy.Text = i.MaHocKy;
                    lblNamHoc.Text = i.NamHoc.ToString();

                    this.dsNoiDungLopChuyenDe = BUS.BUS_NoiDungLopChuyenDe.LayDSNoiDungChuyenDe(i);

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
           
        }
    }
}
