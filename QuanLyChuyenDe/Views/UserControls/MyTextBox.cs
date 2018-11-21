using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenDe.Views.UserControls
{
    class MyTextBox : TextBox
    {
        private string hint = "";
        private Color textColor =  SystemColors.WindowText;
        private Color hintColor = Color.Gray;
        public MyTextBox()
        {           
           
            this.GotFocus += MyTextBox_GotFocus;
            this.LostFocus += MyTextBox_LostFocus;
        }

        private void MyTextBox_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.Text))
            {
                this.ForeColor = this.hintColor;
                this.Text = this.hint;
            }
        }

        private void MyTextBox_GotFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.Text) || this.Text.Equals(this.hint))
            {
                this.Clear();
                this.ForeColor = this.textColor;
            }
        }
        public string Hint
        {
            get
            {
                return hint;
            }

            set
            {
                hint = value;
                this.ForeColor = this.hintColor;
                this.Text = this.hint;
            }
        }

        public Color TextColor
        {
            get
            {
                return textColor;
            }

            set
            {
                textColor = value;
            }
        }

        public Color HintColor
        {
            get
            {
                return hintColor;
            }

            set
            {
                hintColor = value;
            }
        }
    }
}
