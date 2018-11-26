﻿
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenNguoDung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContext = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.miDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.miPhongTo = new System.Windows.Forms.ToolStripMenuItem();
            this.miThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.navMenu = new QuanLyChuyenDe.Views.UserControls.NavigationDrawer();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.lblTenNguoDung);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnContext);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblTenNguoDung
            // 
            this.lblTenNguoDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenNguoDung.AutoSize = true;
            this.lblTenNguoDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoDung.ForeColor = System.Drawing.Color.White;
            this.lblTenNguoDung.Location = new System.Drawing.Point(766, 16);
            this.lblTenNguoDung.Name = "lblTenNguoDung";
            this.lblTenNguoDung.Size = new System.Drawing.Size(66, 16);
            this.lblTenNguoDung.TabIndex = 2;
            this.lblTenNguoDung.Text = "Đ.H.Ngọc";
            this.lblTenNguoDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Chuyên Đề";
            // 
            // btnContext
            // 
            this.btnContext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnContext.BackgroundImage = global::QuanLyChuyenDe.Properties.Resources.ic_more1;
            this.btnContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContext.ContextMenuStrip = this.contextMenuStrip1;
            this.btnContext.FlatAppearance.BorderSize = 0;
            this.btnContext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContext.Location = new System.Drawing.Point(838, 1);
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
            this.pnlChinh.Location = new System.Drawing.Point(50, 50);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(825, 430);
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
            this.navMenu.Size = new System.Drawing.Size(50, 480);
            this.navMenu.Speed = 20;
            this.navMenu.TabIndex = 3;
            // 
            // FrmBangDieuKhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 480);
            this.Controls.Add(this.navMenu);
            this.Controls.Add(this.pnlChinh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBangDieuKhien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBangDieuKhien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miCaNhan;
        private System.Windows.Forms.ToolStripMenuItem miDangXuat;
        private System.Windows.Forms.Label lblTenNguoDung;
        private System.Windows.Forms.ToolStripMenuItem miPhongTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlChinh;
        private UserControls.NavigationDrawer navMenu;
        private System.Windows.Forms.ToolStripMenuItem miThoat;
    }
}