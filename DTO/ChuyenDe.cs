using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenDe
    {
        protected string maChuyenDe;
        protected string maNganh;
        private string tenChuyenDe;
        public ChuyenDe()
        {

        }

        public ChuyenDe(string maChuyenDe, string maNganh, string tenChuyenDe)
        {
            this.maChuyenDe = maChuyenDe;
            this.maNganh = maNganh;
            this.tenChuyenDe = tenChuyenDe;
        }

        public string MaChuyenDe
        {
            get { return maChuyenDe; }

            set { maChuyenDe = value; }
        }

        public string MaNganh
        {
            get { return maNganh; }

            set { maNganh = value; }
        }

        public string TenChuyenDe
        {
            get { return tenChuyenDe; }

            set { tenChuyenDe = value; }
        }
    }
}
