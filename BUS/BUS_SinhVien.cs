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
    public class BUS_SinhVien
    {
        public static List<DTO_SinhVien> LayDanhSachSinhVien()
        {
            List<DTO_SinhVien> sinhviens = new List<DTO_SinhVien>();
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM SINHVIEN");
            DAO_DataProvider.Connect();
            dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
            DAO_DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO_SinhVien sinhvien = new DTO_SinhVien(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), (DateTime)row[6]);
                sinhviens.Add(sinhvien);
            }
            return sinhviens;
        }
        public static DTO_SinhVien LaySinhVien(string masv)
        {
            DTO_SinhVien sinhvien = null;
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from SINHVIEN sv where sv.MASV = '{0}'", masv);
            DAO_DataProvider.Connect();
            dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
            DAO_DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                sinhvien = new DTO_SinhVien(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), (DateTime)row[6]);
            }
            return sinhvien ;

        }
    }
}
