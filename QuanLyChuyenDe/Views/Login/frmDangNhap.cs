using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenDe.Views.UserControls;
using QuanLyChuyenDe.Views.Dashboard;

namespace QuanLyChuyenDe.Views.Login
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.ActiveControl = pictureBox1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "sv" && txtMatKhau.Text == "sv")
            {
                FrmBangDieuKhien frmBangDieuKhien = new FrmBangDieuKhien(FrmBangDieuKhien.NguoiDung.SinhVien);
                frmBangDieuKhien.Show();
                this.Hide();
            }
            else if (txtTaiKhoan.Text == "gv" && txtMatKhau.Text == "gv")
            {
                FrmBangDieuKhien frmBangDieuKhien = new FrmBangDieuKhien(FrmBangDieuKhien.NguoiDung.GiaoVien);
                frmBangDieuKhien.Show();
                this.Hide();
            }
            else if (txtTaiKhoan.Text == "gvu" && txtMatKhau.Text == "gvu")
            {
                FrmBangDieuKhien frmBangDieuKhien = new FrmBangDieuKhien(FrmBangDieuKhien.NguoiDung.GiaoVu);
                frmBangDieuKhien.Show();
                this.Hide();
            }                
            
        }

        private void btnThoat_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pnlChinh_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
