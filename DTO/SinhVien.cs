using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        private string masv;
        private string manganh;
        private string userid;
        private string tensv;
        private string diachi;
        private string phai;
        private DateTime ngaysinh;
        
        public string MASV { get { return masv; }set { masv = value; } }
        public string MaNganh { get { return manganh; } set { manganh = value; } }
        public string USERID { get { return userid; }set { userid = value; } }
        public string TENSV { get { return tensv; } set { tensv = value; } }
        public string DiaChi { get { return diachi; }set { diachi = value; } }
        public string Phai { get { return phai; }set { phai = value; } }
        public DateTime NgaySinh { get { return ngaysinh; }set { ngaysinh = value; } }
        public SinhVien(string masv,string manganh,string userid,string tensv,string diachi,string phai,DateTime ngaysinh)
        {
            this.masv = masv;
            this.manganh = manganh;
            this.userid = userid;
            this.tensv = tensv;
            this.diachi = diachi;
            this.phai = phai;
            this.ngaysinh = ngaysinh;
        }

    }
}
