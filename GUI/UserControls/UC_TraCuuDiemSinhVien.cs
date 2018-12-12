using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI.UserControls
{
    public partial class UC_TraCuuDiemSinhVien : UserControl
    {
        // take data from namepase BUS
        private List<DTO_KetQua> listKetQua = BUS_KetQua.LayDanhSachKetQua();
        private int chuyende = -1;
        private int hocky = -1;
        private int namhoc = -1;
        public UC_TraCuuDiemSinhVien()
        {
            InitializeComponent();
            themDuLieuDenCombobox();
            layDuLieu();
        }
        private void themDuLieuDenCombobox()
        {
            foreach (DTO_KetQua kq in listKetQua)
            {
                cbMaCD.Items.Add(kq.MaCD);
                cbNamHoc.Items.Add(kq.Nam);
                cbHocKy.Items.Add(kq.MaHK);
            }
        }
        private void themDuLieuDenDataGridView(object sender)
        {
            dgvKetQua.DataSource = sender;
        }
        private void themDuLieuThongTinSinhVien(DTO_SinhVien sinhvien)
        {

            if (sinhvien != null)
            {
                themDuLieuDenDataGridView(BUS_KetQua.LayDanhSachKetQuaTheoMaSinhVien(sinhvien.MASV));
                DTO_Nganh nganh = BUS_Nganh.LayNganh(sinhvien.MaNganh);
                lblHoTenSV.Text = sinhvien.TENSV;
                lblMSSV.Text = sinhvien.MASV;
                lblNganh.Text = nganh.TenNganh;
                lblSoChiHoanthanh.Text = BUS_KetQua.SoMonDauCuaSinhVien(sinhvien.MASV) + "/" + nganh.SoChuyenDeToiDa;
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = null; 
            layDuLieu();
        }
        private void layDuLieu()
        {
            AnThongTinSinhVien();
            themDuLieuDenDataGridView(BUS_KetQua.LayDanhSachKetQua(layDuLieuTextBox(txtMssv).ToString(), layDuLieuTextBox(txtTensv).ToString(), getOrNull(cbMaCD, chuyende).ToString(), getOrNull(cbHocKy, hocky).ToString(), getOrNull(cbNamHoc, namhoc).ToString()));
        }
        private void cbMaCD_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            chuyende = cbMaCD.SelectedIndex;
            layDuLieu();
 
        }
        private object getOrNull(object sender, int i)
        {
            if (i < 0) return "";
            else return ((ComboBox)sender).Items[i];
        }
        private object layDuLieuTextBox(MyTextBox tb)
        {
            if (tb.Text == tb.Hint) return "";
            return tb.Text;
        }
        private bool kiemTraDaChonTatCaCombobox()
        {
            if (chuyende != -1 && namhoc != -1 && hocky != -1) return true;
            return false;

        }
        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocky = cbHocKy.SelectedIndex;
            layDuLieu();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            namhoc = cbNamHoc.SelectedIndex;
            layDuLieu();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }       
        private bool AnThongTinSinhVien()
        {
            DTO_SinhVien sinhvien = BUS_SinhVien.LaySinhVien(txtMssv.Text);
            if (this.txtMssv.Text == txtMssv.Hint || sinhvien == null)
            {
                splitContainer1.Panel1Collapsed = true;
                groupBox3.Height = 93;
                btnInPhieu.Location = new Point(btnInPhieu.Location.X, 10);
                btnTimKiem.Location = new Point(btnInPhieu.Location.X, 56);
                return true;
            }
            splitContainer1.Panel1Collapsed = false;
            groupBox3.Height = 114;
            btnInPhieu.Location = new Point(btnInPhieu.Location.X, 25);
            btnTimKiem.Location = new Point(btnInPhieu.Location.X, 71); 
            return false;
        }

        private void pcbLoad_Click(object sender, EventArgs e)
        {
            chuyende = -1;
            hocky = -1;
            namhoc = -1;
            cbHocKy.SelectedIndex = -1;
            cbMaCD.SelectedIndex = -1;
            cbNamHoc.SelectedIndex = -1;
        }
    }
}
