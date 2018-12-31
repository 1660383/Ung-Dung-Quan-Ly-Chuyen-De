using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DetailForm
{
    public partial class Detail_NoiDungLopChuyenDe : Form
    {
        public Detail_NoiDungLopChuyenDe()
        {
            InitializeComponent();
        }

        public Detail_NoiDungLopChuyenDe(DTO.NoiDungLopChuyenDe noiDungChuyenDe)
        {
            InitializeComponent();
            Image img = BUS.NoiDungLopChuyenDe.BytesToImage(BUS.NoiDungLopChuyenDe.LayIconNoiDung(noiDungChuyenDe.MaNoiDung));
            Bitmap thumb = (Bitmap)img.GetThumbnailImage(64, 64, null, IntPtr.Zero);
            thumb.MakeTransparent();
            this.Icon = Icon.FromHandle(thumb.GetHicon());
            this.lblTenNoiDung.Text = noiDungChuyenDe.TenNoiDung;
            this.lblMaNoiDung.Text = noiDungChuyenDe.MaNoiDung;
            this.lblHocKy.Text = noiDungChuyenDe.MaHocKy;
            this.lblNamHoc.Text = noiDungChuyenDe.Nam.ToString();
            this.lblLoaiTapTin.Text = noiDungChuyenDe.TheLoai;
            this.lblThoiGianBatDau.Text = noiDungChuyenDe.ThoiGianBatDau.ToString();
            this.lblThoiGianKetThuc.Text = noiDungChuyenDe.ThoiGianKetThuc.ToString();

        }

        private void Detail_NoiDungLopChuyenDe_Load(object sender, EventArgs e)
        {

        }
    }
}
