using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLyChuyenDe.Views.UserControls
{
    public partial class NavigationDrawer : UserControl
    {
        public EventHandler ItemClick;
        private int maxWidth = 250;
        private int minWidth = 50;
        private bool autoSetItemWidth = true;
        private bool flag = true;
        private int speed = 20;
        private List<NavigationItem> items;


        public NavigationDrawer()
        {
            InitializeComponent();
            this.items = new List<NavigationItem>();
        }
        protected void onItemClick(EventArgs e)
        {
            ItemClick?.Invoke(this, e);
        }


        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public bool Flag
        {
            get
            {
                return flag;
            }

            set
            {
                flag = value;
               // this.btnHamberger_Click(this,EventArgs.Empty);
            }
        }

        public int MaxWidth
        {
            get
            {
                return maxWidth;
            }

            set
            {
                maxWidth = value;

            }
        }

        public int MinWidth
        {
            get
            {
                return minWidth;
            }

            set
            {
                minWidth = value;
            }
        }

        public bool AutoSetItemWidth
        {
            get
            {
                return autoSetItemWidth;
            }

            set
            {
                autoSetItemWidth = value;
            }
        }

        public List<NavigationItem> GetItemList()
        {
            return this.items;
        }

        public NavigationItem GetItem(int index)
        {
            return (index >= 0 && index < this.items.Count) ? this.items[index] : null;
        }

        public bool AddItem(NavigationItem navigationItem)
        {
            if (navigationItem != null)
            {
                int height = 0;
                foreach(var item in this.items)
                {
                    height += item.Height;
                }
                navigationItem.Location = new Point(0,height);
                if (this.autoSetItemWidth) navigationItem.Width = this.maxWidth;
                this.items.Add(navigationItem);
                this.splitContainer1.Panel2.Controls.Add(navigationItem);
                return true;
            }
            return false;
        }

        private void btnHamberger_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                this.items[i].Title.Hide();
            }

            if (flag)
            {
                flag = false;
                this.btnHamberger.Image = global::QuanLyChuyenDe.Properties.Resources.ic_V_hamberger_1;              
                for (int i = 0; i <= (this.MaxWidth - this.MinWidth) / this.speed; i++)
                {
                    if (this.Size.Width + this.speed <= this.maxWidth)
                    {
                        this.Size = new Size(this.Size.Width + speed, this.Size.Height);
                    }
                    else
                    {
                        this.Size = new Size(this.MaxWidth, this.Size.Height);
                    }
                }              
            }
            else
            {
                flag = true;
                this.btnHamberger.Image = global::QuanLyChuyenDe.Properties.Resources.ic_hamberger4;
                for (int i = 0; i <= (this.MaxWidth - this.MinWidth) / this.speed; i++)
                {
                    if (this.Size.Width - this.speed > this.minWidth)
                    {
                        this.Size = new Size(this.Size.Width - speed, this.Size.Height);
                    }
                    else
                    {
                        this.Size = new Size(this.minWidth, this.Size.Height);
                    }
                }
            }
            for (int i = 0; i < this.items.Count; i++)
            {
                this.items[i].Title.Show();
            }
        }
    }
}
