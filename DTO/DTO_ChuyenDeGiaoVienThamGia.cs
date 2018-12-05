using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_ChuyenDeGiaoVienThamGia
    {
        string maGiaoVien;
        string maChuyenDe;
        string nam;
        string maHocKy;

        public DTO_ChuyenDeGiaoVienThamGia(string maGiaoVien, string maChuyenDe, string maHocKy, string nam)
        {
            this.maGiaoVien = maGiaoVien;
            this.maChuyenDe = maChuyenDe;
            this.nam = nam;
            this.maHocKy = maHocKy;
        }

        public string MaGiaoVien
        {
            get
            {
                return maGiaoVien;
            }

            set
            {
                maGiaoVien = value;
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

        public string Nam
        {
            get
            {
                return nam;
            }

            set
            {
                nam = value;
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
    }
}
