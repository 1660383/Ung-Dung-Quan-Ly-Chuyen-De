using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiaoVien
    {
        public static DTO.GiaoVien LayThongTin(string userID)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GIAOVIEN WHERE USERID = '{0}'", userID);
            DAO.DataProvider.Connect();

            DataTable tb = DAO.DataProvider.GetReader(CommandType.StoredProcedure, "LayThongTinGiaoVien",
               new System.Data.SqlClient.SqlParameter { ParameterName = "@userID", Value = userID, Direction = ParameterDirection.Input }
                );
                //DAO.DataProvider.Select(System.Data.CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            DTO.GiaoVien gv = null;
            if (tb != null)
            {

                foreach (DataRow row in tb.Rows)
                {
                    gv = new DTO.GiaoVien();
                    gv.MaGV = row[0].ToString().Trim();
                    gv.UserID = row[1].ToString().Trim();
                    gv.TenGV = row[2].ToString().Trim();
                    gv.NgaySinh = DateTime.Parse(row[3].ToString().Trim());
                    gv.GioiTinh = row[4].ToString().Trim();
                    gv.DienThoai = row[5].ToString().Trim();
                    break;
                }
            }
            return gv;
        }
    }
}
