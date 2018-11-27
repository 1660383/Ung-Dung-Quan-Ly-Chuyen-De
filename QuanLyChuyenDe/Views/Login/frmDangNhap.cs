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
            this.ActiveControl = pbTenUngDung;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FrmBangDieuKhien frmBangDieuKhien = new FrmBangDieuKhien(FrmBangDieuKhien.NguoiDung.GiaoVien);
            frmBangDieuKhien.Show();
            this.Hide();
            //if(txtTaiKhoan.Text == "sv" && txtMatKhau.Text == "sv")
            //{
            //    FrmBangDieuKhien frmBangDieuKhien = new FrmBangDieuKhien(FrmBangDieuKhien.NguoiDung.SinhVien);
            //    frmBangDieuKhien.Show();
            //    this.Hide();
            //}
            //else if (txtTaiKhoan.Text == "gv" && txtMatKhau.Text == "gv")
            //{
            //    FrmBangDieuKhien frmBangDieuKhien = new FrmBangDieuKhien(FrmBangDieuKhien.NguoiDung.GiaoVien);
            //    frmBangDieuKhien.Show();
            //    this.Hide();
            //}
            //else if (txtTaiKhoan.Text == "gvu" && txtMatKhau.Text == "gvu")
            //{
            //    FrmBangDieuKhien frmBangDieuKhien = new FrmBangDieuKhien(FrmBangDieuKhien.NguoiDung.GiaoVu);
            //    frmBangDieuKhien.Show();
            //    this.Hide();
            //}                

        }

        private void btnThoat_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private bool mouseDown = false;
        private Point mouseDownPos = new Point(0, 0);
        private void pnlChinh_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = !this.mouseDown;
            this.mouseDownPos = e.Location;
        }

        private void pnlChinh_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point(this.Location.X + e.X - mouseDownPos.X, this.Location.Y + e.Y - mouseDownPos.Y);
            }
        }

        private void pnlChinh_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = !this.mouseDown;
            this.mouseDownPos = new Point(0, 0);
        }
    }
}
