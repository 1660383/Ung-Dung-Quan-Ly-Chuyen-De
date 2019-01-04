using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class ThongTinChuyenDeMo
    {

        public static List<DTO.ThongTinChuyenDeMo> LayDsChuyenDeGiaoVienThamGiaDangMo(List<DTO.GiaoVienThamGiaChuyenDe> dsChuyenDeGiaoVienThamGia)
        {
            List<DTO.ThongTinChuyenDeMo> dsChuyenDe = null;
            if (dsChuyenDeGiaoVienThamGia != null)
            {
                dsChuyenDe = new List<DTO.ThongTinChuyenDeMo>();
                foreach (DTO.GiaoVienThamGiaChuyenDe i in dsChuyenDeGiaoVienThamGia)
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendFormat("SELECT * FROM THONGTIN_CHUYENDE_MO WHERE MACD = '{0}' AND NAM = {1} AND MAHK = '{2}'", i.MaChuyenDe, i.NamHoc, i.MaHocKy);
                    DataProvider.Connect();
                    DataTable dt = DataProvider.Select(CommandType.Text, query.ToString());
                    DataProvider.Disconnect();
                    foreach (DataRow row in dt.Rows)
                    {
                        DTO.ThongTinChuyenDeMo chuyenDeMo = new DTO.ThongTinChuyenDeMo();
                        chuyenDeMo.MaChuyenDe = row[0].ToString().Trim();
                        chuyenDeMo.NamHoc = int.Parse(row[1].ToString().Trim());
                        chuyenDeMo.HocKy = row[2].ToString().Trim();
                        chuyenDeMo.MaGiaoVu = row[3].ToString().Trim();
                        chuyenDeMo.ThoiGianBD = DateTime.Parse(row[4].ToString().Trim());
                        chuyenDeMo.ThoiGianKT = DateTime.Parse(row[5].ToString().Trim());
                        chuyenDeMo.SlSinhVienToiDa = int.Parse(row[6].ToString().Trim());
                        chuyenDeMo.SlNhomToiDa = int.Parse(row[7].ToString().Trim());
                        chuyenDeMo.TrangThai = row[8].ToString();
                        dsChuyenDe.Add(chuyenDeMo);
                    }
                }
            }
            return dsChuyenDe;
        }

        public static DTO.ThongTinChuyenDeMo LayThongTin(string maCD, string hk, int namhoc)
        {
            DTO.ThongTinChuyenDeMo chuyenDeMo = null;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM THONGTIN_CHUYENDE_MO WHERE MACD = '{0}' AND NAM = {1} AND MAHK = '{2}'", maCD, namhoc, hk);
            DataProvider.Connect();
            DataTable dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                chuyenDeMo = new DTO.ThongTinChuyenDeMo();
                chuyenDeMo.MaChuyenDe = row[0].ToString().Trim();
                chuyenDeMo.NamHoc = int.Parse(row[1].ToString().Trim());
                chuyenDeMo.HocKy = row[2].ToString().Trim();
                chuyenDeMo.MaGiaoVu = row[3].ToString().Trim();
                chuyenDeMo.ThoiGianBD = DateTime.Parse(row[4].ToString().Trim());
                chuyenDeMo.ThoiGianKT = DateTime.Parse(row[5].ToString().Trim());
                chuyenDeMo.SlSinhVienToiDa = int.Parse(row[6].ToString().Trim());
                chuyenDeMo.SlNhomToiDa = int.Parse(row[7].ToString().Trim());
                chuyenDeMo.TrangThai = row[8].ToString();
                break;
            }
            return chuyenDeMo;
        }

        public static List<DTO.ThongTinChuyenDeMo> LayDsTatCaChuyenDeDangMo()
        {
            List<DTO.ThongTinChuyenDeMo> dsChuyenDe = new List<DTO.ThongTinChuyenDeMo>();

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM THONGTIN_CHUYENDE_MO");
            DataProvider.Connect();
            DataTable dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO.ThongTinChuyenDeMo chuyenDeMo = new DTO.ThongTinChuyenDeMo();
                chuyenDeMo.MaChuyenDe = row[0].ToString().Trim();
                chuyenDeMo.NamHoc = int.Parse(row[1].ToString().Trim());
                chuyenDeMo.HocKy = row[2].ToString().Trim();
                chuyenDeMo.MaGiaoVu = row[3].ToString().Trim();
                chuyenDeMo.ThoiGianBD = DateTime.Parse(row[4].ToString().Trim());
                chuyenDeMo.ThoiGianKT = DateTime.Parse(row[5].ToString().Trim());
                chuyenDeMo.SlSinhVienToiDa = int.Parse(row[6].ToString().Trim());
                chuyenDeMo.SlNhomToiDa = int.Parse(row[7].ToString().Trim());
                chuyenDeMo.TrangThai = row[8].ToString();
                dsChuyenDe.Add(chuyenDeMo);
            }
            return dsChuyenDe;
        }
        public static List<DTO.ThongTinChuyenDeMo> LayDsChuyenDeDangMo()
        {
            List<DTO.ThongTinChuyenDeMo> dsChuyenDe = new List<DTO.ThongTinChuyenDeMo>();
            {
                StringBuilder query = new StringBuilder();
                query.AppendFormat("SELECT * FROM THONGTIN_CHUYENDE_MO");
                DataProvider.Connect();
                DataTable dt = DataProvider.Select(CommandType.Text, query.ToString());
                DataProvider.Disconnect();
                foreach (DataRow row in dt.Rows)
                {
                    DTO.ThongTinChuyenDeMo chuyenDeMo = new DTO.ThongTinChuyenDeMo();
                    chuyenDeMo.MaChuyenDe = row[0].ToString().Trim();
                    chuyenDeMo.NamHoc = int.Parse(row[1].ToString().Trim());
                    chuyenDeMo.HocKy = row[2].ToString().Trim();
                    chuyenDeMo.MaGiaoVu = row[3].ToString().Trim();
                    chuyenDeMo.ThoiGianBD = DateTime.Parse(row[4].ToString().Trim());
                    chuyenDeMo.ThoiGianKT = DateTime.Parse(row[5].ToString().Trim());
                    chuyenDeMo.SlSinhVienToiDa = int.Parse(row[6].ToString().Trim());
                    chuyenDeMo.SlNhomToiDa = int.Parse(row[7].ToString().Trim());
                    chuyenDeMo.TrangThai = row[8].ToString().Trim();
                    dsChuyenDe.Add(chuyenDeMo);
                }
            }
            return dsChuyenDe;
        }
        public static bool CapNhatTrangThaiChuyenDeMo(DTO.ThongTinChuyenDeMo chuyenDeMo)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("UPDATE THONGTIN_CHUYENDE_MO SET TrangThai = N'{0}' where MACD = '{1}' and NAM = {2} and MAHK = '{3}'", chuyenDeMo.TrangThai, chuyenDeMo.MaChuyenDe, chuyenDeMo.NamHoc, chuyenDeMo.HocKy);
            DataProvider.Connect();
            int result = DataProvider.ExecuteNonQuery(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            if (result > 0) return true;
            return false;
        }
        public static bool CapNhatThongTinChuyenDeDangMo(DTO.ThongTinChuyenDeMo chuyenDeMo)
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

            DataProvider.Connect();
            int result = DataProvider.ExecuteNonQuery(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            if (result <= 0)
            {
                return false;
            }
            return true;
        }
        public static List<DTO.ThongTinChuyenDeMo> LayDanhSachChuyenDeMoCoDieuKiem(string macd, string mahk, string nam)
        {
            List<DTO.ThongTinChuyenDeMo> dsChuyenDe = new List<DTO.ThongTinChuyenDeMo>();

            StringBuilder query = new StringBuilder();
            query.AppendFormat(layCauTruyVanConbobox(macd, mahk, nam).ToString());
            DataProvider.Connect();
            DataTable dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO.ThongTinChuyenDeMo chuyenDeMo = new DTO.ThongTinChuyenDeMo();
                chuyenDeMo.MaChuyenDe = row[0].ToString().Trim();
                chuyenDeMo.NamHoc = int.Parse(row[1].ToString().Trim());
                chuyenDeMo.HocKy = row[2].ToString().Trim();
                chuyenDeMo.MaGiaoVu = row[3].ToString().Trim();
                chuyenDeMo.ThoiGianBD = DateTime.Parse(row[4].ToString().Trim());
                chuyenDeMo.ThoiGianKT = DateTime.Parse(row[5].ToString().Trim());
                chuyenDeMo.SlSinhVienToiDa = int.Parse(row[6].ToString().Trim());
                chuyenDeMo.SlNhomToiDa = int.Parse(row[7].ToString().Trim());
                chuyenDeMo.TrangThai = row[8].ToString();
                dsChuyenDe.Add(chuyenDeMo);
            }
            return dsChuyenDe;
        }
        private static StringBuilder layCauTruyVanConbobox(string macd, string mahk, string nam)
        {
            StringBuilder query = new StringBuilder();
            if (macd != "" && mahk != "" && nam != "")
            {
                query.AppendFormat("SELECT * from THONGTIN_CHUYENDE_MO kq  where kq.MACD = '{0}' and kq.NAM = {1} and kq.MAHK = '{2}' ", macd, nam, mahk);
            }
            else
            {
                if (macd != "" && mahk != "")
                {
                    query.AppendFormat("SELECT * from THONGTIN_CHUYENDE_MO kq where kq.MACD = '{0}' and kq.MAHK = '{1}' ", macd, mahk);
                }
                else if (macd != "" && nam != "")
                {
                    query.AppendFormat("SELECT * from THONGTIN_CHUYENDE_MO kq where kq.MACD = '{0}' and kq.NAM = {1} ", macd, nam);
                }
                else if (mahk != "" && nam != "")
                {
                    query.AppendFormat("SELECT * from THONGTIN_CHUYENDE_MO kq where kq.NAM = {0} and kq.MAHK = '{1}' ", nam, mahk);
                }
                else
                {
                    if (macd != "")
                    {
                        query.AppendFormat("SELECT * from THONGTIN_CHUYENDE_MO kq where kq.MACD = '{0}'", macd);
                    }
                    else if (mahk != "")
                    {
                        query.AppendFormat("SELECT * from THONGTIN_CHUYENDE_MO kq where kq.MAHK = '{0}'", mahk);
                    }
                    else if (nam != "")
                    {
                        query.AppendFormat("SELECT * from THONGTIN_CHUYENDE_MO kq where kq.NAM = {0}", nam);
                    }
                    else
                    {
                        query.AppendFormat("SELECT * from THONGTIN_CHUYENDE_MO kq where 1=1  ");
                    }
                }
            }
            return query;

        }

        /// new
        /// 

        public static bool MoChuyenDe(DTO.ThongTinChuyenDeMo chuyenDeMo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO THONGTIN_CHUYENDE_MO VALUES(@MaCD, @NamHoc, @HocKi, @MaGVu, @NgayBD, @NgayKT, @SLSVToiDa, @SLNhomToiDa, @TrangThai)");
            SqlParameter[] Params = new SqlParameter[] {
                new SqlParameter("@MaCD",chuyenDeMo.MaChuyenDe),
                new SqlParameter("@NamHoc",chuyenDeMo.NamHoc),
                new SqlParameter("@HocKi",chuyenDeMo.HocKy),
                new SqlParameter("@MaGVu",chuyenDeMo.MaGiaoVu),
                new SqlParameter("@NgayBD",chuyenDeMo.ThoiGianBD.ToShortDateString()),
                new SqlParameter("@NgayKT",chuyenDeMo.ThoiGianKT.ToShortDateString()),
                new SqlParameter("@SLSVToiDa",chuyenDeMo.SlSinhVienToiDa.ToString()),
                new SqlParameter("@SLNhomToiDa",chuyenDeMo.SlNhomToiDa.ToString()),
                new SqlParameter("@TrangThai",chuyenDeMo.TrangThai)
            };

            DAO.DataProvider.Connect();
            int result = DAO.DataProvider.ExecuteNonQuery(CommandType.Text, query.ToString(), Params);
            DAO.DataProvider.Disconnect();
            if (result > 0) return true;
            return false;
        }
    }
}
