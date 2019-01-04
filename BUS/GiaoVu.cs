using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class GiaoVu
    {
        public static DTO.GiaoVu LayThongTin(string userID)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GIAOVU WHERE USERID = '{0}'", userID);
            DAO.DataProvider.Connect();
            DataTable tb = DAO.DataProvider.GetReader(CommandType.StoredProcedure, "LayThongTinGiaoVu",
                new System.Data.SqlClient.SqlParameter { ParameterName = "@userID", Value = userID, Direction = ParameterDirection.Input });
                //DAO.DataProvider.Select(System.Data.CommandType.Text,query.ToString()  );
            DAO.DataProvider.Disconnect();
            DTO.GiaoVu gvu = null;
            if(tb!= null)
            { 

                foreach (DataRow row in tb.Rows)
                {
                    gvu = new DTO.GiaoVu();
                    gvu.MaGiaoVu = row[0].ToString().Trim();
                    gvu.UserID = row[1].ToString().Trim();
                    gvu.TenGiaoVu = row[2].ToString().Trim();
                    gvu.NgaySinh = DateTime.Parse(row[3].ToString().Trim());
                    gvu.GioiTinh = row[4].ToString().Trim();
                    break;
                }
            }
            return gvu;
        }
    }
}
