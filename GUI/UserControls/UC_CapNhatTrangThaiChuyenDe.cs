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

        private DataView dataView;
        private DataTable dataTable;
        private List<DTO.ThongTinChuyenDeMo> dsChuyenDeDangMo;
        private List<int> dsNamHoc;
        public UC_CapNhatTrangThaiChuyenDe()
        {
            InitializeComponent();
            TaiDuLieuTuDB();
            groupBox2.Hide();
            btnCapNhat.Enabled = true;
            rbBieuTuongLon.Checked = true;
        }

        private void TaiDuLieuTuDB()
        {
            //LayThongTinCacChuyenDeGiaoVienThamGia();
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
            lvChuyenDeMo.Clear();
            foreach (DTO.ThongTinChuyenDeMo i in dsChuyenDeDangMo)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe;
                item.Tag = i;
                item.ImageIndex = 0;
                lvChuyenDeMo.Items.Add(item);
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
                }else
                {
                    MessageBox.Show("Không thể cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                    if (chuyenDeMo.TrangThai.Equals(rbMoChuyenDe.Text))
                    {
                        rbMoChuyenDe.Checked = true;
                    }
                    else if (chuyenDeMo.TrangThai.Equals(rbVoHieuHoa.Text))
                    {
                        rbVoHieuHoa.Checked = true;
                    }
                    groupBox2.Show();

                }
                else
                {
                    chuyenDeMo = null;
                    groupBox2.Hide();
                }
            }
        }      

        private void lvChuyenDeMo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
