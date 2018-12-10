using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_ChuyenDe
    {
        public static DTO_ChuyenDe LayThongTinChuyenDe(string maChuyenDe)
        {
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM CHUYENDE WHERE MACD = '{0}'", maChuyenDe);
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            DTO_ChuyenDe chuyenDe = null;
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    chuyenDe = new DTO_ChuyenDe();
                    chuyenDe.MaChuyenDe = row[0].ToString();
                    chuyenDe.MaNganh = row[1].ToString();
                    chuyenDe.TenChuyenDe = row[2].ToString();
                }
            }
            return chuyenDe;
        }

        
    }
}
