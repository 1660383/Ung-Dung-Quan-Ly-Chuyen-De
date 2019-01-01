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
using System.Drawing;
using System.Drawing.Imaging;

namespace BUS
{
    public class NoiDungLopChuyenDe
    {
        /// <summary>
        /// Lấy danh sách nội dung chuyên đề mà giao viên tham gia.
        /// </summary>
        /// <param name="chuyende">Chuyên đề giáo viên tham gia.</param>
        /// <returns>Trả về null nếu không có dữ liệu. Ngược lại trả về List<DTO_NoiDungLopChuyenDe>.</returns>
        public static List<DTO.NoiDungLopChuyenDe> LayDSNoiDungChuyenDe(DTO.GiaoVienThamGiaChuyenDe chuyende)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM NOIDUNG_LOP_CHUYENDE WHERE MACD = '{0}' AND MAGV = '{1}' AND MAHK= '{2}' AND NAM = {3}",
                chuyende.MaChuyenDe, chuyende.MaGiaoVienThamGia, chuyende.MaHocKy, chuyende.NamHoc);
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.Select(System.Data.CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            List<DTO.NoiDungLopChuyenDe> dsNDlopChuyenDe = null;
            if (dt.Rows.Count > 0)
            {
                dsNDlopChuyenDe = new List<DTO.NoiDungLopChuyenDe>();
                foreach (DataRow row in dt.Rows)
                {
                    DTO.NoiDungLopChuyenDe ndLopChuyenDe = new DTO.NoiDungLopChuyenDe()
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
                        ThoiGianKetThuc = DateTime.Parse(row[10].ToString().Trim()),
                        Icon = ObjectToByteArray(row[11])

                    };
                    dsNDlopChuyenDe.Add(ndLopChuyenDe);
                }
            }
            return dsNDlopChuyenDe;
        }
        public static List<DTO.NoiDungLopChuyenDe> LayTatCaNoiDungChuyenDe()
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM NOIDUNG_LOP_CHUYENDE");
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.Select(System.Data.CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            List<DTO.NoiDungLopChuyenDe> dsNDlopChuyenDe = null;
            if (dt.Rows.Count > 0)
            {
                dsNDlopChuyenDe = new List<DTO.NoiDungLopChuyenDe>();
                foreach (DataRow row in dt.Rows)
                {
                    DTO.NoiDungLopChuyenDe ndLopChuyenDe = new DTO.NoiDungLopChuyenDe()
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
                        ThoiGianKetThuc = DateTime.Parse(row[10].ToString().Trim()),
                        Icon = ObjectToByteArray(row[11])

                    };
                    dsNDlopChuyenDe.Add(ndLopChuyenDe);
                }
            }
            return dsNDlopChuyenDe;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static byte[] ImageToBytes(Image icon)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                icon.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static Image BytesToImage(byte[] bytes)
        {

            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Tạo Khóa chính của NOIDUNG_LOP_CHUYENDE tự động.
        /// </summary>
        /// <returns>Trả về giá trị khóa chính kế tiếp cần thêm vào bảng.</returns>
        public static string TaoMaNoiDungLopChuyenDeTuDong()
        {
            List<DTO.NoiDungLopChuyenDe> dsNDChuyenDe = LayTatCaNoiDungChuyenDe();
            List<int> stt = new List<int>();
            if (dsNDChuyenDe != null)
            {
                foreach (DTO.NoiDungLopChuyenDe nd in dsNDChuyenDe)
                {
                    string[] arr = nd.MaNoiDung.Trim().Split(new char[] { 'N', 'D' });
                    stt.Add(int.Parse(arr[2]));
                }
                stt.Sort();
            }
            int j = 1;
            for (int i = 0; i < stt.Count; i++)
            {
                if (stt[i] == j)
                {
                    j++;
                }
                else
                {
                    break;
                }
            }
            string maNDMoi = "ND000" + j;
            return maNDMoi;
        }

        /// <summary>
        /// Lưu nội dung chuyên đề mới vào DataBase.
        /// </summary>
        /// <param name="ndLopChuyenDe">Nội dụng cần lưu.</param>
        /// <returns>Trả về true nếu lưu thành công. Ngược lại trả về false.</returns>
        public static bool LuuTapTinVaoDataBase(DTO.NoiDungLopChuyenDe ndLopChuyenDe)
        {
            String query = "INSERT INTO [dbo].[NOIDUNG_LOP_CHUYENDE] ([MAND],[GIA_MACD],[MAGV],[MACD],[NAM],[MAHK],[TENND],[NOIDUNGCD],[THELOAI],[THOIGIANBT],[THOIGIANKT],[ICON]) VALUES(@MAND,@GIA_MACD,@MAGV,@MACD,@NAM,@MAHK,@TENND,@NOIDUNGCD,@THELOAI,@THOIGIANBT,@THOIGIANKT,@ICON)";

            SqlParameter[] Params = new SqlParameter[12];
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
            Params[11] = new SqlParameter("@ICON", ndLopChuyenDe.Icon);

            DAO.DataProvider.Connect();
            int kq = DAO.DataProvider.ExecuteNonQuery(System.Data.CommandType.Text, query, Params);
            DAO.DataProvider.Disconnect();

            if (kq > 0)
                return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNoiDung"></param>
        /// <returns></returns>
        public static byte[] LayIconNoiDung(string maNoiDung)
        {
            DAO.DataProvider.Connect();
            string query = "SELECT ICON FROM NOIDUNG_LOP_CHUYENDE WHERE MAND = @MAND";
            byte[] bytes = (byte[])DAO.DataProvider.ExecuteScala(query.ToString(), new SqlParameter("@MAND", maNoiDung));
            DAO.DataProvider.Disconnect();
            return bytes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNoiDung"></param>
        /// <returns></returns>
        public static byte[] LayNoiDungChuyenDe(string maNoiDung)
        {
            DAO.DataProvider.Connect();
            string query = "SELECT NOIDUNGCD FROM NOIDUNG_LOP_CHUYENDE WHERE MAND = @MAND";
            byte[] bytes = (byte[])DAO.DataProvider.ExecuteScala(query.ToString(), new SqlParameter("@MAND", maNoiDung));
            DAO.DataProvider.Disconnect();
            return bytes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNoiDung"></param>
        /// <returns></returns>
        public static bool XoaNoiDungChuyenDe(string maNoiDung)
        {
            string query = "DELETE NOIDUNG_LOP_CHUYENDE WHERE MAND = @MAND";
            DAO.DataProvider.Connect();
            int kq = DataProvider.ExecuteNonQuery(CommandType.Text, query, new SqlParameter("@MAND", maNoiDung));
            DAO.DataProvider.Disconnect();
            if (kq <= 0)
            {
                return false;
            }
            return true;
        }

        public static bool CapNhapDungChuyenDe(DTO.NoiDungLopChuyenDe noiDungLopChuyenDe)
        {
            string query = "UPDATE NOIDUNG_LOP_CHUYENDE SET TENND = @TENND, THOIGIANBT = @THOIGIANBT, THOIGIANKT = @THOIGIANKT WHERE MAND = @MAND";
            DAO.DataProvider.Connect();
            int kq = DataProvider.ExecuteNonQuery(CommandType.Text, query, new SqlParameter[] {
                new SqlParameter("@TENND",noiDungLopChuyenDe.TenNoiDung),
                new SqlParameter("@THOIGIANBT",noiDungLopChuyenDe.ThoiGianBatDau.ToString()),
                new SqlParameter("THOIGIANKT",noiDungLopChuyenDe.ThoiGianKetThuc.ToString()),
                new SqlParameter("@MAND",noiDungLopChuyenDe.MaNoiDung)
            });
            DAO.DataProvider.Disconnect();
            if (kq <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
