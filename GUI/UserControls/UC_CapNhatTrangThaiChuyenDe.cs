using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace GUI.UserControls
{
    public partial class UC_CapNhatTrangThaiChuyenDe : UserControl
    {
        private PopupNotifier popup;
        public UC_CapNhatTrangThaiChuyenDe()
        {
            InitializeComponent();
            this.popup = new PopupNotifier();
            this.popup.AnimationDuration = 100;
            this.popup.IsRightToLeft = true;
            this.components.Add(popup);           
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            btnCapNhat.Enabled = false;
            rbBieuTuongLon.Checked = true;
        }

       
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           

        }

        private void rbBieuTuongLon_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbBieuTuongLon.Checked)
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
        
        private void lblTenChuyenDe_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 500;
            toolTip.AutoPopDelay = 5000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;    
            toolTip.SetToolTip(this.lblTenChuyenDe, this.lblTenChuyenDe.Text);
        }
    }
}
