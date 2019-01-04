namespace GUI.UserControls
{
    partial class UC_CapNhatTrangThaiChuyenDe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CapNhatTrangThaiChuyenDe));
            this.rbLat = new System.Windows.Forms.RadioButton();
            this.rbDanhSach = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongNho = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rbBieuTuongLon = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvChuyenDeMo = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new GUI.UserControls.MyTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTenChuyenDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbVoHieuHoa = new System.Windows.Forms.RadioButton();
            this.lblHocKi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.rbMoChuyenDe = new System.Windows.Forms.RadioButton();
            this.lbMaChuyenDe = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMoChuyenDe = new System.Windows.Forms.Button();
            this.pcbLoad = new System.Windows.Forms.PictureBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // rbLat
            // 
            this.rbLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbLat.AutoSize = true;
            this.rbLat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLat.Location = new System.Drawing.Point(423, 5);
            this.rbLat.Name = "rbLat";
            this.rbLat.Size = new System.Drawing.Size(42, 20);
            this.rbLat.TabIndex = 2;
            this.rbLat.TabStop = true;
            this.rbLat.Text = "lát";
            this.rbLat.UseVisualStyleBackColor = true;
            this.rbLat.CheckedChanged += new System.EventHandler(this.rbLat_CheckedChanged_1);
            // 
            // rbDanhSach
            // 
            this.rbDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbDanhSach.AutoSize = true;
            this.rbDanhSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDanhSach.Location = new System.Drawing.Point(303, 5);
            this.rbDanhSach.Name = "rbDanhSach";
            this.rbDanhSach.Size = new System.Drawing.Size(91, 20);
            this.rbDanhSach.TabIndex = 3;
            this.rbDanhSach.TabStop = true;
            this.rbDanhSach.Text = "danh sách";
            this.rbDanhSach.UseVisualStyleBackColor = true;
            this.rbDanhSach.CheckedChanged += new System.EventHandler(this.rbDanhSach_CheckedChanged_1);
            // 
            // rbBieuTuongNho
            // 
            this.rbBieuTuongNho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbBieuTuongNho.AutoSize = true;
            this.rbBieuTuongNho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBieuTuongNho.Location = new System.Drawing.Point(155, 5);
            this.rbBieuTuongNho.Name = "rbBieuTuongNho";
            this.rbBieuTuongNho.Size = new System.Drawing.Size(124, 20);
            this.rbBieuTuongNho.TabIndex = 4;
            this.rbBieuTuongNho.TabStop = true;
            this.rbBieuTuongNho.Text = "biểu tượng nhỏ";
            this.rbBieuTuongNho.UseVisualStyleBackColor = true;
            this.rbBieuTuongNho.CheckedChanged += new System.EventHandler(this.rbBieuTuongNho_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rbBieuTuongLon
            // 
            this.rbBieuTuongLon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbBieuTuongLon.AutoSize = true;
            this.rbBieuTuongLon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBieuTuongLon.Location = new System.Drawing.Point(17, 5);
            this.rbBieuTuongLon.Name = "rbBieuTuongLon";
            this.rbBieuTuongLon.Size = new System.Drawing.Size(121, 20);
            this.rbBieuTuongLon.TabIndex = 5;
            this.rbBieuTuongLon.TabStop = true;
            this.rbBieuTuongLon.Text = "biểu tượng lớn";
            this.rbBieuTuongLon.UseVisualStyleBackColor = true;
            this.rbBieuTuongLon.CheckedChanged += new System.EventHandler(this.rbBieuTuongLon_CheckedChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLat);
            this.panel1.Controls.Add(this.rbDanhSach);
            this.panel1.Controls.Add(this.rbBieuTuongNho);
            this.panel1.Controls.Add(this.rbBieuTuongLon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 31);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Học kì:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cbHocKy.Location = new System.Drawing.Point(99, 34);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(113, 24);
            this.cbHocKy.TabIndex = 0;
            this.cbHocKy.SelectedValueChanged += new System.EventHandler(this.cbHocKy_SelectedValueChanged);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbNamHoc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(311, 34);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(95, 24);
            this.cbNamHoc.TabIndex = 0;
            this.cbNamHoc.SelectedValueChanged += new System.EventHandler(this.cbNamHoc_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên CD";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Năm học:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_ChuyenDe.png");
            this.imageList1.Images.SetKeyName(1, "ic_book_mo.png");
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lvChuyenDeMo);
            this.panel3.Controls.Add(this.btnMoChuyenDe);
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 370);
            this.panel3.TabIndex = 3;
            // 
            // lvChuyenDeMo
            // 
            this.lvChuyenDeMo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvChuyenDeMo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lvChuyenDeMo.LargeImageList = this.imageList1;
            this.lvChuyenDeMo.Location = new System.Drawing.Point(0, 51);
            this.lvChuyenDeMo.Name = "lvChuyenDeMo";
            this.lvChuyenDeMo.Size = new System.Drawing.Size(489, 316);
            this.lvChuyenDeMo.SmallImageList = this.imageList1;
            this.lvChuyenDeMo.TabIndex = 0;
            this.lvChuyenDeMo.UseCompatibleStateImageBehavior = false;
            this.lvChuyenDeMo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvChuyenDeMo_ItemSelectionChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(888, 499);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pcbLoad);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.cbHocKy);
            this.panel2.Controls.Add(this.cbNamHoc);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 74);
            this.panel2.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Hint = "";
            this.txtTimKiem.HintColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(99, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(307, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTenChuyenDe);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblNamHoc);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rbVoHieuHoa);
            this.groupBox2.Controls.Add(this.lblHocKi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.rbMoChuyenDe);
            this.groupBox2.Controls.Add(this.lbMaChuyenDe);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.MinimumSize = new System.Drawing.Size(393, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 499);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // lblTenChuyenDe
            // 
            this.lblTenChuyenDe.AllowDrop = true;
            this.lblTenChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenChuyenDe.AutoEllipsis = true;
            this.lblTenChuyenDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuyenDe.Location = new System.Drawing.Point(135, 49);
            this.lblTenChuyenDe.Name = "lblTenChuyenDe";
            this.lblTenChuyenDe.Size = new System.Drawing.Size(237, 59);
            this.lblTenChuyenDe.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Chuyên đề:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblNamHoc.Location = new System.Drawing.Point(137, 150);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(0, 16);
            this.lblNamHoc.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm học: ";
            // 
            // rbVoHieuHoa
            // 
            this.rbVoHieuHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbVoHieuHoa.AutoSize = true;
            this.rbVoHieuHoa.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbVoHieuHoa.Location = new System.Drawing.Point(139, 190);
            this.rbVoHieuHoa.Name = "rbVoHieuHoa";
            this.rbVoHieuHoa.Size = new System.Drawing.Size(91, 20);
            this.rbVoHieuHoa.TabIndex = 18;
            this.rbVoHieuHoa.TabStop = true;
            this.rbVoHieuHoa.Text = "vô hiệu hóa";
            this.rbVoHieuHoa.UseVisualStyleBackColor = true;
            // 
            // lblHocKi
            // 
            this.lblHocKi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHocKi.AutoSize = true;
            this.lblHocKi.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblHocKi.Location = new System.Drawing.Point(136, 130);
            this.lblHocKi.Name = "lblHocKi";
            this.lblHocKi.Size = new System.Drawing.Size(0, 16);
            this.lblHocKi.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã Chuyên Đề: ";
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(76, 130);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 16);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "Học Kì: ";
            // 
            // rbMoChuyenDe
            // 
            this.rbMoChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbMoChuyenDe.AutoSize = true;
            this.rbMoChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbMoChuyenDe.Location = new System.Drawing.Point(139, 170);
            this.rbMoChuyenDe.Name = "rbMoChuyenDe";
            this.rbMoChuyenDe.Size = new System.Drawing.Size(46, 20);
            this.rbMoChuyenDe.TabIndex = 17;
            this.rbMoChuyenDe.TabStop = true;
            this.rbMoChuyenDe.Text = "mở";
            this.rbMoChuyenDe.UseVisualStyleBackColor = true;
            // 
            // lbMaChuyenDe
            // 
            this.lbMaChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaChuyenDe.AutoSize = true;
            this.lbMaChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbMaChuyenDe.Location = new System.Drawing.Point(136, 110);
            this.lbMaChuyenDe.Name = "lbMaChuyenDe";
            this.lbMaChuyenDe.Size = new System.Drawing.Size(0, 16);
            this.lbMaChuyenDe.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Trạng thái: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 520);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRẠNG THÁI CHUYÊN ĐỀ";
            // 
            // btnMoChuyenDe
            // 
            this.btnMoChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoChuyenDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoChuyenDe.Image = ((System.Drawing.Image)(resources.GetObject("btnMoChuyenDe.Image")));
            this.btnMoChuyenDe.Location = new System.Drawing.Point(286, 5);
            this.btnMoChuyenDe.Name = "btnMoChuyenDe";
            this.btnMoChuyenDe.Size = new System.Drawing.Size(197, 40);
            this.btnMoChuyenDe.TabIndex = 24;
            this.btnMoChuyenDe.Text = "Mở Chuyên Đề Mới";
            this.btnMoChuyenDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoChuyenDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoChuyenDe.UseVisualStyleBackColor = true;
            this.btnMoChuyenDe.Click += new System.EventHandler(this.btnMoChuyenDe_Click);
            // 
            // pcbLoad
            // 
            this.pcbLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbLoad.BackgroundImage = global::GUI.Properties.Resources.icons8_synchronize_32;
            this.pcbLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLoad.Location = new System.Drawing.Point(422, 3);
            this.pcbLoad.Name = "pcbLoad";
            this.pcbLoad.Size = new System.Drawing.Size(34, 26);
            this.pcbLoad.TabIndex = 24;
            this.pcbLoad.TabStop = false;
            this.pcbLoad.Click += new System.EventHandler(this.pcbLoad_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = global::GUI.Properties.Resources.ic_update1;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(139, 223);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 40);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // UC_CapNhatTrangThaiChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_CapNhatTrangThaiChuyenDe";
            this.Size = new System.Drawing.Size(894, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbLat;
        private System.Windows.Forms.RadioButton rbDanhSach;
        private System.Windows.Forms.RadioButton rbBieuTuongNho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton rbBieuTuongLon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private MyTextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvChuyenDeMo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenChuyenDe;
        private System.Windows.Forms.Label lbMaChuyenDe;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblHocKi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.RadioButton rbVoHieuHoa;
        private System.Windows.Forms.RadioButton rbMoChuyenDe;
        private System.Windows.Forms.Button btnMoChuyenDe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbLoad;
    }
}
