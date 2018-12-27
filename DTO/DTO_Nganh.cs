using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Nganh
    {
        private string manganh;
        private string tennganh;
        private int sochuyendetoida;

        public string MaNganh { get { return manganh; }set { manganh = value; } }
        public string TenNganh { get { return tennganh; }set { tennganh = value; } }
        public int SoChuyenDeToiDa { get { return sochuyendetoida; }set { sochuyendetoida = value; } }
        public DTO_Nganh(string manganh,string tennganh,int sochuyendetoida)
        {
            this.manganh = manganh;
            this.tennganh = tennganh;
            this.sochuyendetoida = sochuyendetoida;
        }
    }
}
