using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Dashboards;
using BUS;
namespace GUI
{
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
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
            string tenDangNhap, matKhau;
            if (String.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
            {
                txtTaiKhoan.Focus();
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tenDangNhap = txtTaiKhoan.Text.Trim();

            if (String.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                txtMatKhau.Focus();
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            matKhau = txtMatKhau.Text.Trim();

            BUS_Users.LoaiTaiKhoan loaiTaiKhoan = BUS_Users.DangNhap(tenDangNhap, matKhau);
            GUI_BangDieuKhien guiBangDieuKhien;
            switch (loaiTaiKhoan)
            {
                case BUS_Users.LoaiTaiKhoan.SINHVIEN:
                    LuuThongTinDangNhap();
                    guiBangDieuKhien = new GUI_BangDieuKhien(GUI_BangDieuKhien.NguoiDung.SinhVien);
                    guiBangDieuKhien.Show();
                    this.Hide();
                    break;
                case BUS_Users.LoaiTaiKhoan.GIAOVIEN:
                    LuuThongTinDangNhap();
                    guiBangDieuKhien = new GUI_BangDieuKhien(GUI_BangDieuKhien.NguoiDung.GiaoVien);
                    guiBangDieuKhien.Show();
                    this.Hide();
                    break;
                case BUS_Users.LoaiTaiKhoan.GIAOVU:
                    LuuThongTinDangNhap();
                    guiBangDieuKhien = new GUI_BangDieuKhien(GUI_BangDieuKhien.NguoiDung.GiaoVu);
                    guiBangDieuKhien.Show();
                    this.Hide();
                    break;
                case BUS_Users.LoaiTaiKhoan.WRONG:
                    MessageBox.Show("Thông tin đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
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

        private void LuuThongTinDangNhap()
        {
            GUI.Properties.Settings.Default.Check = ckbGiuDangNhap.Checked;
            if (ckbGiuDangNhap.Checked)
            {
                GUI.Properties.Settings.Default.Username = txtTaiKhoan.Text.Trim();
                GUI.Properties.Settings.Default.Password = txtMatKhau.Text.Trim();
            }
            else
            {
                GUI.Properties.Settings.Default.Username = "";
                GUI.Properties.Settings.Default.Password = "";
            }
            GUI.Properties.Settings.Default.Save();
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            ckbGiuDangNhap.Checked = GUI.Properties.Settings.Default.Check;
            if (GUI.Properties.Settings.Default.Check)
            {
                txtTaiKhoan.Text = GUI.Properties.Settings.Default.Username;
                txtMatKhau.Text = GUI.Properties.Settings.Default.Password;
            }
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.ForeColor = Color.Red;          
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.ForeColor = SystemColors.Control;
        }
    }
}
