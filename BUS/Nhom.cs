using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BUS
{
    class Nhom
    {
        public static List<DTO.Nhom> LayDanhSachNhom()
        {
            List<DTO.Nhom> Nhoms = new List<DTO.Nhom>();
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM Nhom");
            DAO.DataProvider.Connect();
            dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO.Nhom Nhom = new DTO.Nhom((int)row[0], row[1].ToString(), (int)row[2], row[3].ToString(), row[4].ToString(), (int)row[5]);
                Nhoms.Add(Nhom);
            }
            return Nhoms;
        }
        public static DTO.Nhom LayTenNhom(string manhom)
        {
            DTO.Nhom nhom = null;
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("select * from NHOM n where n.MANHOM = '{0}'", manhom);
            DAO.DataProvider.Connect();
            dt = DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                nhom = new DTO.Nhom((int)row[0], row[1].ToString(), (int)row[2], row[3].ToString(), row[4].ToString(), (int)row[5]);
            }
            return nhom;

        }
    }
}
