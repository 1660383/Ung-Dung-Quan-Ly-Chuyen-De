using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyLopChuyenDe
    {
        private string macd;
        private int nam;
        private string mahk;
        private string masv;
        private int manhom;

        public string MACD
        {
            get { return macd; }
            set { macd = value; }
        }
        public int NAM
        {
            get { return nam; }
            set { nam = value; }
        }
        public string MAHK
        {
            get { return mahk; }
            set { mahk = value; }
        }
        public string MASV
        {
            get { return masv; }
            set { masv = value; }
        }
        public int MANHOM
        {
            get { return manhom; }
            set { manhom = value; }
        }
    }
}
