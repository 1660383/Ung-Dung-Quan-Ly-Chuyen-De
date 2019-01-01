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
    public class GiaoVienThamGiaChuyenDe
    {
        /// <summary>
        /// Lấy danh sách chuyên đề mà giáo viên(Đang đang nhập) tham gia bằng mã giáo viên được lưu trong BUS Setting.
        /// </summary>
        /// <returns>Danh sách chuyên đề mà giáo viên tham gia</returns>
        public static List<DTO.GiaoVienThamGiaChuyenDe> LayDsChuyenDeGiaoVienThamGia()
        {
            string maGiaoVien = BUS.Users.LayMaNguoiDung().Trim();
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GIAOVIEN_THAMGIA_CHUYENDE WHERE MAGV = '{0}'", maGiaoVien);
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            List<DTO.GiaoVienThamGiaChuyenDe> dsChuyenDe = null;
            if (dt.Rows.Count > 0)
            {
                dsChuyenDe = new List<DTO.GiaoVienThamGiaChuyenDe>();
                foreach (DataRow row in dt.Rows)
                {
                    DTO.GiaoVienThamGiaChuyenDe chuyenDe = new DTO.GiaoVienThamGiaChuyenDe()
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
        public static DTO.GiaoVienThamGiaChuyenDe LayChuyenDeGiaoVienThamGia(string maChuyenDe)
        {
            string maGiaoVien = BUS.Users.LayMaNguoiDung().Trim();
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GIAOVIEN_THAMGIA_CHUYENDE WHERE MAGV = '{0}' AND MACD = '{1}'", maGiaoVien, maChuyenDe);
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            DTO.GiaoVienThamGiaChuyenDe chuyenDe = null;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    chuyenDe = new DTO.GiaoVienThamGiaChuyenDe()
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
