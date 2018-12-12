using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_ChuyenDeDangMo
    {

        public static List<DTO_ChuyenDeDangMo> LayDsChuyenDeGiaoVienThamGiaDangMo(List<DTO_ChuyenDeGiaoVienThamGia> dsChuyenDeGiaoVienThamGia)
        {
            List<DTO_ChuyenDeDangMo> dsChuyenDe = new List<DTO_ChuyenDeDangMo>();
            foreach (DTO_ChuyenDeGiaoVienThamGia i in dsChuyenDeGiaoVienThamGia)
            {
                StringBuilder query = new StringBuilder();
                query.AppendFormat("SELECT * FROM THONGTIN_CHUYENDE_MO WHERE MACD = '{0}' AND NAM = {1} AND MAHK = '{2}'", i.MaChuyenDe, i.NamHoc, i.MaHocKy);
                DAO.DataProvider.Connect();
                DataTable dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
                DAO.DataProvider.Disconnect();
                foreach (DataRow row in dt.Rows)
                {
                    DTO_ChuyenDeDangMo chuyenDeMo = new DTO_ChuyenDeDangMo();
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
            return dsChuyenDe;
        }
        public static List<DTO_ChuyenDeDangMo> LayDsTatCaChuyenDeDangMo()
        {
            List<DTO_ChuyenDeDangMo> dsChuyenDe = new List<DTO_ChuyenDeDangMo>();

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM THONGTIN_CHUYENDE_MO");
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO_ChuyenDeDangMo chuyenDeMo = new DTO_ChuyenDeDangMo();
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

        public static bool CapNhatThongTinChuyenDeDangMo(DTO_ChuyenDeDangMo chuyenDeMo)
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

            DAO.DataProvider.Connect();
            int result = DAO.DataProvider.ExecuteNonQuery(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            if (result <= 0)
            {
                return false;
            }
            return true;
        }
        public static List<DTO.DTO_ChuyenDeDangMo> LayDanhSachChuyenDeMoCoDieuKiem(string macd, string mahk, string nam)
        {
            List<DTO_ChuyenDeDangMo> dsChuyenDe = new List<DTO_ChuyenDeDangMo>();

            StringBuilder query = new StringBuilder();
            query.AppendFormat(layCauTruyVanConbobox(macd,mahk,nam).ToString());
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO_ChuyenDeDangMo chuyenDeMo = new DTO_ChuyenDeDangMo();
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
    }
}
