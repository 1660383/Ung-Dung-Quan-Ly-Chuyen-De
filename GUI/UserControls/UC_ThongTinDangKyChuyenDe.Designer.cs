namespace GUI.UserControls
{
    partial class UC_ThongTinDangKyChuyenDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ThongTinDangKyChuyenDe));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pcbLoad = new System.Windows.Forms.PictureBox();
            this.lvChuyenDeMo = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLat = new System.Windows.Forms.RadioButton();
            this.rbDanhSach = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongNho = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongLon = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbMaCD = new System.Windows.Forms.ComboBox();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.gbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSLNhom = new System.Windows.Forms.TextBox();
            this.txtSLDK = new System.Windows.Forms.TextBox();
            this.lblTenChuyenDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaChuyenDe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbThongTinChiTiet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pcbLoad);
            this.splitContainer1.Panel1.Controls.Add(this.lvChuyenDeMo);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.cbHocKy);
            this.splitContainer1.Panel1.Controls.Add(this.cbMaCD);
            this.splitContainer1.Panel1.Controls.Add(this.cbNamHoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbThongTinChiTiet);
            this.splitContainer1.Size = new System.Drawing.Size(888, 499);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.TabIndex = 1;
            // 
            // pcbLoad
            // 
            this.pcbLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbLoad.BackgroundImage = global::GUI.Properties.Resources.icons8_synchronize_32;
            this.pcbLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLoad.Location = new System.Drawing.Point(359, 17);
            this.pcbLoad.Name = "pcbLoad";
            this.pcbLoad.Size = new System.Drawing.Size(34, 26);
            this.pcbLoad.TabIndex = 23;
            this.pcbLoad.TabStop = false;
            this.pcbLoad.Click += new System.EventHandler(this.pcbLoad_Click);
            // 
            // lvChuyenDeMo
            // 
            this.lvChuyenDeMo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvChuyenDeMo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lvChuyenDeMo.LargeImageList = this.imageList1;
            this.lvChuyenDeMo.Location = new System.Drawing.Point(3, 95);
            this.lvChuyenDeMo.Name = "lvChuyenDeMo";
            this.lvChuyenDeMo.Size = new System.Drawing.Size(482, 367);
            this.lvChuyenDeMo.SmallImageList = this.imageList1;
            this.lvChuyenDeMo.TabIndex = 21;
            this.lvChuyenDeMo.UseCompatibleStateImageBehavior = false;
            this.lvChuyenDeMo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvChuyenDeMo_ItemSelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_ChuyenDe.png");
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
            this.panel1.Size = new System.Drawing.Size(485, 31);
            this.panel1.TabIndex = 20;
            // 
            // rbLat
            // 
            this.rbLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbLat.AutoSize = true;
            this.rbLat.Location = new System.Drawing.Point(425, 5);
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
            this.rbDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbDanhSach.AutoSize = true;
            this.rbDanhSach.Location = new System.Drawing.Point(302, 5);
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
            this.rbBieuTuongNho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbBieuTuongNho.AutoSize = true;
            this.rbBieuTuongNho.Location = new System.Drawing.Point(157, 5);
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
            this.rbBieuTuongLon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbBieuTuongLon.AutoSize = true;
            this.rbBieuTuongLon.Location = new System.Drawing.Point(17, 5);
            this.rbBieuTuongLon.Name = "rbBieuTuongLon";
            this.rbBieuTuongLon.Size = new System.Drawing.Size(121, 20);
            this.rbBieuTuongLon.TabIndex = 5;
            this.rbBieuTuongLon.TabStop = true;
            this.rbBieuTuongLon.Text = "biểu tượng lớn";
            this.rbBieuTuongLon.UseVisualStyleBackColor = true;
            this.rbBieuTuongLon.CheckedChanged += new System.EventHandler(this.rbBieuTuongLon_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(173, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Năm Học";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(48, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Học Kỳ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(48, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã CD";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cbHocKy.Location = new System.Drawing.Point(106, 52);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(57, 24);
            this.cbHocKy.TabIndex = 13;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // cbMaCD
            // 
            this.cbMaCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbMaCD.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbMaCD.FormattingEnabled = true;
            this.cbMaCD.Location = new System.Drawing.Point(106, 17);
            this.cbMaCD.Name = "cbMaCD";
            this.cbMaCD.Size = new System.Drawing.Size(240, 24);
            this.cbMaCD.TabIndex = 15;
            this.cbMaCD.SelectedIndexChanged += new System.EventHandler(this.cbMaCD_SelectedIndexChanged);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbNamHoc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(244, 52);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(102, 24);
            this.cbNamHoc.TabIndex = 14;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
            // 
            // gbThongTinChiTiet
            // 
            this.gbThongTinChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTinChiTiet.Controls.Add(this.txtTrangThai);
            this.gbThongTinChiTiet.Controls.Add(this.label5);
            this.gbThongTinChiTiet.Controls.Add(this.txtSLNhom);
            this.gbThongTinChiTiet.Controls.Add(this.txtSLDK);
            this.gbThongTinChiTiet.Controls.Add(this.lblTenChuyenDe);
            this.gbThongTinChiTiet.Controls.Add(this.label1);
            this.gbThongTinChiTiet.Controls.Add(this.lblMaChuyenDe);
            this.gbThongTinChiTiet.Controls.Add(this.label6);
            this.gbThongTinChiTiet.Controls.Add(this.lbl);
            this.gbThongTinChiTiet.Controls.Add(this.dtpKetThuc);
            this.gbThongTinChiTiet.Controls.Add(this.dtpBatDau);
            this.gbThongTinChiTiet.Controls.Add(this.label4);
            this.gbThongTinChiTiet.Controls.Add(this.label3);
            this.gbThongTinChiTiet.Controls.Add(this.label2);
            this.gbThongTinChiTiet.Location = new System.Drawing.Point(2, 1);
            this.gbThongTinChiTiet.MinimumSize = new System.Drawing.Size(393, 0);
            this.gbThongTinChiTiet.Name = "gbThongTinChiTiet";
            this.gbThongTinChiTiet.Size = new System.Drawing.Size(395, 497);
            this.gbThongTinChiTiet.TabIndex = 2;
            this.gbThongTinChiTiet.TabStop = false;
            this.gbThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(153, 230);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(176, 22);
            this.txtTrangThai.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Trạng thái:";
            // 
            // txtSLNhom
            // 
            this.txtSLNhom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSLNhom.Enabled = false;
            this.txtSLNhom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNhom.Location = new System.Drawing.Point(153, 144);
            this.txtSLNhom.Name = "txtSLNhom";
            this.txtSLNhom.Size = new System.Drawing.Size(176, 22);
            this.txtSLNhom.TabIndex = 19;
            this.txtSLNhom.TextChanged += new System.EventHandler(this.txtSLNhom_TextChanged);
            // 
            // txtSLDK
            // 
            this.txtSLDK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSLDK.Enabled = false;
            this.txtSLDK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLDK.Location = new System.Drawing.Point(153, 116);
            this.txtSLDK.Name = "txtSLDK";
            this.txtSLDK.Size = new System.Drawing.Size(176, 22);
            this.txtSLDK.TabIndex = 18;
            // 
            // lblTenChuyenDe
            // 
            this.lblTenChuyenDe.AllowDrop = true;
            this.lblTenChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenChuyenDe.AutoEllipsis = true;
            this.lblTenChuyenDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuyenDe.Location = new System.Drawing.Point(149, 33);
            this.lblTenChuyenDe.Name = "lblTenChuyenDe";
            this.lblTenChuyenDe.Size = new System.Drawing.Size(239, 53);
            this.lblTenChuyenDe.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Chuyên đề:";
            // 
            // lblMaChuyenDe
            // 
            this.lblMaChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaChuyenDe.AutoSize = true;
            this.lblMaChuyenDe.Location = new System.Drawing.Point(151, 94);
            this.lblMaChuyenDe.Name = "lblMaChuyenDe";
            this.lblMaChuyenDe.Size = new System.Drawing.Size(0, 16);
            this.lblMaChuyenDe.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "SL đã đăng ký:";
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(14, 147);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 16);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "SL Nhóm tối đa:";
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpKetThuc.CustomFormat = "MM/dd/yyyy";
            this.dtpKetThuc.Enabled = false;
            this.dtpKetThuc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetThuc.Location = new System.Drawing.Point(153, 202);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(176, 22);
            this.dtpKetThuc.TabIndex = 8;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBatDau.CustomFormat = "MM/dd/yyyy";
            this.dtpBatDau.Enabled = false;
            this.dtpBatDau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDau.Location = new System.Drawing.Point(153, 174);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(176, 22);
            this.dtpBatDau.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian kết thúc:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời gian bắt đầu:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Chuyên đề:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 520);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đăng Ký Chuyên Đề";
            // 
            // UC_ThongTinDangKyChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_ThongTinDangKyChuyenDe";
            this.Size = new System.Drawing.Size(894, 520);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbThongTinChiTiet.ResumeLayout(false);
            this.gbThongTinChiTiet.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbMaCD;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.GroupBox gbThongTinChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaChuyenDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSLNhom;
        private System.Windows.Forms.TextBox txtSLDK;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbLat;
        private System.Windows.Forms.RadioButton rbDanhSach;
        private System.Windows.Forms.RadioButton rbBieuTuongNho;
        private System.Windows.Forms.RadioButton rbBieuTuongLon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvChuyenDeMo;
        private System.Windows.Forms.PictureBox pcbLoad;
        private System.Windows.Forms.Label lblTenChuyenDe;
    }
}
