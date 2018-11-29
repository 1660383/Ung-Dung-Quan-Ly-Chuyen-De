using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class Class1
    {
        public Class1()
        {

        }

        public DataTable getEXP()
        {
            DataProvider.Connect();
            DataTable dt = DataProvider.Select(CommandType.Text, "SELECT * FROM CHUYENDE");
            DataProvider.Disconnect();
            return dt;
        } 
    }
}
