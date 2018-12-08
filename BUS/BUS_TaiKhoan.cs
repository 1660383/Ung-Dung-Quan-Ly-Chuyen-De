using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        public enum LoaiTaiKhoan {GIAOVIEN,GIAOVU,SINHVIEN,ADMIN,WRONG};
        public static LoaiTaiKhoan  DangNhap(string tenDangNhap, string matKhau)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM USERS WHERE USERNAME ='{0}' AND PASSWORD = '{1}'",
                tenDangNhap, matKhau);
            DAO.DataProvider.Connect();
            DataTable tb = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();

            if(tb.Rows.Count > 0)
            {
                switch (tb.Rows[0][1].ToString().Trim())
                {
                    case "PH00001":
                        return LoaiTaiKhoan.GIAOVU;
                    case "PH00002":
                        return LoaiTaiKhoan.GIAOVIEN;
                    case "PH00003":
                        return LoaiTaiKhoan.SINHVIEN;
                      
                    case "PH00004":
                        return LoaiTaiKhoan.ADMIN;                      
                }
                
            }
            return LoaiTaiKhoan.WRONG;
        }
    }
}
