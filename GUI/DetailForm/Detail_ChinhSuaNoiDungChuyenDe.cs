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
    public partial class Detail_ChinhSuaNoiDungChuyenDe : Form
    {
        DTO.NoiDungLopChuyenDe noiDungChuyenDe;
        public Detail_ChinhSuaNoiDungChuyenDe()
        {
            InitializeComponent();
        }

        public Detail_ChinhSuaNoiDungChuyenDe(DTO.NoiDungLopChuyenDe noiDungChuyenDe)
        {
            InitializeComponent();
            this.noiDungChuyenDe = noiDungChuyenDe;
            Image img = BUS.NoiDungLopChuyenDe.BytesToImage(BUS.NoiDungLopChuyenDe.LayIconNoiDung(noiDungChuyenDe.MaNoiDung));
            Bitmap thumb = (Bitmap)img.GetThumbnailImage(64, 64, null, IntPtr.Zero);
            thumb.MakeTransparent();
            this.Icon = Icon.FromHandle(thumb.GetHicon());
            this.txtTenNoiDung.Text = noiDungChuyenDe.TenNoiDung;
            this.lblMaNoiDung.Text = noiDungChuyenDe.MaNoiDung;
            this.lblHocKy.Text = noiDungChuyenDe.MaHocKy;
            this.lblNamHoc.Text = noiDungChuyenDe.Nam.ToString();
            this.lblLoaiTapTin.Text = noiDungChuyenDe.TheLoai;
            this.dtpThoiGianBatDau.Value = noiDungChuyenDe.ThoiGianBatDau;
            this.dtpThoiGianKetThuc.Value = noiDungChuyenDe.ThoiGianKetThuc;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenNoiDung.Text))
            {
                MessageBox.Show("Không được để trống tên nội dung!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.Compare(dtpThoiGianBatDau.Value, dtpThoiGianKetThuc.Value) > 0)
            {
                MessageBox.Show("Thời gian không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.noiDungChuyenDe.TenNoiDung = txtTenNoiDung.Text;
            this.noiDungChuyenDe.ThoiGianBatDau = dtpThoiGianBatDau.Value;
            this.noiDungChuyenDe.ThoiGianKetThuc = dtpThoiGianKetThuc.Value;         

            bool kq = BUS.NoiDungLopChuyenDe.CapNhapDungChuyenDe(this.noiDungChuyenDe);
            if (kq)
            {
                btnHuy.Text = "Đóng";
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Không thể thực hiên yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Detail_ChinhSuaNoiDungChuyenDe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
