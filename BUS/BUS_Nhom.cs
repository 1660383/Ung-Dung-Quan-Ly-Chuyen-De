using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAO;
namespace BUS
{
    class BUS_Nhom
    {
        public static List<DTO_Nhom> LayDanhSachNhom()
        {
            List<DTO_Nhom> Nhoms = new List<DTO_Nhom>();
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM Nhom");
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO_Nhom Nhom = new DTO_Nhom((int)row[0], row[1].ToString(), (int)row[2], row[3].ToString(), row[4].ToString(), (int)row[5]);
                Nhoms.Add(Nhom);
            }
            return Nhoms;
        }
        public static DTO_Nhom LayTenNhom(string manhom)
        {
            DTO_Nhom nhom = null;
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from NHOM n where n.MANHOM = '{0}'", manhom);
            DataProvider.Connect();
            dt = DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                nhom = new DTO_Nhom((int)row[0], row[1].ToString(), (int)row[2], row[3].ToString(), row[4].ToString(), (int)row[5]);
            }
            return nhom;

        }
    }
}
