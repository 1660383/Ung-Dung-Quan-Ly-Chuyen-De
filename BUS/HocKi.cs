using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class HocKi
    {
        public static bool TonTai(DTO.HocKi hocki)
        {
            DataTable dt = null;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM HOCKY WHERE MAHK = '{0}' AND NAM = {1}", hocki.MaHK, hocki.Nam);
            DAO.DataProvider.Connect();
            dt = DAO.DataProvider.Select(System.Data.CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            if (dt.Rows.Count > 0) return true;
            return false;
        }

        public static bool ThemHocKy(DTO.HocKi hocKi)
        {
            DAO.DataProvider.Connect();
            int restul = DAO.DataProvider.ExecuteNonQuery(CommandType.Text,
                "INSERT INTO HOCKY VALUES(@NamHoc,@HocKy)",
                new System.Data.SqlClient.SqlParameter[] {
                    new System.Data.SqlClient.SqlParameter("@NamHoc",hocKi.Nam.ToString()),
                    new System.Data.SqlClient.SqlParameter("@HocKy",hocKi.MaHK)
                });            
            DAO.DataProvider.Disconnect();
            if (restul > 0) return true;
            return false;
        }
    }
}
