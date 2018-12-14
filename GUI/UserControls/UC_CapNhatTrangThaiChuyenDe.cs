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
        private List<DTO.DTO_ChuyenDeDangMo> dsChuyenDeDangMo;
        private List<int> dsNamHoc;
        private DTO.DTO_ChuyenDeDangMo chuyenDeMo = null;

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
            foreach (DTO.DTO_ChuyenDeDangMo i in dsChuyenDeDangMo)
            {
                txtTimKiem.AutoCompleteCustomSource.Add(BUS.BUS_ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe);
            }
        }

        private void GanDuLieuVaoListview()
        {
            lvChuyenDeMo.Clear();
            foreach (DataRow row in dataView.ToTable().Rows)
            {
                for (int i = 0; i < this.dsChuyenDeDangMo.Count; i++)
                {
                    if (this.dsChuyenDeDangMo[i].MaChuyenDe == row[0].ToString()
                        && this.dsChuyenDeDangMo[i].HocKy == row[2].ToString()
                        && this.dsChuyenDeDangMo[i].NamHoc == int.Parse(row[3].ToString())
                        && this.dsChuyenDeDangMo[i].TrangThai == row[4].ToString())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = BUS_ChuyenDe.LayThongTinChuyenDe(this.dsChuyenDeDangMo[i].MaChuyenDe).TenChuyenDe;
                        item.Tag = this.dsChuyenDeDangMo[i];
                        item.ImageIndex = 0;
                        lvChuyenDeMo.Items.Add(item);
                    }
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

            foreach (DTO.DTO_ChuyenDeDangMo i in dsChuyenDeDangMo)
            {
                dataTable.Rows.Add(i.MaChuyenDe, BUS_ChuyenDe.LayThongTinChuyenDe(i.MaChuyenDe).TenChuyenDe, i.HocKy, i.NamHoc, i.TrangThai);
            }
            dataView = new DataView(dataTable);
        }

        private void LayThongTinCacChuyenDeMo()
        {
            this.dsChuyenDeDangMo = BUS.BUS_ChuyenDeDangMo.LayDsChuyenDeDangMo();
        }

        private void GanDuLieuCbNamHoc()
        {
            cbNamHoc.Items.Clear();
            dsNamHoc = new List<int>();
            foreach (DTO.DTO_ChuyenDeDangMo i in dsChuyenDeDangMo)
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
            DTO.DTO_ChuyenDe cd = BUS.BUS_ChuyenDe.LayThongTinChuyenDe(chuyenDeMo.MaChuyenDe); 
            if (chuyenDeMo != null)
            {
                if (BUS.BUS_ChuyenDeDangMo.CapNhatTrangThaiChuyenDeMo(chuyenDeMo))
                {
                    MessageBox.Show(" Chuyên đề \n\t" + "\n\t Mã CD : "+cd.MaChuyenDe+ "\n\t Chuyên Đề : " + cd.TenChuyenDe);
                }
                else
                {
                    MessageBox.Show(" Trạng Thái chuyên đề cần được cập nhật ");
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
            chuyenDeMo = e.Item.Tag as DTO.DTO_ChuyenDeDangMo;
            if (chuyenDeMo != null)
            {
                lblTenChuyenDe.Text = e.Item.Text;
                lblHocKi.Text = chuyenDeMo.HocKy;
                lblNamHoc.Text = chuyenDeMo.NamHoc.ToString();
                lbMaChuyenDe.Text =chuyenDeMo.MaChuyenDe;
                if(chuyenDeMo.TrangThai == rbMoChuyenDe.Text)
                {
                    rbMoChuyenDe.Checked = true;
                }else if(chuyenDeMo.TrangThai == rbVoHieuHoa.Text)
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

        private void rbMoChuyenDe_CheckedChanged(object sender, EventArgs e)
        {
            chuyenDeMo.TrangThai = rbMoChuyenDe.Text;

        }

        private void rbVoHieuHoa_CheckedChanged(object sender, EventArgs e)
        {
            chuyenDeMo.TrangThai = rbVoHieuHoa.Text;
        }
    }
}
