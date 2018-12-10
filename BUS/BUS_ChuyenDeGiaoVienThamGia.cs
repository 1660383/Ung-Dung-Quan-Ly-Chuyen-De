using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChuyenDeGiaoVienThamGia
    {

        public static List<DTO_ChuyenDeGiaoVienThamGia> LayDsChuyenDeGiaoVienThamGia()
        {
            DataTable dt;
            string maGiaoVien = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT gv.MAGV, MACD, NAM, MAHK FROM GIAOVIEN_THAMGIA_CHUYENDE  gvtgcd, GIAOVIEN gv WHERE gv.USERID = '{0}' AND gvtgcd.MAGV = gv.MAGV", maGiaoVien);
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            List<DTO_ChuyenDeGiaoVienThamGia> dsChuyenDe = new List<DTO_ChuyenDeGiaoVienThamGia>();
            foreach (DataRow row in dt.Rows)
            {
                DTO_ChuyenDeGiaoVienThamGia chuyenDe = new DTO_ChuyenDeGiaoVienThamGia(row[0].ToString(), row[1].ToString().Trim(), int.Parse(row[2].ToString().Trim()), row[3].ToString().Trim());
                dsChuyenDe.Add(chuyenDe);
            }
            return dsChuyenDe;
        }
    }
}
