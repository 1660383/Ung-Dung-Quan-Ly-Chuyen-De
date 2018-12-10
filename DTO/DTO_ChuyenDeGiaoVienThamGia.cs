using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuyenDeGiaoVienThamGia
    {
        string maGiaoVienThamGia;
        string maChuyenDe;
        int namHoc;
        string maHocKy;

        public DTO_ChuyenDeGiaoVienThamGia()
        {

        }

        public DTO_ChuyenDeGiaoVienThamGia(string maGiaoVienThamGia, string maChuyenDe, int namHoc, string maHocKy)
        {
            this.maGiaoVienThamGia = maGiaoVienThamGia;
            this.maChuyenDe = maChuyenDe;
            this.namHoc = namHoc;
            this.maHocKy = maHocKy;
        }

        public string MaGiaoVienThamGia
        {
            get
            {
                return maGiaoVienThamGia;
            }

            set
            {
                maGiaoVienThamGia = value;
            }
        }

        public string MaChuyenDe
        {
            get
            {
                return maChuyenDe;
            }

            set
            {
                maChuyenDe = value;
            }
        }


       
        public string MaHocKy
        {
            get
            {
                return maHocKy;
            }

            set
            {
                maHocKy = value;
            }
        }

        public int NamHoc
        {
            get
            {
                return namHoc;
            }

            set
            {
                namHoc = value;
            }
        }
    }
}
