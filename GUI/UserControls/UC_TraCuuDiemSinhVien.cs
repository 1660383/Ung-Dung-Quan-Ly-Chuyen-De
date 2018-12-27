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
using BUS;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace GUI.UserControls
{
    public partial class UC_TraCuuDiemSinhVien : UserControl
    {
        // take data from namepase BUS
        private Word.Document oDoc = new Word.Document();
        private List<DTO_KetQua> listKetQua = BUS_KetQua.LayDanhSachKetQua();
        private int chuyende = -1;
        private int hocky = -1;
        private int namhoc = -1;
        public UC_TraCuuDiemSinhVien()
        {
            InitializeComponent();
            themDuLieuDenCombobox();
            layDuLieu();
        }
        private void themDuLieuDenCombobox()
        {
            foreach (DTO_KetQua kq in listKetQua)
            {
                cbMaCD.Items.Add(kq.MaCD);
                cbNamHoc.Items.Add(kq.Nam);
                cbHocKy.Items.Add(kq.MaHK);
            }
        }
        private void themDuLieuDenDataGridView(object sender)
        {
            dgvKetQua.DataSource = sender;
        }
        private void themDuLieuThongTinSinhVien(DTO_SinhVien sinhvien)
        {

            if (sinhvien != null)
            {
                themDuLieuDenDataGridView(BUS_KetQua.LayDanhSachKetQuaTheoMaSinhVien(sinhvien.MASV));
                DTO_Nganh nganh = BUS_Nganh.LayNganh(sinhvien.MaNganh);
                lblHoTenSV.Text = sinhvien.TENSV;
                lblMSSV.Text = sinhvien.MASV;
                lblNganh.Text = nganh.TenNganh;
                lblSoChiHoanthanh.Text = BUS_KetQua.SoMonDauCuaSinhVien(sinhvien.MASV) + "/" + nganh.SoChuyenDeToiDa;
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = null;
            layDuLieu();

        }
        private void layDuLieu()
        {
            AnThongTinSinhVien();
            themDuLieuDenDataGridView(BUS_KetQua.LayDanhSachKetQua(layDuLieuTextBox(txtMssv).ToString(), layDuLieuTextBox(txtTensv).ToString(), getOrNull(cbMaCD, chuyende).ToString(), getOrNull(cbHocKy, hocky).ToString(), getOrNull(cbNamHoc, namhoc).ToString()));
        }
        private void cbMaCD_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            chuyende = cbMaCD.SelectedIndex;
            layDuLieu();

        }
        private object getOrNull(object sender, int i)
        {
            if (i < 0) return "";
            else return ((ComboBox)sender).Items[i];
        }
        private object layDuLieuTextBox(MyTextBox tb)
        {
            if (tb.Text == tb.Hint) return "";
            return tb.Text;
        }

        private bool kiemTraDaChonTatCaCombobox()
        {
            if (chuyende != -1 && namhoc != -1 && hocky != -1) return true;
            return false;

        }
        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocky = cbHocKy.SelectedIndex;
            layDuLieu();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            namhoc = cbNamHoc.SelectedIndex;
            layDuLieu();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool AnThongTinSinhVien()
        {
            DTO_SinhVien sinhvien = BUS_SinhVien.LaySinhVien(txtMssv.Text);
            if (this.txtMssv.Text == txtMssv.Hint || sinhvien == null)
            {
                splitContainer1.Panel1Collapsed = true;
                groupBox3.Height = 93;
                btnInPhieu.Location = new Point(btnInPhieu.Location.X, 10);
                btnTimKiem.Location = new Point(btnInPhieu.Location.X, 56);
                return true;
            }
            splitContainer1.Panel1Collapsed = false;
            groupBox3.Height = 114;
            themDuLieuThongTinSinhVien(sinhvien);
            btnInPhieu.Location = new Point(btnInPhieu.Location.X, 25);
            btnTimKiem.Location = new Point(btnInPhieu.Location.X, 71);
            return false;
        }

        private void pcbLoad_Click(object sender, EventArgs e)
        {
            chuyende = -1;
            hocky = -1;
            namhoc = -1;
            cbHocKy.SelectedIndex = -1;
            cbMaCD.SelectedIndex = -1;
            cbNamHoc.SelectedIndex = -1;

        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dgvKetQua, sfd.FileName);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            try
            {
                oDoc.Close(Word.WdSaveFormat.wdFormatDocument, Word.WdOriginalFormat.wdWordDocument, 2);
            }
            catch (Exception){ }
            
            
            oDoc = new Word.Document();
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;

                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                
                
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 13;

                
                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                
                //table style 
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                
                ////header text
                //foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                //{
                //    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                //    headerRange.Text = "Phiếu Điêm Sinh Viên";
                //    headerRange.Font.Size = 16;
                //    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                //}


                //save the file

                
                oDoc.SaveAs2(filename);
                
                
                

                //NASSIM LOUCHANI
            }
        }




        private void button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dgvKetQua, sfd.FileName);
            }
        }
    }
}
