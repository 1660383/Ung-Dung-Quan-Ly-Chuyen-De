using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_NoiDungChuyenDe
    {
        public static void LayDSNoiDungChuyenDe()
        {
            DataProvider.Connect();

            DataProvider.Disconnect();
        }
    }
}
