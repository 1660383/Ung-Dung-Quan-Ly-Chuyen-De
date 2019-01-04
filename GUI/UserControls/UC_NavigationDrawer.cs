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

namespace GUI.UserControls
{
    public partial class UC_NavigationDrawer : UserControl
    {
        public EventHandler ItemClick;
        private int maxWidth = 250;
        private int minWidth = 50;
        private bool autoSetItemWidth = true;
        private bool expand = false;
        private int speed = 20;
        private List<UC_NavigationItem> items;


        public UC_NavigationDrawer()
        {
            InitializeComponent();
            this.items = new List<UC_NavigationItem>();           
        }

        protected void onItemClick(EventArgs e)
        {
            ItemClick?.Invoke(this, e);
        }


        public int Speed
        {
            get { return speed; }

            set { speed = value; }
        }

        public bool Expand
        {
            get { return expand; }

            set { expand = value; }
        }

        public int MaxWidth
        {
            get { return maxWidth; }

            set { maxWidth = value; }
        }

        public int MinWidth
        {
            get { return minWidth; }

            set { minWidth = value; }
        }

        public bool AutoSetItemWidth
        {
            get { return autoSetItemWidth; }
            set { autoSetItemWidth = value; }
        }

        public List<UC_NavigationItem> GetItemList()
        {
            return this.items;
        }

        public UC_NavigationItem GetItem(int index)
        {
            return (index >= 0 && index < this.items.Count) ? this.items[index] : null;
        }

        public bool AddItem(UC_NavigationItem UC_NavigationItem)
        {
            if (UC_NavigationItem != null)
            {
                int height = 0;
                foreach (var item in this.items)
                {
                    height += item.Height;
                }
                UC_NavigationItem.Location = new Point(0, height);
                if (this.autoSetItemWidth) UC_NavigationItem.Width = this.maxWidth;
                this.items.Add(UC_NavigationItem);
                this.splitContainer1.Panel2.Controls.Add(UC_NavigationItem);
                return true;
            }
            return false;
        }

        private void btnHamberger_Click(object sender, EventArgs e)
        {

            if (expand == false)
            {
                Open();
            }
            else
            {
                Close();
            }

        }



        public void Open()
        {
            expand = true;
            for (int i = 0; i < this.items.Count; i++)
            {
                this.items[i].Title.Hide();
            }
            this.btnHamberger.Image = global::GUI.Properties.Resources.ic_V_hamberger_1;
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
            for (int i = 0; i < this.items.Count; i++)
            {
                this.items[i].Title.Show();
            }
        }
        public void Close()
        {
            expand = false;
            for (int i = 0; i < this.items.Count; i++)
            {
                this.items[i].Title.Hide();
            }
            this.btnHamberger.Image = global::GUI.Properties.Resources.ic_hamberger5;
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
            for (int i = 0; i < this.items.Count; i++)
            {
                this.items[i].Title.Show();
            }
        }
        private void UC_NavigationDrawer_MouseClick_1(object sender, MouseEventArgs e)
        {
            expand = false;
            this.btnHamberger.Image = global::GUI.Properties.Resources.ic_hamberger5;
            for (int i = 0; i <= (this.MaxWidth - this.MinWidth) / this.speed; i++)
            {
                if (this.Size.Width - this.speed > this.minWidth)
                {
                    this.Size = new Size(this.Size.Width - speed, this.Size.Height);
                    //panel1.Size = new Size(this.Size.Width - speed, this.Size.Height);

                }
                else
                {
                    this.Size = new Size(this.minWidth, this.Size.Height);
                    // panel1.Size = new Size(this.minWidth, this.Size.Height);

                }
            }
        }
    }
}
