using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BUS
{
    public class SinhVien
    {
        public static List<DTO.SinhVien> LayDanhSachSinhVien()
        {
            List<DTO.SinhVien> sinhviens = new List<DTO.SinhVien>();
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM SINHVIEN");
            DAO.DataProvider.Connect();
            dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO.SinhVien sinhvien = new DTO.SinhVien(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), (DateTime)row[6]);
                sinhviens.Add(sinhvien);
            }
            return sinhviens;
        }
        public static DTO.SinhVien LayThongTin(string masv)
        {
            DTO.SinhVien sinhvien = null;
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from SINHVIEN sv where sv.MASV = '{0}'", masv);
            DAO.DataProvider.Connect();
            dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                sinhvien = new DTO.SinhVien(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), (DateTime)row[6]);
            }
            return sinhvien ;

        }
    }
}
