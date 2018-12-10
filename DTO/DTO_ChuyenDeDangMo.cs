using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuyenDeDangMo
    {
        private string maChuyenDe;
        private int namHoc;
        private string hocKy;
        private string maGiaoVu;
        private DateTime thoiGianBD;
        private DateTime thoiGianKT;
        private int slSinhVienToiDa;
        private int slNhomToiDa;

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

        public string HocKy
        {
            get
            {
                return hocKy;
            }

            set
            {
                hocKy = value;
            }
        }

        public string MaGiaoVu
        {
            get
            {
                return maGiaoVu;
            }

            set
            {
                maGiaoVu = value;
            }
        }

        public DateTime ThoiGianBD
        {
            get
            {
                return thoiGianBD;
            }

            set
            {
                thoiGianBD = value;
            }
        }

        public DateTime ThoiGianKT
        {
            get
            {
                return thoiGianKT;
            }

            set
            {
                thoiGianKT = value;
            }
        }

        public int SlSinhVienToiDa
        {
            get
            {
                return slSinhVienToiDa;
            }

            set
            {
                slSinhVienToiDa = value;
            }
        }

        public int SlNhomToiDa
        {
            get
            {
                return slNhomToiDa;
            }

            set
            {
                slNhomToiDa = value;
            }
        }
    }
}
