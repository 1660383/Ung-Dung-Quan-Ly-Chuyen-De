using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class Users
    {
        /// <summary>
        /// Định nghĩa loại người dùng.
        /// </summary>
        public enum LoaiTaiKhoan { GIAOVIEN, GIAOVU, SINHVIEN, ADMIN, WRONG };

        /// <summary>
        /// Kiểm tra đang nhập
        /// </summary>
        /// <param name="tenDangNhap">Tên đăng nhâp</param>
        /// <param name="matKhau">Mật khẩu</param>
        /// <returns>Trả về LoaiTaiKhoan tương ứng nếu đúng. Ngược lại trả về LoaiTaiKhoang.WRONG</returns>
        public static LoaiTaiKhoan DangNhap(string tenDangNhap, string matKhau)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM USERS WHERE USERNAME ='{0}' AND PASSWORD = '{1}'",
                tenDangNhap, matKhau);
            DAO.DataProvider.Connect();
            DataTable tb;
            //tb = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            tb = DAO.DataProvider.GetReader(CommandType.StoredProcedure, "DangNhap",
                new SqlParameter { ParameterName = "@tenDangNhap", Value = tenDangNhap, Direction = ParameterDirection.Input, SqlDbType = SqlDbType.Char, Size = 15 },
                new SqlParameter { ParameterName = "@matkhau", Value = matKhau, Direction = ParameterDirection.Input, SqlDbType = SqlDbType.Char, Size = 30 }
                );
            DAO.DataProvider.Disconnect();
            Console.WriteLine(tb.Rows[0][0].ToString());
            if (tb.Rows.Count > 0)
            {
                DTO.Users taiKhoan = new DTO.Users(tb.Rows[0][0].ToString().Trim(), tb.Rows[0][1].ToString().Trim(),
                    tb.Rows[0][2].ToString().Trim(), tb.Rows[0][3].ToString().Trim());
                switch (taiKhoan.IdPhanHe)
                {                   
                    case "PH0001":
                        LuuThongTinTaiKhoan(taiKhoan);
                        return LoaiTaiKhoan.GIAOVU;
                    case "PH0002":
                        LuuThongTinTaiKhoan(taiKhoan);
                        return LoaiTaiKhoan.GIAOVIEN;
                    case "PH0003":
                        LuuThongTinTaiKhoan(taiKhoan);
                        return LoaiTaiKhoan.SINHVIEN;
                    case "PH0004":
                        LuuThongTinTaiKhoan(taiKhoan);
                        return LoaiTaiKhoan.ADMIN;
                }

            }
            return LoaiTaiKhoan.WRONG;
        }

        /// <summary>
        /// Lưu thong tin tai khoảng người dùng hiện tại vào BUS Setting.
        /// </summary>
        /// <param name="taiKhoan">Tài khoảng cần lưu</param>
        private static void LuuThongTinTaiKhoan(DTO.Users taiKhoan)
        {
            BUS.Properties.Settings.Default.TaiKhoanHienTai = taiKhoan;
            BUS.Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Lấy tên người dùng thông qua tài khoảng đã lưu trong BUS Setting.
        /// </summary>
        /// <returns>Trả về Tên người dùng nến thành công. Ngược lại trả về giá trị mặc định là "Người dùng"</returns>
        public static object LayThongTinNguoiDung()
        {
            string idTaiKhoan = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            object nguoiDung = null;
            switch (BUS.Properties.Settings.Default.TaiKhoanHienTai.IdPhanHe)
            {
                case "PH0001":
                    nguoiDung = BUS.GiaoVu.LayThongTin(idTaiKhoan);
                    break;
                case "PH0002":
                    nguoiDung = BUS.GiaoVien.LayThongTin(idTaiKhoan);
                    break;
                case "PH0003":
                    nguoiDung = BUS.SinhVien.LayThongTin(idTaiKhoan);
                    break;
            }
            return nguoiDung;
        }

        /// <summary>
        /// Lấy tên người dùng thông qua tài khoảng đã lưu trong BUS Setting.
        /// </summary>
        /// <returns>Trả về Mã của người dùng hiện tại.</returns>
       
    }
}
