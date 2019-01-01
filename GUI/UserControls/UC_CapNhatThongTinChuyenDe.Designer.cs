namespace GUI.UserControls
{
    partial class UC_CapNhatThongTinChuyenDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CapNhatThongTinChuyenDe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvChuyenDeMo = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new GUI.UserControls.MyTextBox();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLat = new System.Windows.Forms.RadioButton();
            this.rbDanhSach = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongNho = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongLon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTenChuyenDe = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.nudSLSinhVienToiDa = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMaChuyenDe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSLNhomToiDa = new System.Windows.Forms.NumericUpDown();
            this.lbl = new System.Windows.Forms.Label();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLSinhVienToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLNhomToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CẬP NHẬT THÔNG TIN CHUYÊN ĐỀ";
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lvChuyenDeMo);
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 399);
            this.panel3.TabIndex = 3;
            // 
            // lvChuyenDeMo
            // 
            this.lvChuyenDeMo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvChuyenDeMo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lvChuyenDeMo.LargeImageList = this.imageList1;
            this.lvChuyenDeMo.Location = new System.Drawing.Point(0, 0);
            this.lvChuyenDeMo.Name = "lvChuyenDeMo";
            this.lvChuyenDeMo.Size = new System.Drawing.Size(491, 399);
            this.lvChuyenDeMo.SmallImageList = this.imageList1;
            this.lvChuyenDeMo.TabIndex = 0;
            this.lvChuyenDeMo.UseCompatibleStateImageBehavior = false;
            this.lvChuyenDeMo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvChuyenDeMo_ItemSelectionChanged);
            this.lvChuyenDeMo.MouseLeave += new System.EventHandler(this.lvChuyenDeMo_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_ChuyenDe.png");
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.cbHocKi);
            this.panel2.Controls.Add(this.cbNamHoc);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 36);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Học kì:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Năm học:";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Hint = "Nhập tên Chuyên đề";
            this.txtSearch.HintColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(16, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập tên Chuyên đề";
            this.txtSearch.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbHocKi
            // 
            this.cbHocKi.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1",
            "HK2"});
            this.cbHocKi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbHocKi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbHocKi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cbHocKi.Location = new System.Drawing.Point(231, 7);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(54, 24);
            this.cbHocKi.TabIndex = 0;
            this.cbHocKi.SelectedIndexChanged += new System.EventHandler(this.cbHocKi_SelectedIndexChanged);
            this.cbHocKi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbHocKi_KeyDown);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbNamHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbNamHoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014"});
            this.cbNamHoc.Location = new System.Drawing.Point(368, 7);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(75, 24);
            this.cbNamHoc.TabIndex = 0;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
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
            // rbLat
            // 
            this.rbLat.AutoSize = true;
            this.rbLat.Location = new System.Drawing.Point(404, 3);
            this.rbLat.Name = "rbLat";
            this.rbLat.Size = new System.Drawing.Size(42, 20);
            this.rbLat.TabIndex = 2;
            this.rbLat.TabStop = true;
            this.rbLat.Text = "lát";
            this.rbLat.UseVisualStyleBackColor = true;
            this.rbLat.CheckedChanged += new System.EventHandler(this.rbLat_CheckedChanged);
            // 
            // rbDanhSach
            // 
            this.rbDanhSach.AutoSize = true;
            this.rbDanhSach.Location = new System.Drawing.Point(307, 3);
            this.rbDanhSach.Name = "rbDanhSach";
            this.rbDanhSach.Size = new System.Drawing.Size(91, 20);
            this.rbDanhSach.TabIndex = 3;
            this.rbDanhSach.TabStop = true;
            this.rbDanhSach.Text = "danh sách";
            this.rbDanhSach.UseVisualStyleBackColor = true;
            this.rbDanhSach.CheckedChanged += new System.EventHandler(this.rbDanhSach_CheckedChanged);
            // 
            // rbBieuTuongNho
            // 
            this.rbBieuTuongNho.AutoSize = true;
            this.rbBieuTuongNho.Location = new System.Drawing.Point(177, 3);
            this.rbBieuTuongNho.Name = "rbBieuTuongNho";
            this.rbBieuTuongNho.Size = new System.Drawing.Size(124, 20);
            this.rbBieuTuongNho.TabIndex = 4;
            this.rbBieuTuongNho.TabStop = true;
            this.rbBieuTuongNho.Text = "biểu tượng nhỏ";
            this.rbBieuTuongNho.UseVisualStyleBackColor = true;
            this.rbBieuTuongNho.CheckedChanged += new System.EventHandler(this.rbBieuTuongNho_CheckedChanged);
            // 
            // rbBieuTuongLon
            // 
            this.rbBieuTuongLon.AutoSize = true;
            this.rbBieuTuongLon.Location = new System.Drawing.Point(50, 3);
            this.rbBieuTuongLon.Name = "rbBieuTuongLon";
            this.rbBieuTuongLon.Size = new System.Drawing.Size(121, 20);
            this.rbBieuTuongLon.TabIndex = 5;
            this.rbBieuTuongLon.TabStop = true;
            this.rbBieuTuongLon.Text = "biểu tượng lớn";
            this.rbBieuTuongLon.UseVisualStyleBackColor = true;
            this.rbBieuTuongLon.CheckedChanged += new System.EventHandler(this.rbBieuTuongLon_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTenChuyenDe);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.nudSLSinhVienToiDa);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblMaChuyenDe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudSLNhomToiDa);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.dtpKetThuc);
            this.groupBox2.Controls.Add(this.dtpBatDau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
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
            this.lblTenChuyenDe.Location = new System.Drawing.Point(139, 39);
            this.lblTenChuyenDe.Name = "lblTenChuyenDe";
            this.lblTenChuyenDe.Size = new System.Drawing.Size(229, 47);
            this.lblTenChuyenDe.TabIndex = 16;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = global::GUI.Properties.Resources.ic_update1;
            this.btnCapNhat.Location = new System.Drawing.Point(143, 245);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 41);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // nudSLSinhVienToiDa
            // 
            this.nudSLSinhVienToiDa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSLSinhVienToiDa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSLSinhVienToiDa.Location = new System.Drawing.Point(143, 121);
            this.nudSLSinhVienToiDa.Name = "nudSLSinhVienToiDa";
            this.nudSLSinhVienToiDa.Size = new System.Drawing.Size(120, 22);
            this.nudSLSinhVienToiDa.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã Chuyên đề:";
            // 
            // lblMaChuyenDe
            // 
            this.lblMaChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaChuyenDe.AutoSize = true;
            this.lblMaChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChuyenDe.Location = new System.Drawing.Point(142, 97);
            this.lblMaChuyenDe.Name = "lblMaChuyenDe";
            this.lblMaChuyenDe.Size = new System.Drawing.Size(0, 16);
            this.lblMaChuyenDe.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "SL Sinh viên tối đa:";
            // 
            // nudSLNhomToiDa
            // 
            this.nudSLNhomToiDa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSLNhomToiDa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSLNhomToiDa.Location = new System.Drawing.Point(143, 149);
            this.nudSLNhomToiDa.Name = "nudSLNhomToiDa";
            this.nudSLNhomToiDa.Size = new System.Drawing.Size(120, 22);
            this.nudSLNhomToiDa.TabIndex = 13;
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(29, 151);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 16);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "SL Nhóm tối đa:";
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpKetThuc.CustomFormat = "MM/dd/yyyy";
            this.dtpKetThuc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetThuc.Location = new System.Drawing.Point(143, 205);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(120, 22);
            this.dtpKetThuc.TabIndex = 8;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBatDau.CustomFormat = "MM/dd/yyyy";
            this.dtpBatDau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDau.Location = new System.Drawing.Point(143, 177);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(120, 22);
            this.dtpBatDau.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian kết thúc:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời gian bắt đầu:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Chuyên đề:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // UC_CapNhatThongTinChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_CapNhatThongTinChuyenDe";
            this.Size = new System.Drawing.Size(894, 520);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLSinhVienToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLNhomToiDa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvChuyenDeMo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.NumericUpDown nudSLSinhVienToiDa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSLNhomToiDa;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbLat;
        private System.Windows.Forms.RadioButton rbDanhSach;
        private System.Windows.Forms.RadioButton rbBieuTuongNho;
        private System.Windows.Forms.RadioButton rbBieuTuongLon;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private MyTextBox txtSearch;
        private System.Windows.Forms.Label lblTenChuyenDe;
        private System.Windows.Forms.Label lblMaChuyenDe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}
