using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_ThongTinChuyenDeMo
    {
        /// <summary>
        /// Lấy danh sách thông tin chuyên đề mở ứng với danh sách chuyên đề giáo viên tham gia.
        /// </summary>
        /// <param name="dsChuyenDeGiaoVienThamGia">Danh sách chuyên đề giáo viên tham gia.</param>
        /// <returns>Trả về null nếu không có dữ liệu. Ngượi lại trả về danh sách thông tin chuyên đề mở.</returns>
        public static List<DTO_ThongTinChuyenDeMo> LayDsThongTinChuyenDeMoGiaoVienThamGia(List<DTO_ChuyenDeGiaoVienThamGia> dsChuyenDeGiaoVienThamGia)
        {
            List<DTO_ThongTinChuyenDeMo> dsChuyenDe = new List<DTO_ThongTinChuyenDeMo>();
            foreach (DTO_ChuyenDeGiaoVienThamGia i in dsChuyenDeGiaoVienThamGia)
            {
                StringBuilder query = new StringBuilder();
                query.AppendFormat("SELECT * FROM THONGTIN_CHUYENDE_MO WHERE MACD = '{0}' AND NAM = {1} AND MAHK = '{2}'", i.MaChuyenDe, i.NamHoc, i.MaHocKy);
                DAO.DAO_DataProvider.Connect();
                DataTable dt = DAO.DAO_DataProvider.Select(CommandType.Text, query.ToString());
                DAO.DAO_DataProvider.Disconnect();
                foreach (DataRow row in dt.Rows)
                {
                    DTO_ThongTinChuyenDeMo chuyenDeMo = new DTO_ThongTinChuyenDeMo();
                    chuyenDeMo.MaChuyenDe = row[0].ToString().Trim();
                    chuyenDeMo.NamHoc = int.Parse(row[1].ToString().Trim());
                    chuyenDeMo.HocKy = row[2].ToString().Trim();
                    chuyenDeMo.MaGiaoVu = row[3].ToString().Trim();
                    chuyenDeMo.ThoiGianBD = DateTime.Parse(row[4].ToString().Trim());
                    chuyenDeMo.ThoiGianKT = DateTime.Parse(row[5].ToString().Trim());
                    chuyenDeMo.SlSinhVienToiDa = int.Parse(row[6].ToString().Trim());
                    chuyenDeMo.SlNhomToiDa = int.Parse(row[7].ToString().Trim());
                    dsChuyenDe.Add(chuyenDeMo);
                }
            }
            if (dsChuyenDe.Count == 0)
                return null;
            return dsChuyenDe;
        }

        /// <summary>
        /// Cập nhật thôn tin chuyên đề mở.
        /// </summary>
        /// <param name="chuyenDeMo">Chuyên đề mở cần câp nhật.</param>
        /// <returns>Trả về true nếu thành công. Ngược lại trả về false.</returns>
        public static bool CapNhatThongTinChuyenDeMo(DTO_ThongTinChuyenDeMo chuyenDeMo)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("UPDATE THONGTIN_CHUYENDE_MO SET SOLUONGSINHVIENTOIDA = {0}, SOLUONGNHOMTOIDA = {1}, THOIGIANBD = '{2}', THOIGIANKT = '{3}' WHERE MACD = '{4}' AND NAM = {5} AND MAHK = '{6}'",
                chuyenDeMo.SlSinhVienToiDa,
                chuyenDeMo.SlNhomToiDa,
                chuyenDeMo.ThoiGianBD.ToShortDateString(),
                chuyenDeMo.ThoiGianKT.ToShortDateString(),
                chuyenDeMo.MaChuyenDe,
                chuyenDeMo.NamHoc,
                chuyenDeMo.HocKy);

            DAO.DAO_DataProvider.Connect();
            int result = DAO.DAO_DataProvider.ExecuteNonQuery(CommandType.Text,query.ToString());
            DAO.DAO_DataProvider.Disconnect();
            if (result <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
