namespace GUI.UserControls
{
    partial class UC_DanhSachChuyenDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DanhSachChuyenDe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLat = new System.Windows.Forms.RadioButton();
            this.rbDanhSach = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongNho = new System.Windows.Forms.RadioButton();
            this.rbBieuTuongLon = new System.Windows.Forms.RadioButton();
            this.lvDsChuyenDe = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbMaNganh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenChuyenDe = new System.Windows.Forms.TextBox();
            this.txtMaChuyenDe = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbLat
            // 
            this.rbLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbLat.AutoSize = true;
            this.rbLat.Location = new System.Drawing.Point(414, 6);
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
            this.rbDanhSach.Location = new System.Drawing.Point(297, 6);
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
            this.rbBieuTuongNho.Location = new System.Drawing.Point(153, 6);
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
            this.rbBieuTuongLon.Checked = true;
            this.rbBieuTuongLon.Location = new System.Drawing.Point(16, 6);
            this.rbBieuTuongLon.Name = "rbBieuTuongLon";
            this.rbBieuTuongLon.Size = new System.Drawing.Size(121, 20);
            this.rbBieuTuongLon.TabIndex = 5;
            this.rbBieuTuongLon.TabStop = true;
            this.rbBieuTuongLon.Text = "biểu tượng lớn";
            this.rbBieuTuongLon.UseVisualStyleBackColor = true;
            this.rbBieuTuongLon.CheckedChanged += new System.EventHandler(this.rbBieuTuongLon_CheckedChanged);
            // 
            // lvDsChuyenDe
            // 
            this.lvDsChuyenDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDsChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lvDsChuyenDe.LargeImageList = this.imageList1;
            this.lvDsChuyenDe.Location = new System.Drawing.Point(0, 0);
            this.lvDsChuyenDe.Name = "lvDsChuyenDe";
            this.lvDsChuyenDe.Size = new System.Drawing.Size(485, 468);
            this.lvDsChuyenDe.SmallImageList = this.imageList1;
            this.lvDsChuyenDe.TabIndex = 21;
            this.lvDsChuyenDe.UseCompatibleStateImageBehavior = false;
            this.lvDsChuyenDe.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDsChuyenDe_ItemSelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_ChuyenDe.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 520);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Chuyên Đề";
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
            this.splitContainer1.Panel1.Controls.Add(this.lvDsChuyenDe);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbThongTinChiTiet);
            this.splitContainer1.Size = new System.Drawing.Size(888, 499);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbThongTinChiTiet
            // 
            this.gbThongTinChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTinChiTiet.Controls.Add(this.btnClean);
            this.gbThongTinChiTiet.Controls.Add(this.btnSua);
            this.gbThongTinChiTiet.Controls.Add(this.btnXoa);
            this.gbThongTinChiTiet.Controls.Add(this.btnThem);
            this.gbThongTinChiTiet.Controls.Add(this.cbMaNganh);
            this.gbThongTinChiTiet.Controls.Add(this.label3);
            this.gbThongTinChiTiet.Controls.Add(this.label2);
            this.gbThongTinChiTiet.Controls.Add(this.label1);
            this.gbThongTinChiTiet.Controls.Add(this.txtTenChuyenDe);
            this.gbThongTinChiTiet.Controls.Add(this.txtMaChuyenDe);
            this.gbThongTinChiTiet.Enabled = false;
            this.gbThongTinChiTiet.Location = new System.Drawing.Point(2, 1);
            this.gbThongTinChiTiet.MinimumSize = new System.Drawing.Size(393, 0);
            this.gbThongTinChiTiet.Name = "gbThongTinChiTiet";
            this.gbThongTinChiTiet.Size = new System.Drawing.Size(395, 497);
            this.gbThongTinChiTiet.TabIndex = 2;
            this.gbThongTinChiTiet.TabStop = false;
            this.gbThongTinChiTiet.Text = "Thông tin chi tiết";
            this.gbThongTinChiTiet.Enter += new System.EventHandler(this.gbThongTinChiTiet_Enter);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.Location = new System.Drawing.Point(340, 43);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(32, 32);
            this.btnClean.TabIndex = 4;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_edit_row_32;
            this.btnSua.Location = new System.Drawing.Point(147, 172);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 49);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_delete_bin_32;
            this.btnXoa.Location = new System.Drawing.Point(264, 172);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Image = global::GUI.Properties.Resources.icons8_plus_32;
            this.btnThem.Location = new System.Drawing.Point(28, 172);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 49);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbMaNganh
            // 
            this.cbMaNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbMaNganh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNganh.FormattingEnabled = true;
            this.cbMaNganh.Items.AddRange(new object[] {
            "a",
            "s",
            "s",
            "s",
            "d"});
            this.cbMaNganh.Location = new System.Drawing.Point(147, 88);
            this.cbMaNganh.Name = "cbMaNganh";
            this.cbMaNganh.Size = new System.Drawing.Size(225, 24);
            this.cbMaNganh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Chuyên Đề:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Ngành:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Chuyên Đề:";
            // 
            // txtTenChuyenDe
            // 
            this.txtTenChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTenChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChuyenDe.Location = new System.Drawing.Point(147, 128);
            this.txtTenChuyenDe.Name = "txtTenChuyenDe";
            this.txtTenChuyenDe.Size = new System.Drawing.Size(225, 22);
            this.txtTenChuyenDe.TabIndex = 0;
            // 
            // txtMaChuyenDe
            // 
            this.txtMaChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaChuyenDe.Enabled = false;
            this.txtMaChuyenDe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuyenDe.Location = new System.Drawing.Point(147, 48);
            this.txtMaChuyenDe.Name = "txtMaChuyenDe";
            this.txtMaChuyenDe.ReadOnly = true;
            this.txtMaChuyenDe.Size = new System.Drawing.Size(187, 22);
            this.txtMaChuyenDe.TabIndex = 0;
            // 
            // UC_DanhSachChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_DanhSachChuyenDe";
            this.Size = new System.Drawing.Size(894, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbThongTinChiTiet.ResumeLayout(false);
            this.gbThongTinChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbLat;
        private System.Windows.Forms.RadioButton rbDanhSach;
        private System.Windows.Forms.RadioButton rbBieuTuongNho;
        private System.Windows.Forms.RadioButton rbBieuTuongLon;
        private System.Windows.Forms.ListView lvDsChuyenDe;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbThongTinChiTiet;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbMaNganh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenChuyenDe;
        private System.Windows.Forms.TextBox txtMaChuyenDe;
        private System.Windows.Forms.Button btnClean;
    }
}
