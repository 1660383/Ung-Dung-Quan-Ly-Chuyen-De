using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI.UserControls
{
    public partial class UC_TraCuuDiemSinhVien : UserControl
    {
        // take data from namepase BUS
        private List<KetQua> listKetQua = new List<KetQua>();
        private int chuyende = -1;
        private int hocky = -1;
        private int namhoc =-1;
        public UC_TraCuuDiemSinhVien()
        {
            InitializeComponent();
            FillDataToCombobox();
        }
        private void FillDataToCombobox()
        {
            foreach (KetQua kq in listKetQua)
            {
                cbMaCD.Items.Add(kq.MaCD);
                cbNamHoc.Items.Add(kq.Nam);
                cbHocKy.Items.Add(kq.MaHK);
            }
           

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chuyende + "/" + hocky + "/" + namhoc);
        }

        private void cbMaCD_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            chuyende = cbMaCD.SelectedIndex;
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocky = cbHocKy.SelectedIndex; 
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            namhoc= cbNamHoc.SelectedIndex;
        }
    }
}
