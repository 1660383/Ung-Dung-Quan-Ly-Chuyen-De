﻿using System;
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

        private DataView dataView;
        private DataTable dataTable;
        private List<DTO.ThongTinChuyenDeMo> dsChuyenDeDangMo;
        private List<int> dsNamHoc;

        public UC_CapNhatTrangThaiChuyenDe()
        {
            InitializeComponent();
            TaiDuLieuTuDB();
            rbBieuTuongLon.Checked = true;
            groupBox2.Enabled = false;
        }

        public void TaiDuLieuTuDB()
        {
            LayThongTinCacChuyenDeMo();
            TaoDuLieuChoFilter();
            GanDuLieuVaoListview();
            GanDuLieuCbNamHoc();
            GanDuLieuCanTimKiem();
        }

        private void GanDuLieuCanTimKiem()
        {
            foreach (DTO.ThongTinChuyenDeMo i in dsChuyenDeDangMo)
            {
                txtTimKiem.AutoCompleteCustomSource.Add((string)BUS.ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe);
            }
        }

        private void GanDuLieuVaoListview()
        { 
            this.lvChuyenDeMo.Clear();
            if (this.dataView != null)
            {
                foreach (DataRow row in this.dataView.ToTable().Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = row[1].ToString();
                    item.ImageIndex = 0;
                    item.Tag = BUS.ThongTinChuyenDeMo.LayThongTin(row[0].ToString().Trim(),row[2].ToString().Trim(),int.Parse(row[3].ToString()));
                this.lvChuyenDeMo.Items.Add(item);
                }
            }
        }

        private void TaoDuLieuChoFilter()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("MaChuyenDe");
            dataTable.Columns.Add("TenChuyenDe");
            dataTable.Columns.Add("HocKy");
            dataTable.Columns.Add("NamHoc");
            dataTable.Columns.Add("TrangThai");

            foreach (DTO.ThongTinChuyenDeMo i in dsChuyenDeDangMo)
            {
                dataTable.Rows.Add(i.MaChuyenDe, (object)ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe, i.HocKy, i.NamHoc, i.TrangThai);
            }
            dataView = new DataView(dataTable);
        }

        private void LayThongTinCacChuyenDeMo()
        {
            this.dsChuyenDeDangMo = BUS.ThongTinChuyenDeMo.LayDsChuyenDeDangMo();
        }

        private void GanDuLieuCbNamHoc()
        {
            cbNamHoc.Items.Clear();
            dsNamHoc = new List<int>();
            foreach (DTO.ThongTinChuyenDeMo i in dsChuyenDeDangMo)
            {
                if (dsNamHoc.BinarySearch(i.NamHoc) < 0)
                {
                    dsNamHoc.Add(i.NamHoc);
                    cbNamHoc.Items.Add(i.NamHoc);
                }
            }

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!rbVoHieuHoa.Checked && !rbMoChuyenDe.Checked)
            {
                MessageBox.Show("Hãy chọn trạng thái cần cập nhật!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(lvChuyenDeMo.SelectedItems.Count > 0)
            {
                DTO.ThongTinChuyenDeMo chuyenDeMo = lvChuyenDeMo.SelectedItems[0].Tag as DTO.ThongTinChuyenDeMo;

                if (rbMoChuyenDe.Checked)
                {
                    chuyenDeMo.TrangThai = rbMoChuyenDe.Text;

                }else if (rbVoHieuHoa.Checked)
                {
                    chuyenDeMo.TrangThai = rbVoHieuHoa.Text;
                }

                if (BUS.ThongTinChuyenDeMo.CapNhatTrangThaiChuyenDeMo(chuyenDeMo))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox2.Enabled = btnCapNhat.Enabled = false;
                } else
                {
                    MessageBox.Show("Không thể cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        
        private void lvChuyenDeMo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvChuyenDeMo.SelectedItems.Count > 0)
            {
                DTO.ThongTinChuyenDeMo chuyenDeMo = lvChuyenDeMo.SelectedItems[0].Tag as DTO.ThongTinChuyenDeMo;
                if (chuyenDeMo != null)
                {
                    rbMoChuyenDe.Checked = false;
                    rbVoHieuHoa.Checked = false;

                    lblTenChuyenDe.Text = BUS.ChuyenDe.LayThongTinChuyenDe(chuyenDeMo.MaChuyenDe).TenChuyenDe;
                    lblHocKi.Text = chuyenDeMo.HocKy;
                    lblNamHoc.Text = chuyenDeMo.NamHoc.ToString();
                    lbMaChuyenDe.Text = chuyenDeMo.MaChuyenDe;
                    if (chuyenDeMo.TrangThai.Equals("mở"))
                    {
                        rbMoChuyenDe.Checked = true;
                    }
                    else if (chuyenDeMo.TrangThai.Equals("vô hiệu hóa"))
                    {
                        rbVoHieuHoa.Checked = true;
                    }
                    groupBox2.Enabled = true;

                }
            }
        }           
        
        private void rbBieuTuongLon_CheckedChanged_1(object sender, EventArgs e)
        {
            lvChuyenDeMo.View = View.LargeIcon;
        }

        private void rbBieuTuongNho_CheckedChanged_1(object sender, EventArgs e)
        {
            lvChuyenDeMo.View = View.SmallIcon;
        }

        private void rbDanhSach_CheckedChanged_1(object sender, EventArgs e)
        {
            lvChuyenDeMo.View = View.List;
        }

        private void rbLat_CheckedChanged_1(object sender, EventArgs e)
        {
            lvChuyenDeMo.View = View.Tile;
        }

        private void btnMoChuyenDe_Click(object sender, EventArgs e)
        {
            new DetailForm.Detail_MoChuyenDe(this).ShowDialog();
        }

        private void pcbLoad_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cbNamHoc.Text = "";
            cbHocKy.Text = "";
            TaiDuLieuTuDB();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dataView != null)
            {
                string query = txtTimKiem.Text;
                dataView.RowFilter = String.Format("TenChuyenDe like '%{0}%'", query);
                GanDuLieuVaoListview();
            }
        }

        private void cbHocKy_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dataView != null)
            {
                string query = cbHocKy.Text;
                dataView.RowFilter = String.Format("HocKy like '%{0}%'", query);
                GanDuLieuVaoListview();
            }
        }

        private void cbNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dataView != null)
            {
                string query = cbNamHoc.Text;
                dataView.RowFilter = String.Format("NamHoc like '%{0}%'", query);
                GanDuLieuVaoListview();
            }
        }
    }
}
