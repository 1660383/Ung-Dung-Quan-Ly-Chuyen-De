using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_Nganh
    {
        public static List<DTO_Nganh> LayDanhSachNganh()
        {
            List<DTO_Nganh> nganhs = new List<DTO_Nganh>();
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM Nganh");
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO_Nganh nganh = new DTO_Nganh(row[0].ToString(), row[1].ToString(), (int)row[2]);
                nganhs.Add(nganh);
            }
            return nganhs;
        }
        public static DTO_Nganh LayNganh(string manganh)
        {
            DTO_Nganh nganh = null;
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from NGANH n where n.MANGANH = '{0}'", manganh);
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach(DataRow row in dt.Rows)
            {
                nganh = new DTO_Nganh(row[0].ToString(), row[1].ToString(), (int)row[2]);
            }
            return nganh;
           
        }
    }
}
