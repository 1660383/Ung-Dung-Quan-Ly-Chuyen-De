using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KetQua
    {
        private string ketquaid;
        private string macd;
        private int nam;
        private string mahk;
        private string mssv;
        private Decimal diem;
        public string KetQuaID { get { return ketquaid; } set { ketquaid = value; } }
        public string MaCD { get { return macd; } set { macd = value; } }
        public int Nam { get { return nam; } set { nam = value; } }
        public string MaHK { get { return mahk; } set { mahk = value; } }
        public string MSSV { get { return mssv; } set { mssv = value; } }
        public Decimal Diem { get { return diem; } set { diem = value; } }
        public KetQua(string ketquaid,string macd,int nam,string mahk,string mssv,Decimal diem)
        {
            this.ketquaid = ketquaid;
            this.macd = macd;
            this.nam = nam;
            this.mahk = mahk;
            this.mssv = mssv;
            this.diem = diem;
        }
    }
}
