using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Nhom
    {
        private int manhom;
        private string macd;
        private int nam;
        private string mahk;
        private string tennhom;
        private int sothanhvientoida;

        public int MaNhom { get { return manhom; }set { manhom = value; } }
        public string MaCD { get { return macd; }set { macd = value; } }
        public int Nam { get { return nam; }set { nam = value; } }
        public string MaHK { get { return mahk; }set { mahk = value; } }
        public int SoThanhVienToiDa { get { return sothanhvientoida; }set { sothanhvientoida = value; } }

        public DTO_Nhom(int manhom,string macd,int nam,string mahk,string tennhom,int sothanhvientoida)
        {
            this.manhom = manhom;
            this.macd = macd;
            this.nam = nam;
            this.mahk = mahk;
            this.tennhom = tennhom;
            this.sothanhvientoida = sothanhvientoida;
        }
    }
}
