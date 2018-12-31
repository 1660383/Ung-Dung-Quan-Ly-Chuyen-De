using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class ChuyenDe
    {
        /// <summary>
        /// Lấy tất cả thông tin gốc của 1 chuyên đề
        /// </summary>
        /// <param name="maChuyenDe">Mã chuyên đề cần lấy thông tin</param>
        /// <returns>Trả về null nếu không tìm thấy. Ngươc lại trả về DTO_ChuyenDe</returns>
        public static DTO.ChuyenDe LayThongTinChuyenDe(string maChuyenDe)
        {

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM CHUYENDE WHERE MACD = N'{0}'", maChuyenDe);
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            DTO.ChuyenDe chuyenDe = null;
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    chuyenDe = new DTO.ChuyenDe();
                    chuyenDe.MaChuyenDe = row[0].ToString();
                    chuyenDe.MaNganh = row[1].ToString();
                    chuyenDe.TenChuyenDe = row[2].ToString();
                }
            }
            return chuyenDe;
        }

        public static List<DTO.ChuyenDe> LayDSChuyenDe()
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM CHUYENDE");
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            List<DTO.ChuyenDe> dsChuyenDe = null;
            if (dt != null)
            {
                dsChuyenDe = new List<DTO.ChuyenDe>();
                foreach (DataRow row in dt.Rows)
                {
                    DTO.ChuyenDe chuyenDe = new DTO.ChuyenDe();
                    chuyenDe.MaChuyenDe = row[0].ToString();
                    chuyenDe.MaNganh = row[1].ToString();
                    chuyenDe.TenChuyenDe = row[2].ToString();
                    dsChuyenDe.Add(chuyenDe);
                }
            }
            return dsChuyenDe;
        }

        public static bool Xoa(string maChuyenDe) {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("DELETE CHUYENDE WHERE MACD = N'{0}'", maChuyenDe);
            DAO.DataProvider.Connect();
            int result = DAO.DataProvider.ExecuteNonQuery(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public static bool Them(DTO.ChuyenDe chuyenDe)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("INSERT INTO CHUYENDE VALUES(N'{0}',N'{1}',N'{2}')", chuyenDe.MaChuyenDe, chuyenDe.MaNganh,chuyenDe.TenChuyenDe);
            DAO.DataProvider.Connect();
            int result = DAO.DataProvider.ExecuteNonQuery(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public static bool Sua(DTO.ChuyenDe chuyenDe)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("UPDATE CHUYENDE SET MANGANH = N'{0}', TENCD= N'{1}' WHERE MACD = N'{2}'", chuyenDe.MaNganh, chuyenDe.TenChuyenDe, chuyenDe.MaChuyenDe);
            DAO.DataProvider.Connect();
            int result = DAO.DataProvider.ExecuteNonQuery(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public static string TaoMaChuyenDe()
        {
            List<DTO.ChuyenDe> dsChuyenDe = LayDSChuyenDe();
            List<int> stt = new List<int>();
            foreach(DTO.ChuyenDe cd in dsChuyenDe)
            {
                string[] arr = cd.MaChuyenDe.Trim().Split(new char[] {'C','D'});
                stt.Add(int.Parse(arr[2]));
            }
            stt.Sort();
            int j= 1;
            for(int i = 0; i < stt.Count; i++)
            {
                if(stt[i] == j)
                {
                    j++;
                }else
                {
                    break;
                }
            }
            string maChuyenDeMoi = "CD000" + j;
            return maChuyenDeMoi;
        }
    }
}
