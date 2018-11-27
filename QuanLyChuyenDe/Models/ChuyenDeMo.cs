using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenDe.Models
{
    class ChuyenDeMo: ChuyenDe
    {
        private int maHoc;
        private string maHocKi;
        private string maGiaoVu;
        private DateTime batDau = DateTimePicker.MinimumDateTime;
        private DateTime ketThuc = DateTimePicker.MinimumDateTime;
        private int slSinhVienToiDa = 0;
        private int slNhomToiDa = 0;

        public ChuyenDeMo()
        {

        }

        public int MaHoc
        {
            get
            {
                return maHoc;
            }

            set
            {
                maHoc = value;
            }
        }

        public string MaHocKi
        {
            get
            {
                return maHocKi;
            }

            set
            {
                maHocKi = value;
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

        public DateTime BatDau
        {
            get
            {
                return batDau;
            }

            set
            {
                batDau = value;
            }
        }

        public DateTime KetThuc
        {
            get
            {
                return ketThuc;
            }

            set
            {
                ketThuc = value;
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
