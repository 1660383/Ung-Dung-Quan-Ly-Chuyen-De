using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BUS
{
    public class BUS_NoiDungLopChuyenDe
    {
        /// <summary>
        /// Lấy danh sách nội dung chuyên đề mà giao viên tham gia.
        /// </summary>
        /// <param name="chuyende">Chuyên đề giáo viên tham gia.</param>
        /// <returns>Trả về null nếu không có dữ liệu. Ngược lại trả về List<DTO_NoiDungLopChuyenDe>.</returns>
        public static List<DTO_NoiDungLopChuyenDe> LayDSNoiDungChuyenDe(DTO.DTO_ChuyenDeGiaoVienThamGia chuyende)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM NOIDUNG_LOP_CHUYENDE WHERE MACD = '{0}' AND MAGV = '{1}' AND MAHK= '{2}' AND NAM = {3}",
                chuyende.MaChuyenDe,chuyende.MaGiaoVienThamGia, chuyende.MaHocKy,chuyende.NamHoc);
            DAO.DAO_DataProvider.Connect();
            DataTable dt =DAO.DAO_DataProvider.Select(System.Data.CommandType.Text, query.ToString());
            DAO.DAO_DataProvider.Disconnect();
            List<DTO.DTO_NoiDungLopChuyenDe> dsNDlopChuyenDe = null;
            if (dt.Rows.Count > 0)
            {
                dsNDlopChuyenDe = new List<DTO_NoiDungLopChuyenDe>();
                foreach (DataRow row in dt.Rows)
                {
                    DTO.DTO_NoiDungLopChuyenDe ndLopChuyenDe = new DTO_NoiDungLopChuyenDe()
                    {
                        MaNoiDung = row[0].ToString().Trim(),
                        MaNoiDungChuyenDeGiao = row[1].ToString().Trim(),
                        MaGiaoVien = row[2].ToString().Trim(),
                        MaChuyenDe = row[3].ToString().Trim(),
                        Nam = int.Parse(row[4].ToString().Trim()),
                        MaHocKy = row[5].ToString().Trim(),
                        TenNoiDung = row[6].ToString().Trim(),
                        NoiDungChuyenDe = ObjectToByteArray(row[7]),
                        TheLoai = row[8].ToString().Trim(),
                        ThoiGianBatDau = DateTime.Parse(row[9].ToString().Trim()),
                        ThoiGianKetThuc = DateTime.Parse(row[10].ToString().Trim())
                    };
                    dsNDlopChuyenDe.Add(ndLopChuyenDe);
                }
            }
            return dsNDlopChuyenDe;
        }
        private static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
        /// <summary>
        /// Tạo Khóa chính của NOIDUNG_LOP_CHUYENDE tự động.
        /// </summary>
        /// <returns>Trả về giá trị khóa chính kế tiếp cần thêm vào bảng.</returns>
        public static string TaoMaNoiDungLopChuyenDeTuDong()
        {
            DAO.DAO_DataProvider.Connect();
            SqlParameter param = new SqlParameter("@id", System.Data.SqlDbType.NVarChar, 10)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            DAO.DAO_DataProvider.ExecuteNonQuery(System.Data.CommandType.StoredProcedure,"usp_TaoMaNoiDungLopChuyenDe",param);
            DAO.DAO_DataProvider.Disconnect();
            return param.Value.ToString().Trim();
        }

        /// <summary>
        /// Lưu nội dung chuyên đề mới vào DataBase.
        /// </summary>
        /// <param name="ndLopChuyenDe">Nội dụng cần lưu.</param>
        /// <returns>Trả về true nếu lưu thành công. Ngược lại trả về false.</returns>
        public static bool LuuTapTinVaoDataBase(DTO_NoiDungLopChuyenDe ndLopChuyenDe)
        {
            String query = "INSERT INTO [dbo].[NOIDUNG_LOP_CHUYENDE] ([MAND],[GIA_MACD],[MAGV],[MACD],[NAM],[MAHK],[TENND],[NOIDUNGCD],[THELOAI],[THOIGIANBT],[THOIGIANKT]) VALUES(@MAND,@GIA_MACD,@MAGV,@MACD,@NAM,@MAHK,@TENND,@NOIDUNGCD,@THELOAI,@THOIGIANBT,@THOIGIANKT)";

            SqlParameter[] Params = new SqlParameter[11];
            Params[0] = new SqlParameter("@MAND", ndLopChuyenDe.MaNoiDung);
            Params[1] = new SqlParameter("@GIA_MACD", ndLopChuyenDe.MaNoiDungChuyenDeGiao);
            Params[2] = new SqlParameter("@MAGV", ndLopChuyenDe.MaGiaoVien);
            Params[3] = new SqlParameter("@MACD", ndLopChuyenDe.MaChuyenDe);
            Params[4] = new SqlParameter("@NAM", ndLopChuyenDe.Nam);
            Params[5] = new SqlParameter("@MAHK", ndLopChuyenDe.MaHocKy);
            Params[6] = new SqlParameter("@TENND", ndLopChuyenDe.TenNoiDung);
            Params[7] = new SqlParameter("@NOIDUNGCD", System.Data.SqlDbType.VarBinary);
            Params[7].Value = ndLopChuyenDe.NoiDungChuyenDe;
            Params[8] = new SqlParameter("@THELOAI", ndLopChuyenDe.TheLoai);
            Params[9] = new SqlParameter("@THOIGIANBT", ndLopChuyenDe.ThoiGianBatDau);
            Params[10] = new SqlParameter("@THOIGIANKT", ndLopChuyenDe.ThoiGianKetThuc);

            DAO.DAO_DataProvider.Connect();
            int kq = DAO.DAO_DataProvider.ExecuteNonQuery(System.Data.CommandType.Text, query, Params);
            DAO.DAO_DataProvider.Disconnect();
            if (kq > 0)
                return true;
            return false;
        }
    }
}
