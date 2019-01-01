using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

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
            DataTable tb = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            if (tb.Rows.Count > 0)
            {
                DTO.Users taiKhoan = new DTO.Users(tb.Rows[0][0].ToString().Trim(), tb.Rows[0][1].ToString().Trim(),
                    tb.Rows[0][2].ToString().Trim(), tb.Rows[0][3].ToString().Trim());
                switch (taiKhoan.IdPhanHe)
                {
                    case "PH00001":
                        LuuThongTinTaiKhoan(taiKhoan);
                        return LoaiTaiKhoan.GIAOVU;
                    case "PH00002":
                        LuuThongTinTaiKhoan(taiKhoan);
                        return LoaiTaiKhoan.GIAOVIEN;
                    case "PH00003":
                        LuuThongTinTaiKhoan(taiKhoan);
                        return LoaiTaiKhoan.SINHVIEN;
                    case "PH00004":
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
        public static string LayTenNguoiDung()
        {
            string idTaiKhoan = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            switch (BUS.Properties.Settings.Default.TaiKhoanHienTai.IdPhanHe)
            {
                case "PH00001":
                    query.AppendFormat("SELECT {0} FROM {1} WHERE USERID = '{2}'", "TENGIAOVU", "GIAOVU", idTaiKhoan);
                    break;
                case "PH00002":
                    query.AppendFormat("SELECT {0} FROM {1} WHERE USERID = '{2}'", "TENGV", "GIAOVIEN", idTaiKhoan);
                    break;
                case "PH00003":
                    query.AppendFormat("SELECT {0} FROM {1} WHERE USERID = '{2}'", "TENSV", "SINHVIEN", idTaiKhoan);
                    break;
                case "PH00004":
                    // query.AppendFormat("select {0} FROM {1} WHERE USERID = '{2}'", "TENGIAOVU", idTaiKhoan);
                    break;
            }

            DAO.DataProvider.Connect();
            DataTable tb = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();

            if (tb.Rows.Count > 0)
            {
                return tb.Rows[0][0].ToString();
            }
            return "Người dùng";
        }

        /// <summary>
        /// Lấy tên người dùng thông qua tài khoảng đã lưu trong BUS Setting.
        /// </summary>
        /// <returns>Trả về Mã của người dùng hiện tại.</returns>
        public static string LayMaNguoiDung()
        {
            string idTaiKhoan = BUS.Properties.Settings.Default.TaiKhoanHienTai.IdTaiKhoan;
            StringBuilder query = new StringBuilder();
            switch (BUS.Properties.Settings.Default.TaiKhoanHienTai.IdPhanHe)
            {
                case "PH00001":
                    query.AppendFormat("SELECT MAGIAOVU FROM GIAOVU WHERE USERID = '{0}'", idTaiKhoan);
                    break;
                case "PH00002":
                    query.AppendFormat("SELECT MAGV FROM GIAOVIEN WHERE USERID = '{0}'", idTaiKhoan);
                    break;
                case "PH00003":
                    query.AppendFormat("SELECT MASV FROM SINHVIEN WHERE USERID = '{0}'", idTaiKhoan);
                    break;
                case "PH00004":
                    // query.AppendFormat("select {0} FROM {1} WHERE USERID = '{2}'", "TENGIAOVU", idTaiKhoan);
                    break;
            }

            DAO.DataProvider.Connect();
            DataTable tb = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            return tb.Rows[0][0].ToString();
        }
    }
}
