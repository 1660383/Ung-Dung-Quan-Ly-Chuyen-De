
using System.Drawing;

namespace QuanLyChuyenDe.Views.Dashboard
{
    partial class FrmBangDieuKhien
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
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblTenNguoDung = new System.Windows.Forms.Label();
            this.lblTenUngDung = new System.Windows.Forms.Label();
            this.btnContext = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.miDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.miPhongTo = new System.Windows.Forms.ToolStripMenuItem();
            this.miThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.navMenu = new QuanLyChuyenDe.Views.UserControls.NavigationDrawer();
            this.pnlBanner.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlBanner.Controls.Add(this.lblTenNguoDung);
            this.pnlBanner.Controls.Add(this.lblTenUngDung);
            this.pnlBanner.Controls.Add(this.btnContext);
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(947, 50);
            this.pnlBanner.TabIndex = 0;
            this.pnlBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBanner_MouseDown);
            this.pnlBanner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBanner_MouseMove);
            this.pnlBanner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBanner_MouseUp);
            // 
            // lblTenNguoDung
            // 
            this.lblTenNguoDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenNguoDung.AutoSize = true;
            this.lblTenNguoDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoDung.ForeColor = System.Drawing.Color.White;
            this.lblTenNguoDung.Location = new System.Drawing.Point(838, 16);
            this.lblTenNguoDung.Name = "lblTenNguoDung";
            this.lblTenNguoDung.Size = new System.Drawing.Size(66, 16);
            this.lblTenNguoDung.TabIndex = 2;
            this.lblTenNguoDung.Text = "Đ.H.Ngọc";
            this.lblTenNguoDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenUngDung
            // 
            this.lblTenUngDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTenUngDung.AutoSize = true;
            this.lblTenUngDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenUngDung.ForeColor = System.Drawing.Color.White;
            this.lblTenUngDung.Location = new System.Drawing.Point(350, 6);
            this.lblTenUngDung.Name = "lblTenUngDung";
            this.lblTenUngDung.Size = new System.Drawing.Size(276, 31);
            this.lblTenUngDung.TabIndex = 3;
            this.lblTenUngDung.Text = "Quản Lý Chuyên Đề";
            this.lblTenUngDung.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBanner_MouseDown);
            this.lblTenUngDung.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBanner_MouseMove);
            this.lblTenUngDung.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBanner_MouseUp);
            // 
            // btnContext
            // 
            this.btnContext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnContext.BackgroundImage = global::QuanLyChuyenDe.Properties.Resources.ic_more1;
            this.btnContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContext.ContextMenuStrip = this.contextMenuStrip1;
            this.btnContext.FlatAppearance.BorderSize = 0;
            this.btnContext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContext.Location = new System.Drawing.Point(910, 1);
            this.btnContext.Name = "btnContext";
            this.btnContext.Size = new System.Drawing.Size(38, 48);
            this.btnContext.TabIndex = 1;
            this.btnContext.UseVisualStyleBackColor = true;
            this.btnContext.Click += new System.EventHandler(this.btnContext_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCaNhan,
            this.miDangXuat,
            this.miPhongTo,
            this.miThoat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 92);
            // 
            // miCaNhan
            // 
            this.miCaNhan.Name = "miCaNhan";
            this.miCaNhan.Size = new System.Drawing.Size(127, 22);
            this.miCaNhan.Text = "Cá nhân";
            // 
            // miDangXuat
            // 
            this.miDangXuat.Name = "miDangXuat";
            this.miDangXuat.Size = new System.Drawing.Size(127, 22);
            this.miDangXuat.Text = "Đăng xuất";
            // 
            // miPhongTo
            // 
            this.miPhongTo.Name = "miPhongTo";
            this.miPhongTo.Size = new System.Drawing.Size(127, 22);
            this.miPhongTo.Text = "Phóng to";
            this.miPhongTo.Click += new System.EventHandler(this.miPhongTo_Click);
            // 
            // miThoat
            // 
            this.miThoat.Name = "miThoat";
            this.miThoat.Size = new System.Drawing.Size(127, 22);
            this.miThoat.Text = "Thoát";
            this.miThoat.Click += new System.EventHandler(this.miThoat_Click);
            // 
            // pnlChinh
            // 
            this.pnlChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlChinh.Location = new System.Drawing.Point(50, 50);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlChinh.Size = new System.Drawing.Size(894, 520);
            this.pnlChinh.TabIndex = 2;
            // 
            // navMenu
            // 
            this.navMenu.AutoSetItemWidth = true;
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.navMenu.Flag = true;
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.MaxWidth = 250;
            this.navMenu.MinWidth = 50;
            this.navMenu.Name = "navMenu";
            this.navMenu.Size = new System.Drawing.Size(50, 570);
            this.navMenu.Speed = 20;
            this.navMenu.TabIndex = 3;
            // 
            // FrmBangDieuKhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 570);
            this.Controls.Add(this.navMenu);
            this.Controls.Add(this.pnlChinh);
            this.Controls.Add(this.pnlBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBangDieuKhien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBangDieuKhien";
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Button btnContext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miCaNhan;
        private System.Windows.Forms.ToolStripMenuItem miDangXuat;
        private System.Windows.Forms.Label lblTenNguoDung;
        private System.Windows.Forms.ToolStripMenuItem miPhongTo;
        private System.Windows.Forms.Label lblTenUngDung;
        private System.Windows.Forms.Panel pnlChinh;
        private UserControls.NavigationDrawer navMenu;
        private System.Windows.Forms.ToolStripMenuItem miThoat;
    }
}