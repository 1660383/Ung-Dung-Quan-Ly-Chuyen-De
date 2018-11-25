using QuanLyChuyenDe.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenDe.Views.Dashboard
{
    public partial class FrmBangDieuKhien : Form
    {
        public enum NguoiDung {SinhVien,GiaoVien,GiaoVu};
        public FrmBangDieuKhien()
        {
            InitializeComponent();


           
        }

        public FrmBangDieuKhien(NguoiDung nguoiDung)
        {
            InitializeComponent();
            switch (nguoiDung)
            {
                case NguoiDung.GiaoVien:
                    TaoBangDieuKhienCuaGiaoVien();
                    break;
                case NguoiDung.GiaoVu:
                    TaoBangDieuKhienCuaGiaoVu();
                    break;
                case NguoiDung.SinhVien:
                    TaoBangDieuKhienCuaSinhVien();
                    break;
            }
        }
  
        private void TaoBangDieuKhienCuaSinhVien()
        {
            NavigationItem item;

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_book1;
            item.Text = "Chuyên đề đang mở";
            item.NavItemClick += Item_NavItemClick;
            this.navMenu.AddItem(item);

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_book_ok;
            item.Text = "Chuyên đề đã đăng ký";
            this.navMenu.AddItem(item);

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_add_team;
            item.Text = "Đăng ký nhóm";
            this.navMenu.AddItem(item);

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_group_ok;
            item.Text = "Nhóm đã đăng ký";
            this.navMenu.AddItem(item);

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_exam;
            item.Text = "Kết quả học tập";
            this.navMenu.AddItem(item);
        }
        private void TaoBangDieuKhienCuaGiaoVien()
        {
            NavigationItem item;

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_book1;
            item.Text = "Giao chuyên đề";
            this.navMenu.AddItem(item);

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_update;
            item.Text = "Cập nhật trạng thái chuyên đề";
            this.navMenu.AddItem(item);

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_find;
            item.Text = "Tra cứu điểm sinh viên";
            this.navMenu.AddItem(item);
        }

        private void TaoBangDieuKhienCuaGiaoVu()
        {
            NavigationItem item;

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_book1;
            item.Text = "Danh sách chuyên đề";
            this.navMenu.AddItem(item);

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_register;
            item.Text = "Thông tin đăng ký chuyên đề";
            this.navMenu.AddItem(item);
          
            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_details;
            item.Text = "Chi tiết chuyên đề";
            this.navMenu.AddItem(item);

            item = new NavigationItem();
            item.Icon = global::QuanLyChuyenDe.Properties.Resources.ic_find;
            item.Text = "Tra cứu điểm sinh viên";
            this.navMenu.AddItem(item);
        }
        private void Item_NavItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyên đề đang mở");
        }

        private void FrmBangDieuKhien_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btn");
        }

        private void navigationItem1_NavItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("navigationItem1_NavItemClick");
        }

        private void btnContext_Click(object sender, EventArgs e)
        {

        }
    }
}
