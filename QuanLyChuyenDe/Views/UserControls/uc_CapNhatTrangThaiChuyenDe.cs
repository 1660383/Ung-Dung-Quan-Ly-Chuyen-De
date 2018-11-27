using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenDe.Models;
using Tulpep.NotificationWindow;

namespace QuanLyChuyenDe.Views.UserControls
{
    public partial class uc_CapNhatTrangThaiChuyenDe : UserControl
    {
        private List<ChuyenDeMo> dsChuyenDeMo;
        private PopupNotifier popup;
        public uc_CapNhatTrangThaiChuyenDe()
        {
            InitializeComponent();
            this.dsChuyenDeMo = new List<ChuyenDeMo>();
            this.popup = new PopupNotifier();
            this.popup.AnimationDuration = 100;
            this.popup.IsRightToLeft = true;
            this.components.Add(popup);
            TaoDSChuyenDeMo(100);
            GanDuLieuVaoListView();
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            btnCapNhat.Enabled = false;
            rbBieuTuongLon.Checked = true;
        }

        /// Xử lý demo
        private void GanDuLieuVaoListView()
        {
            lvChuyenDeMo.Clear();
            ListViewItem item = null;
            foreach (ChuyenDeMo i in this.dsChuyenDeMo)
            {
                item = new ListViewItem();
                item.Text = i.TenChuyenDe;
                item.Tag = i;
                item.ImageIndex = 0;
                lvChuyenDeMo.Items.Add(item);
            }
        }

        // Xử lý demo
        private void TaoDSChuyenDeMo(int sl)
        {
            ChuyenDeMo chuyenDeMo = null;
            for (int i = 0; i < sl; i++)
            {
                chuyenDeMo = new ChuyenDeMo();
                chuyenDeMo.MaChuyenDe = i.ToString();
                chuyenDeMo.TenChuyenDe = "Chuyên đề " + (i + 1);
                dsChuyenDeMo.Add(chuyenDeMo);
            }
        }

        // Xử lý demo
        private void lvChuyenDeMo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChuyenDeMo.SelectedItems.Count > 0)
            {
                ChuyenDeMo chuyenDeMo = (lvChuyenDeMo.SelectedItems[0].Tag as ChuyenDeMo);
                if (chuyenDeMo != null)
                {
                    btnCapNhat.Enabled = true;
                    AnHienYeuCauCapNhat(chuyenDeMo);
                    lblTenChuyenDe.Text = chuyenDeMo.TenChuyenDe;
                    nudSLSinhVienToiDa.Text = chuyenDeMo.SlSinhVienToiDa.ToString();
                    nudSLNhomToiDa.Text = chuyenDeMo.SlNhomToiDa.ToString();
                    dtpBatDau.Value = chuyenDeMo.BatDau;
                    dtpKetThuc.Value = chuyenDeMo.KetThuc;
                }
            }
        }

        private void AnHienYeuCauCapNhat(ChuyenDeMo chuyenDeMo)
        {
            if (chuyenDeMo.SlSinhVienToiDa == 0)
            {
                lbl1.Show();
            }
            else
            {
                lbl1.Hide();
            }
            if (chuyenDeMo.SlNhomToiDa == 0)
            {
                lbl2.Show();
            }
            else
            {
                lbl2.Hide();
            }

            if (DateTime.Compare(chuyenDeMo.BatDau, DateTimePicker.MinimumDateTime) == 0)
            {
                lbl3.Show();
            }
            else
            {
                lbl3.Hide();
            }
            if (DateTime.Compare(chuyenDeMo.KetThuc, DateTimePicker.MinimumDateTime) == 0)
            {
                lbl4.Show();
            }
            else
            {
                lbl4.Hide();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            ChuyenDeMo chuyenDeMo = lvChuyenDeMo.SelectedItems[0].Tag as ChuyenDeMo;
            if (chuyenDeMo != null)
            {
                if (nudSLNhomToiDa.Value < 0
                    || nudSLSinhVienToiDa.Value < 0
                    || DateTime.Compare(dtpBatDau.Value, dtpKetThuc.Value) > 0)
                {
                    this.popup.ContentText = "Dữ liệu không đúng";
                    return;
                }
                else
                {
                    chuyenDeMo.SlNhomToiDa = (int)nudSLNhomToiDa.Value;
                    chuyenDeMo.SlSinhVienToiDa = (int)nudSLSinhVienToiDa.Value;
                    chuyenDeMo.BatDau = dtpBatDau.Value;
                    chuyenDeMo.KetThuc = dtpKetThuc.Value;
                    AnHienYeuCauCapNhat(chuyenDeMo);
                    for (int i = 0; i < this.dsChuyenDeMo.Count; i++)
                    {
                        if (this.dsChuyenDeMo[i].MaChuyenDe == chuyenDeMo.MaChuyenDe)
                        {
                            this.dsChuyenDeMo[i] = chuyenDeMo;
                            break;
                        }
                    }
                    GanDuLieuVaoListView();
                    this.popup.ContentText = "Đã cập nhật";
                    btnCapNhat.Enabled = false;
                }
            }else
            {
                this.popup.ContentText = "Không có đối tượng trở đến";
                btnCapNhat.Enabled = false;
            }

            this.popup.Popup();

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
