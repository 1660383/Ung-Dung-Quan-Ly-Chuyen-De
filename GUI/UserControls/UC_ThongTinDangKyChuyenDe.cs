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
    public partial class UC_ThongTinDangKyChuyenDe : UserControl
    {
        private List<DTO.DTO_ChuyenDeDangMo> lchuyenDeMo = new List<DTO.DTO_ChuyenDeDangMo>();
        private DTO.DTO_ChuyenDeDangMo chuyenDeMo = null;
        private int macd = -1;
        private int hocky = -1;
        private int nam = -1;
        public UC_ThongTinDangKyChuyenDe()
        {
            InitializeComponent();
            khoiTaoDuLieuChoChuyenDeMo();
            GanDuLieuVaoCombobox();
            GanDuLieuVaoListView();
        }
        private void khoiTaoDuLieuChoChuyenDeMo()
        {
            lchuyenDeMo = BUS.BUS_ChuyenDeDangMo.LayDsTatCaChuyenDeDangMo();
        }
        private void GanDuLieuVaoListView()
        {
            lvChuyenDeMo.Clear();
            foreach(DTO.DTO_ChuyenDeDangMo row in lchuyenDeMo)
            {
                ListViewItem item = new ListViewItem();
                item.Text = BUS.BUS_ChuyenDe.LayThongTinChuyenDe(row.MaChuyenDe).TenChuyenDe;
                item.Tag = row;
                item.ImageIndex = 0;
                lvChuyenDeMo.Items.Add(item);
            }
        }
        private void GanDuLieuVaoCombobox()
        {
            foreach (DTO.DTO_ChuyenDeDangMo row in lchuyenDeMo)
            {
                cbHocKy.Items.Add(row.HocKy);
                cbMaCD.Items.Add(row.MaChuyenDe);
                cbNamHoc.Items.Add(row.NamHoc);
            }
        }
        private void rbBieuTuongLon_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBieuTuongLon.Checked)
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
                lblMaChuyenDe.Text = chuyenDeMo.MaChuyenDe;
                txtSLNhom.Text = chuyenDeMo.SlNhomToiDa.ToString();
                dtpBatDau.Value = chuyenDeMo.ThoiGianBD;
                this.txtSLDK.Text = BUS.BUS_DANGKY_LOP_CHUYENDE.SoLuongNguoiDangKy(chuyenDeMo).ToString();
                dtpKetThuc.Value = chuyenDeMo.ThoiGianKT;
                lblMaChuyenDe.Text = chuyenDeMo.MaChuyenDe;
                txtTrangThai.Text = chuyenDeMo.TrangThai;
                groupBox2.Show();

            }
            else
            {
                chuyenDeMo = null;
                groupBox2.Hide();
            }
        }
        private object getOrNull(object sender, int i)
        {
            if (i < 0) return "";
            else return ((ComboBox)sender).Items[i];
        }
        private void cbMaCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            macd = cbMaCD.SelectedIndex;
            lchuyenDeMo = BUS.BUS_ChuyenDeDangMo.LayDanhSachChuyenDeMoCoDieuKiem(getOrNull(cbMaCD,macd).ToString(),getOrNull(cbHocKy, hocky).ToString(), getOrNull(cbNamHoc, nam).ToString());
            GanDuLieuVaoListView();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocky = cbHocKy.SelectedIndex;
            lchuyenDeMo = BUS.BUS_ChuyenDeDangMo.LayDanhSachChuyenDeMoCoDieuKiem(getOrNull(cbMaCD, macd).ToString(), getOrNull(cbHocKy, hocky).ToString(), getOrNull(cbNamHoc, nam).ToString());
            GanDuLieuVaoListView();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            nam = cbNamHoc.SelectedIndex;
            lchuyenDeMo = BUS.BUS_ChuyenDeDangMo.LayDanhSachChuyenDeMoCoDieuKiem(getOrNull(cbMaCD, macd).ToString(), getOrNull(cbHocKy, hocky).ToString(), getOrNull(cbNamHoc, nam).ToString());
            GanDuLieuVaoListView();
        }

        private void pcbLoad_Click(object sender, EventArgs e)
        {
            macd = -1;
            nam = -1;
            hocky = -1;
            cbMaCD.SelectedIndex = -1;
            cbNamHoc.SelectedIndex = -1;
            cbHocKy.SelectedIndex = -1;
            khoiTaoDuLieuChoChuyenDeMo();
            GanDuLieuVaoListView();
        }
    }
}
