using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace BUS
{
    public class DangKyLopChuyenDe
    {
        public static List<DTO.DangKyLopChuyenDe> LayDanhSachDangKyLopChuyenDe()
        {
            List<DTO.DangKyLopChuyenDe> ldklcd = new List<DTO.DangKyLopChuyenDe>();
            DataTable dt;

            string maGiaoVien = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from DANGKY_LOP_CHUYENDE");
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO.DangKyLopChuyenDe dklcd = new DTO.DangKyLopChuyenDe();
                dklcd.MACD = row[0].ToString();
                dklcd.NAM = int.Parse(row[1].ToString());
                dklcd.MAHK = row[2].ToString();
                dklcd.MASV = row[3].ToString();
                dklcd.MANHOM = int.Parse(row[4].ToString());
                ldklcd.Add(dklcd);
            }
            return ldklcd;
        }
        public static DTO.DangKyLopChuyenDe LayDangKyLopChuyenDe(DTO.ThongTinChuyenDeMo cdm)
        {
            DTO.DangKyLopChuyenDe dklcd = null;
            DataTable dt;

            string maGiaoVien = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from DANGKY_LOP_CHUYENDE cd where cd.MACD = '{0}' and cd.NAM ={1} and MAHK = '{2}'",cdm.MaChuyenDe,cdm.NamHoc,cdm.HocKy);
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                dklcd = new DTO.DangKyLopChuyenDe();
                dklcd.MACD = row[0].ToString();
                dklcd.NAM = int.Parse(row[1].ToString());
                dklcd.MAHK = row[2].ToString();
                dklcd.MASV = row[3].ToString();
                dklcd.MANHOM = int.Parse(row[4].ToString());
                
            }
            return dklcd;
        }
        public static int SoLuongNguoiDangKy(DTO.ThongTinChuyenDeMo cdm)
        {
            DataTable dt;
            string maGiaoVien = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from DANGKY_LOP_CHUYENDE cd where cd.MACD = '{0}' and cd.NAM ={1} and MAHK = '{2}'", cdm.MaChuyenDe, cdm.NamHoc, cdm.HocKy);
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            return dt.Rows.Count;
        }
        
    }
}
