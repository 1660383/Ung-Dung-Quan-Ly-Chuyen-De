using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenDe.Views.UserControls
{
    public partial class NavigationItem : UserControl
    {
        public event EventHandler NavItemClick;
        public event EventHandler NavItem_MouseEnter;
        public event EventHandler NavItem_MouseLeave;

        public Image Icon
        {
            get
            {
                return this.pbIcon.Image;
            }

            set
            {
                this.pbIcon.Image = value;
            }
        }
        public override string Text
        {
            get
            {
                return this.Title.Text;
            }

            set
            {
                this.Title.Text = value;
            }
        }

        public NavigationItem()
        {            
            InitializeComponent();
        }
        protected virtual void OnNavItemClick(EventArgs e)
        {
            NavItemClick?.Invoke(this, e);
        }

        protected virtual void OnNavItem_MouseEnter(object sender, EventArgs e)
        {
            NavItem_MouseEnter?.Invoke(this, e);
        }
        protected virtual void OnNavItem_MouseLeave(EventArgs e)
        {
            NavItem_MouseLeave?.Invoke(this, e);
        }
        private void Title_MouseEnter(object sender, EventArgs e)
        {
            this.OnNavItem_MouseEnter(sender,e);
            this.Title.BackColor = Color.FromArgb(170, 197, 230);
            this.pbIcon.BackColor = Color.FromArgb(170, 197, 230);
        }

        private void Title_MouseLeave(object sender, EventArgs e)
        {           
            this.Title.BackColor = Color.FromArgb(47, 85, 130);
            this.pbIcon.BackColor = Color.FromArgb(47, 85, 130);
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            this.OnNavItemClick(e);
        }

        private void Title_Click(object sender, EventArgs e)
        {
            this.OnNavItemClick(e);
        }
    }
}
