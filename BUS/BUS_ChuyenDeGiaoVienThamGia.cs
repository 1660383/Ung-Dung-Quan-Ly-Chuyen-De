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
    class BUS_ChuyenDeGiaoVienThamGia
    {
        public static List<DTO_ChuyenDe> LayDsChuyenDeGiaoVienThamGia(string maGiaoVien)
        {
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GIAOVIEN_THAMGIA_CHUYENDE WHERE MAGVTG = '{0}'", maGiaoVien);
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            List<DTO_ChuyenDe> dsChuyenDe = new List<DTO_ChuyenDe>();
            foreach(DataRow row in dt.Rows)
            {
                DTO_ChuyenDe chuyenDe =  BUS_ChuyenDe.LayThongTinChuyenDe(row[2].ToString());
                dsChuyenDe.Add(chuyenDe);
            }
            return dsChuyenDe;
        }
    }
}
