using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenDe.Models
{
    class ChuyenDe
    {
        private string maChuyenDe;
        private string maNganh;
        private string tenChuyenDe;
        public ChuyenDe()
        {

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

        public string MaNganh
        {
            get
            {
                return maNganh;
            }

            set
            {
                maNganh = value;
            }
        }

        public string TenChuyenDe
        {
            get
            {
                return tenChuyenDe;
            }

            set
            {
                tenChuyenDe = value;
            }
        }
    }
}
