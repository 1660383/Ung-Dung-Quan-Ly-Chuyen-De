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
using System.IO;

namespace GUI.UserControls
{
    public partial class UC_GiaoChuyenDe : UserControl
    {
        public UC_GiaoChuyenDe()
        {
            InitializeComponent();
            //BUS_GiaoChuyenDe giaoChuyenDe = new BUS_GiaoChuyenDe();
            //dataGridView1.DataSource = giaoChuyenDe.
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();            
            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtDuongDan.Text = ofd.FileName;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            //BUS_NoiDungChuyenDe.Save(File.ReadAllBytes(txtDuongDan.Text));
        }
        int i = 0;
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //label1.Text = "Move: "+i++;
        }

        private void splitContainer1_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
            label1.Text = "Move: " + i++;
        }
    }
}
