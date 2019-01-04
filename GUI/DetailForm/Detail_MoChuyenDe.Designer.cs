namespace GUI.DetailForm
{
    partial class Detail_MoChuyenDe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Toán Rời Rạc", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_MoChuyenDe));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLat = new System.Windows.Forms.RadioButton();
            this.rbDanhSach = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongNho = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongLon = new System.Windows.Forms.RadioButton();
            this.lvDsChuyenDe = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSLNhom = new System.Windows.Forms.NumericUpDown();
            this.nudSLSVToiDa = new System.Windows.Forms.NumericUpDown();
            this.nudNamHoc = new System.Windows.Forms.NumericUpDown();
            this.btnMo = new System.Windows.Forms.Button();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.lblTenChuyenDe = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaChuyenDe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLSVToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(978, 452);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lvDsChuyenDe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chuyên Đề";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLat);
            this.panel1.Controls.Add(this.rbDanhSach);
            this.panel1.Controls.Add(this.rbBieuTuongNho);
            this.panel1.Controls.Add(this.rbBieuTuongLon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 35);
            this.panel1.TabIndex = 0;
            // 
            // rbLat
            // 
            this.rbLat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbLat.AutoSize = true;
            this.rbLat.Checked = true;
            this.rbLat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLat.Location = new System.Drawing.Point(444, 7);
            this.rbLat.Name = "rbLat";
            this.rbLat.Size = new System.Drawing.Size(42, 20);
            this.rbLat.TabIndex = 6;
            this.rbLat.TabStop = true;
            this.rbLat.Text = "lát";
            this.rbLat.UseVisualStyleBackColor = true;
            this.rbLat.CheckedChanged += new System.EventHandler(this.rbLat_CheckedChanged);
            // 
            // rbDanhSach
            // 
            this.rbDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbDanhSach.AutoSize = true;
            this.rbDanhSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDanhSach.Location = new System.Drawing.Point(324, 7);
            this.rbDanhSach.Name = "rbDanhSach";
            this.rbDanhSach.Size = new System.Drawing.Size(91, 20);
            this.rbDanhSach.TabIndex = 7;
            this.rbDanhSach.Text = "danh sách";
            this.rbDanhSach.UseVisualStyleBackColor = true;
            this.rbDanhSach.CheckedChanged += new System.EventHandler(this.rbDanhSach_CheckedChanged);
            // 
            // rbBieuTuongNho
            // 
            this.rbBieuTuongNho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbBieuTuongNho.AutoSize = true;
            this.rbBieuTuongNho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBieuTuongNho.Location = new System.Drawing.Point(176, 7);
            this.rbBieuTuongNho.Name = "rbBieuTuongNho";
            this.rbBieuTuongNho.Size = new System.Drawing.Size(124, 20);
            this.rbBieuTuongNho.TabIndex = 8;
            this.rbBieuTuongNho.Text = "biểu tượng nhỏ";
            this.rbBieuTuongNho.UseVisualStyleBackColor = true;
            this.rbBieuTuongNho.CheckedChanged += new System.EventHandler(this.rbBieuTuongNho_CheckedChanged);
            // 
            // rbBieuTuongLon
            // 
            this.rbBieuTuongLon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbBieuTuongLon.AutoSize = true;
            this.rbBieuTuongLon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBieuTuongLon.Location = new System.Drawing.Point(38, 7);
            this.rbBieuTuongLon.Name = "rbBieuTuongLon";
            this.rbBieuTuongLon.Size = new System.Drawing.Size(121, 20);
            this.rbBieuTuongLon.TabIndex = 9;
            this.rbBieuTuongLon.Text = "biểu tượng lớn";
            this.rbBieuTuongLon.UseVisualStyleBackColor = true;
            this.rbBieuTuongLon.CheckedChanged += new System.EventHandler(this.rbBieuTuongLon_CheckedChanged);
            // 
            // lvDsChuyenDe
            // 
            this.lvDsChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDsChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDsChuyenDe.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvDsChuyenDe.LargeImageList = this.imageList1;
            this.lvDsChuyenDe.Location = new System.Drawing.Point(3, 18);
            this.lvDsChuyenDe.Name = "lvDsChuyenDe";
            this.lvDsChuyenDe.Size = new System.Drawing.Size(526, 390);
            this.lvDsChuyenDe.SmallImageList = this.imageList1;
            this.lvDsChuyenDe.TabIndex = 0;
            this.lvDsChuyenDe.UseCompatibleStateImageBehavior = false;
            this.lvDsChuyenDe.SelectedIndexChanged += new System.EventHandler(this.lvDsChuyenDe_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_ChuyenDe.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSLNhom);
            this.groupBox2.Controls.Add(this.nudSLSVToiDa);
            this.groupBox2.Controls.Add(this.nudNamHoc);
            this.groupBox2.Controls.Add(this.btnMo);
            this.groupBox2.Controls.Add(this.cbHocKi);
            this.groupBox2.Controls.Add(this.txtNganh);
            this.groupBox2.Controls.Add(this.lblTenChuyenDe);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblMaChuyenDe);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.dtpKetThuc);
            this.groupBox2.Controls.Add(this.dtpBatDau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 452);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // nudSLNhom
            // 
            this.nudSLNhom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSLNhom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSLNhom.Location = new System.Drawing.Point(170, 244);
            this.nudSLNhom.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSLNhom.Name = "nudSLNhom";
            this.nudSLNhom.Size = new System.Drawing.Size(120, 22);
            this.nudSLNhom.TabIndex = 72;
            // 
            // nudSLSVToiDa
            // 
            this.nudSLSVToiDa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSLSVToiDa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSLSVToiDa.Location = new System.Drawing.Point(170, 216);
            this.nudSLSVToiDa.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSLSVToiDa.Name = "nudSLSVToiDa";
            this.nudSLSVToiDa.Size = new System.Drawing.Size(120, 22);
            this.nudSLSVToiDa.TabIndex = 71;
            // 
            // nudNamHoc
            // 
            this.nudNamHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudNamHoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNamHoc.Location = new System.Drawing.Point(170, 188);
            this.nudNamHoc.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNamHoc.Name = "nudNamHoc";
            this.nudNamHoc.Size = new System.Drawing.Size(120, 22);
            this.nudNamHoc.TabIndex = 70;
            // 
            // btnMo
            // 
            this.btnMo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMo.Enabled = false;
            this.btnMo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMo.Location = new System.Drawing.Point(171, 328);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(93, 34);
            this.btnMo.TabIndex = 69;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // cbHocKi
            // 
            this.cbHocKi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHocKi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cbHocKi.Location = new System.Drawing.Point(171, 160);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(76, 24);
            this.cbHocKi.TabIndex = 68;
            // 
            // txtNganh
            // 
            this.txtNganh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNganh.Enabled = false;
            this.txtNganh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNganh.Location = new System.Drawing.Point(170, 132);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(176, 22);
            this.txtNganh.TabIndex = 67;
            // 
            // lblTenChuyenDe
            // 
            this.lblTenChuyenDe.AllowDrop = true;
            this.lblTenChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenChuyenDe.AutoEllipsis = true;
            this.lblTenChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuyenDe.Location = new System.Drawing.Point(166, 52);
            this.lblTenChuyenDe.Name = "lblTenChuyenDe";
            this.lblTenChuyenDe.Size = new System.Drawing.Size(239, 53);
            this.lblTenChuyenDe.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ngành:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Mã Chuyên đề:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Học kì:";
            // 
            // lblMaChuyenDe
            // 
            this.lblMaChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaChuyenDe.AutoSize = true;
            this.lblMaChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChuyenDe.Location = new System.Drawing.Point(168, 113);
            this.lblMaChuyenDe.Name = "lblMaChuyenDe";
            this.lblMaChuyenDe.Size = new System.Drawing.Size(0, 16);
            this.lblMaChuyenDe.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Năm học:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "SL Sinh viên tối đa:";
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(32, 250);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 16);
            this.lbl.TabIndex = 66;
            this.lbl.Text = "SL Nhóm tối đa:";
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpKetThuc.CustomFormat = "MM/dd/yyyy";
            this.dtpKetThuc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetThuc.Location = new System.Drawing.Point(170, 300);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(176, 22);
            this.dtpKetThuc.TabIndex = 57;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBatDau.CustomFormat = "MM/dd/yyyy";
            this.dtpBatDau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDau.Location = new System.Drawing.Point(171, 272);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(176, 22);
            this.dtpBatDau.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Thời gian kết thúc:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Thời gian bắt đầu:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tên Chuyên đề:";
            // 
            // Detail_MoChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 452);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Detail_MoChuyenDe";
            this.Text = "Detail_MoChuyenDe";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLSVToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvDsChuyenDe;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLat;
        private System.Windows.Forms.RadioButton rbDanhSach;
        private System.Windows.Forms.RadioButton rbBieuTuongNho;
        private System.Windows.Forms.RadioButton rbBieuTuongLon;
        private System.Windows.Forms.NumericUpDown nudSLNhom;
        private System.Windows.Forms.NumericUpDown nudSLSVToiDa;
        private System.Windows.Forms.NumericUpDown nudNamHoc;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.TextBox txtNganh;
        private System.Windows.Forms.Label lblTenChuyenDe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaChuyenDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}