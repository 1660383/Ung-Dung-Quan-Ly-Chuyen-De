using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users
    {
        private string idTaiKhoan;
        private string idPhanHe;
        private string tenDangNhap;
        private string matKhau;

        public Users()
        {

        }
        public string IdTaiKhoan
        {
            get { return idTaiKhoan; }

            set { idTaiKhoan = value; }
        }

        public string IdPhanHe
        {
            get { return idPhanHe; }

            set { idPhanHe = value; }
        }

        public string TenDangNhap
        {
            get { return tenDangNhap; }

            set { tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }

            set { matKhau = value; }
        }

        public Users(string idTaiKhoan, string idPhanHe, string tenDangNhap, string matKhau)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.idPhanHe = idPhanHe;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }
    }
}
