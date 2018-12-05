using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_NoiDungChuyenDe
    {
        private string maNoiDung;
        private string maGiaoVien;
        private string maChuyenDe;
        private int nam;
        private string maHocKy;
        private string tenNoiDung;
        private DateTime thoiGianBatDau;
        private DateTime thoiGianKetThuc;
        private byte[] noiDungChuyenDe;

        public DTO_NoiDungChuyenDe()
        {

        }
        public string MaNoiDung
        {
            get
            {
                return maNoiDung;
            }

            set
            {
                maNoiDung = value;
            }
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

        public int Nam
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

        public string TenNoiDung
        {
            get
            {
                return tenNoiDung;
            }

            set
            {
                tenNoiDung = value;
            }
        }

        public DateTime ThoiGianBatDau
        {
            get
            {
                return thoiGianBatDau;
            }

            set
            {
                thoiGianBatDau = value;
            }
        }

        public DateTime ThoiGianKetThuc
        {
            get
            {
                return thoiGianKetThuc;
            }

            set
            {
                thoiGianKetThuc = value;
            }
        }

        public byte[] NoiDungChuyenDe
        {
            get
            {
                return noiDungChuyenDe;
            }

            set
            {
                noiDungChuyenDe = value;
            }
        }
    }
}
