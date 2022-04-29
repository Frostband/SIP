
namespace SIP
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAkun = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Controls.Add(this.panelHeader);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(800, 450);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnPengembalian);
            this.panel1.Controls.Add(this.btnPeminjaman);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 380);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.Image = ((System.Drawing.Image)(resources.GetObject("btnKeluar.Image")));
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.Location = new System.Drawing.Point(0, 310);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(200, 35);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click_1);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPengembalian.FlatAppearance.BorderSize = 0;
            this.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengembalian.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.Image = global::SIP.Properties.Resources.book_stack_white_36;
            this.btnPengembalian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengembalian.Location = new System.Drawing.Point(0, 236);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(200, 35);
            this.btnPengembalian.TabIndex = 3;
            this.btnPengembalian.Text = "Pengembalian";
            this.btnPengembalian.UseVisualStyleBackColor = true;
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeminjaman.FlatAppearance.BorderSize = 0;
            this.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeminjaman.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.Image = global::SIP.Properties.Resources.book_white_36;
            this.btnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeminjaman.Location = new System.Drawing.Point(0, 173);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(200, 35);
            this.btnPeminjaman.TabIndex = 2;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::SIP.Properties.Resources.outline_home_white_36;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 112);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 35);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(173)))), ((int)(((byte)(198)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.labelAkun);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
            this.panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistem Informasi Perpustakaan";
            // 
            // labelAkun
            // 
            this.labelAkun.AutoSize = true;
            this.labelAkun.Location = new System.Drawing.Point(638, 21);
            this.labelAkun.Name = "labelAkun";
            this.labelAkun.Size = new System.Drawing.Size(64, 25);
            this.labelAkun.TabIndex = 1;
            this.labelAkun.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(730, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "lo";
            this.mainpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAkun;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}