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
        /// <summary>
        /// Lấy danh sách chuyên đề mà giáo viên(Đang đang nhập) tham gia bằng mã giáo viên được lưu trong BUS Setting.
        /// </summary>
        /// <returns>Danh sách chuyên đề mà giáo viên tham gia</returns>
        public static List<DTO_ChuyenDeGiaoVienThamGia> LayDsChuyenDeGiaoVienThamGia()
        {
            string maGiaoVien = BUS.BUS_Users.LayMaNguoiDung().Trim();
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GIAOVIEN_THAMGIA_CHUYENDE WHERE MAGV = '{0}'", maGiaoVien);
            DAO_DataProvider.Connect();
            DataTable dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
            DAO_DataProvider.Disconnect();
            List<DTO_ChuyenDeGiaoVienThamGia> dsChuyenDe = null;
            if (dt.Rows.Count > 0)
            {
                dsChuyenDe = new List<DTO_ChuyenDeGiaoVienThamGia>();
                foreach (DataRow row in dt.Rows)
                {
                    DTO_ChuyenDeGiaoVienThamGia chuyenDe = new DTO_ChuyenDeGiaoVienThamGia()
                    {
                        MaChuyenDeGiao = row[0].ToString(),
                        MaGiaoVienThamGia = row[1].ToString().Trim(),
                        MaChuyenDe = row[2].ToString().Trim(),
                        NamHoc = int.Parse(row[3].ToString().Trim()),
                        MaHocKy = row[4].ToString().Trim()
                    };
                    dsChuyenDe.Add(chuyenDe);
                }
            }
            return dsChuyenDe;
        }

        /// <summary>
        /// Lấy 1 chuyên đề mà giáo viên tham dựa vào mã chuyên đề
        /// </summary>
        /// <param name="maChuyenDe"></param>
        /// <returns>Trả về null nếu không tim thấy ngược lại trả về DTO_ChuyenDeGiaoVienThamGia</returns>
        public static DTO_ChuyenDeGiaoVienThamGia LayChuyenDeGiaoVienThamGia(string maChuyenDe)
        {
            string maGiaoVien = BUS.BUS_Users.LayMaNguoiDung().Trim();
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GIAOVIEN_THAMGIA_CHUYENDE WHERE MAGV = '{0}' AND MACD = '{1}'", maGiaoVien, maChuyenDe);
            DAO_DataProvider.Connect();
            DataTable dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
            DAO_DataProvider.Disconnect();
            DTO_ChuyenDeGiaoVienThamGia chuyenDe = null;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    chuyenDe = new DTO_ChuyenDeGiaoVienThamGia()
                    {
                        MaChuyenDeGiao = row[0].ToString(),
                        MaGiaoVienThamGia = row[1].ToString().Trim(),
                        MaChuyenDe = row[2].ToString().Trim(),
                        NamHoc = int.Parse(row[3].ToString().Trim()),
                        MaHocKy = row[4].ToString().Trim()
                    };
                }
            }
            return chuyenDe;
        }
    }
}
