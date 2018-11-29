using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI.UserControls
{
    public partial class UC_GiaoChuyenDe : UserControl
    {
        public UC_GiaoChuyenDe()
        {
            InitializeComponent();
            Class1 c = new Class1();
            dataGridView1.DataSource = c.getEXP();
        }
    }
}
