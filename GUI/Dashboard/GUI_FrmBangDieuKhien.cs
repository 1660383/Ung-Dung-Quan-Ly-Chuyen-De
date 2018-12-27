using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UserControls;
using GUI.Profile;
using BUS;
namespace GUI.Dashboards
{
    public partial class GUI_BangDieuKhien : Form
    {
        public enum NguoiDung {SinhVien,GiaoVien,GiaoVu};
        private UserControl userControl;
        public GUI_BangDieuKhien()
        {
            InitializeComponent();
            this.userControl.Click += UserControl_Click;

           
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dong");
        }

        public GUI_BangDieuKhien(NguoiDung nguoiDung)
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
            UC_NavigationItem item;
            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_book1;
            item.Text = "Chuyên đề đang mở";          
            item.NavItemClick += Item_NavItemClick;
           // item.NavItem_MouseEnter += new EventHandler(this.Item_NavItem_MouseEnter);
            this.navMenu.AddItem(item);        


            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_book_ok;
            item.Text = "Chuyên đề đã đăng ký";
            this.navMenu.AddItem(item);

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_add_team;
            item.Text = "Đăng ký nhóm";
            this.navMenu.AddItem(item);

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_group_ok;
            item.Text = "Nhóm đã đăng ký";
            this.navMenu.AddItem(item);

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_exam;
            item.Text = "Kết quả học tập";
            this.navMenu.AddItem(item);
        }

        private void TaoBangDieuKhienCuaGiaoVien()
        {
            UC_NavigationItem item;

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_book1;
            item.Text = "Giao chuyên đề";
            item.NavItemClick += Item_NavItemClick1;
            item.NavItem_MouseEnter += Item_NavItem_MouseEnter;
            this.navMenu.AddItem(item);

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_update;
            item.Text = "Cập nhật thông tin chuyên đề";
            item.NavItemClick += Item_NavItemClick2;
            item.NavItem_MouseEnter += Item_NavItem_MouseEnter;
            this.navMenu.AddItem(item);

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_find;
            item.Text = "Tra cứu điểm sinh viên";
            item.NavItemClick += Item_NavItemClick3;
            item.NavItem_MouseEnter += Item_NavItem_MouseEnter;
            this.navMenu.AddItem(item);
        }

        private void TaoBangDieuKhienCuaGiaoVu()
        {
            UC_NavigationItem item;

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_book1;
            item.Text = "Danh sách chuyên đề";
            item.NavItem_MouseEnter += Item_NavItem_MouseEnter;
            this.navMenu.AddItem(item);

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_register;
            item.Text = "Thông tin đăng ký chuyên đề";
            item.NavItemClick += Item_NavItemThongTinDangKeChuyenDeClick;
            item.NavItem_MouseEnter += Item_NavItem_MouseEnter;        
            this.navMenu.AddItem(item);

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_details;
            item.Text = "Chi tiết chuyên đề";
            item.NavItem_MouseEnter += Item_NavItem_MouseEnter;
            this.navMenu.AddItem(item);

            item = new UC_NavigationItem();
            item.Icon =global::GUI.Properties.Resources.ic_find;
            item.Text = "Tra cứu điểm sinh viên";
            item.NavItemClick += Item_NavItemClick3;
            item.NavItem_MouseEnter += Item_NavItem_MouseEnter;
            this.navMenu.AddItem(item);
        }
        private void Item_NavItem_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 500;
            toolTip.AutoPopDelay = 5000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            //lblTenUngDung.Text = sender.ToString();
            //toolTip.SetToolTip(((UC_NavigationItem)sender).Title, ((UC_NavigationItem)sender).Text);
            toolTip.SetToolTip(((UC_NavigationItem)sender).pbIcon, ((UC_NavigationItem)sender).Text);
        }
        private void Item_NavItemThongTinDangKeChuyenDeClick(object sender, EventArgs e)
        {
            if ((this.userControl as UC_ThongTinDangKyChuyenDe) == null)
            {
                this.pnlChinh.Controls.Clear();
                this.userControl = new UC_ThongTinDangKyChuyenDe();
                this.userControl.Dock = DockStyle.Fill;
                this.pnlChinh.Controls.Add(userControl);
            }
        }
        private void Item_NavItemClick3(object sender, EventArgs e)
        {
            if ((this.userControl as UC_TraCuuDiemSinhVien) == null)
            {
                this.pnlChinh.Controls.Clear();
                this.userControl = new UC_TraCuuDiemSinhVien();
                this.userControl.Dock = DockStyle.Fill;
                this.pnlChinh.Controls.Add(userControl);
            }
        }

        private void Item_NavItemClick2(object sender, EventArgs e)
        {
            if ((this.userControl as UC_CapNhatTrangThaiChuyenDe) == null)
            {
                this.pnlChinh.Controls.Clear();
                this.userControl = new UC_CapNhatTrangThaiChuyenDe();
                this.userControl.Dock = DockStyle.Fill;
                this.pnlChinh.Controls.Add(this.userControl);
            }
        }

        private void Item_NavItemClick1(object sender, EventArgs e)
        {
            if ((this.userControl as UC_GiaoNoiDungChuyenDe) == null)
            {
                this.pnlChinh.Controls.Clear();
                this.userControl = new UC_GiaoNoiDungChuyenDe();
                this.userControl.Dock = DockStyle.Fill;
                this.pnlChinh.Controls.Add(this.userControl);
            }
        }      

        private void Item_NavItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyên đề đang mở");
        }
    
        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btn");
        }

        private void UC_NavigationItem1_NavItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("UC_NavigationItem1_NavItemClick");
        }

        private void btnContext_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this.btnContext,0,this.btnContext.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void miThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool phongto = false;
        private Point viTriBanDau;
        private Size kichhThuocBanDau;
        private void miPhongTo_Click(object sender, EventArgs e)
        {
            this.phongto = !this.phongto; 
            if (phongto)
            {               
                this.viTriBanDau = this.Location;
                this.kichhThuocBanDau = this.Size;
                this.miPhongTo.Text = "Thu nhỏ";
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            else
            {
                this.miPhongTo.Text = "Phóng to";
                this.Location = this.viTriBanDau;
                this.Size = this.kichhThuocBanDau;
            }
        }

        private bool mouseDown = false;
        private Point mouseDownPos = new Point(0, 0);
        private void pnlBanner_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = !this.mouseDown;
            this.mouseDownPos = e.Location;
        }

        private void pnlBanner_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point(this.Location.X + e.X - mouseDownPos.X, this.Location.Y + e.Y - mouseDownPos.Y);
            }
        }

        private void pnlBanner_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = !this.mouseDown;
            this.mouseDownPos = new Point(0,0);
        }

        private void lblTenUngDung_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void miDangXuat_Click(object sender, EventArgs e)
        {
            new GUI_DangNhap().Show();            
            this.Hide();
        }

        private void GUI_BangDieuKhien_Load(object sender, EventArgs e)
        {
            lblTenNguoDung.Text = BUS_Users.LayTenNguoiDung();
        }

        private void miCaNhan_Click(object sender, EventArgs e)
        {
            new GUI_ThongTinCaNhan().ShowDialog();
        }

        private void lblTenNguoDung_Click(object sender, EventArgs e)
        {
            new GUI_ThongTinCaNhan().ShowDialog();
        }
    }
}
