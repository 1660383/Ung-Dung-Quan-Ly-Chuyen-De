using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_ChuyenDe
    {
        /// <summary>
        /// Lấy tất cả thông tin gốc của 1 chuyên đề
        /// </summary>
        /// <param name="maChuyenDe">Mã chuyên đề cần lấy thông tin</param>
        /// <returns>Trả về null nếu không tìm thấy. Ngươc lại trả về DTO_ChuyenDe</returns>
        public static DTO_ChuyenDe LayThongTinChuyenDe(string maChuyenDe)
        {
          
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM CHUYENDE WHERE MACD = '{0}'", maChuyenDe);
            DAO.DAO_DataProvider.Connect();
            DataTable dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DAO_DataProvider.Disconnect();
            DTO.DTO_ChuyenDe chuyenDe = null;
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    chuyenDe = new DTO_ChuyenDe();
                    chuyenDe.MaChuyenDe = row[0].ToString();
                    chuyenDe.MaNganh = row[1].ToString();
                    chuyenDe.TenChuyenDe = row[2].ToString();
                }
            }
            return chuyenDe;
        }

        
    }
}
