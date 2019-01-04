using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocKi
    {
        public HocKi(string maHK, int nam)
        {
            Nam = nam;
            MaHK = maHK;
        }

        public int Nam { get; set; }

        public string MaHK { get; set; }

    }

}
