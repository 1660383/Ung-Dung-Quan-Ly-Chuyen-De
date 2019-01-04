using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BUS
{
    public class Nganh
    {
        public static List<DTO.Nganh> LayDanhSachNganh()
        {
            List<DTO.Nganh> nganhs = new List<DTO.Nganh>();
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM Nganh");
            DAO.DataProvider.Connect();
            dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO.Nganh nganh = new DTO.Nganh(row[0].ToString().Trim(), row[1].ToString().Trim(), (int)row[2]);
                nganhs.Add(nganh);
            }
            return nganhs;
        }
        public static DTO.Nganh LayNganh(string manganh)
        {
            DTO.Nganh nganh = null;
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from NGANH n where n.MANGANH = '{0}'", manganh);
            DAO.DataProvider.Connect();
            dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            foreach(DataRow row in dt.Rows)
            {
                nganh = new DTO.Nganh(row[0].ToString().Trim(), row[1].ToString().Trim(), (int)row[2]);
            }
            return nganh;
           
        }
    }
}
