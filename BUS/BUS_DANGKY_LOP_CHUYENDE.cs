using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_DANGKY_LOP_CHUYENDE
    {
        public static List<DTO.DTO_DANGKY_LOP_CHUYENDE> LayDanhSachDangKyLopChuyenDe()
        {
            List<DTO.DTO_DANGKY_LOP_CHUYENDE> ldklcd = new List<DTO.DTO_DANGKY_LOP_CHUYENDE>();
            DataTable dt;

            string maGiaoVien = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from DANGKY_LOP_CHUYENDE");
            DAO_DataProvider.Connect();
            dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
            DAO_DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO.DTO_DANGKY_LOP_CHUYENDE dklcd = new DTO.DTO_DANGKY_LOP_CHUYENDE();
                dklcd.MACD = row[0].ToString();
                dklcd.NAM = int.Parse(row[1].ToString());
                dklcd.MAHK = row[2].ToString();
                dklcd.MASV = row[3].ToString();
                dklcd.MANHOM = int.Parse(row[4].ToString());
                ldklcd.Add(dklcd);
            }
            return ldklcd;
        }
        public static DTO.DTO_DANGKY_LOP_CHUYENDE LayDangKyLopChuyenDe(DTO.DTO_ChuyenDeDangMo cdm)
        {
            DTO.DTO_DANGKY_LOP_CHUYENDE dklcd = null;
            DataTable dt;

            string maGiaoVien = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from DANGKY_LOP_CHUYENDE cd where cd.MACD = '{0}' and cd.NAM ={1} and MAHK = '{2}'",cdm.MaChuyenDe,cdm.NamHoc,cdm.HocKy);
            DAO_DataProvider.Connect();
            dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
            DAO_DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                dklcd = new DTO.DTO_DANGKY_LOP_CHUYENDE();
                dklcd.MACD = row[0].ToString();
                dklcd.NAM = int.Parse(row[1].ToString());
                dklcd.MAHK = row[2].ToString();
                dklcd.MASV = row[3].ToString();
                dklcd.MANHOM = int.Parse(row[4].ToString());
                
            }
            return dklcd;
        }
        public static int SoLuongNguoiDangKy(DTO.DTO_ChuyenDeDangMo cdm)
        {
            DataTable dt;
            string maGiaoVien = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from DANGKY_LOP_CHUYENDE cd where cd.MACD = '{0}' and cd.NAM ={1} and MAHK = '{2}'", cdm.MaChuyenDe, cdm.NamHoc, cdm.HocKy);
            DAO_DataProvider.Connect();
            dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
            DAO_DataProvider.Disconnect();
            return dt.Rows.Count;
        }
        
    }
}
