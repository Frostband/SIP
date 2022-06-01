
namespace SIP
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAkun = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSideMenuSwitch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideMenuSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 108);
            this.panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistem Informasi Perpustakaan";
            // 
            // labelAkun
            // 
            this.labelAkun.AutoSize = true;
            this.labelAkun.Location = new System.Drawing.Point(957, 32);
            this.labelAkun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAkun.Name = "labelAkun";
            this.labelAkun.Size = new System.Drawing.Size(99, 40);
            this.labelAkun.TabIndex = 1;
            this.labelAkun.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1095, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.panelSide.Controls.Add(this.panelMenu);
            this.panelSide.Controls.Add(this.btnSideMenuSwitch);
            this.panelSide.Controls.Add(this.pictureBox1);
            this.panelSide.Controls.Add(this.btnKeluar);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSide.ForeColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 108);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(300, 584);
            this.panelSide.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(0, 172);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 245);
            this.panelMenu.TabIndex = 5;
            // 
            // btnSideMenuSwitch
            // 
            this.btnSideMenuSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideMenuSwitch.Image = global::SIP.Properties.Resources.button_custom_1_361;
            this.btnSideMenuSwitch.Location = new System.Drawing.Point(272, 315);
            this.btnSideMenuSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSideMenuSwitch.Name = "btnSideMenuSwitch";
            this.btnSideMenuSwitch.Size = new System.Drawing.Size(36, 55);
            this.btnSideMenuSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSideMenuSwitch.TabIndex = 0;
            this.btnSideMenuSwitch.TabStop = false;
            this.btnSideMenuSwitch.Click += new System.EventHandler(this.btnSideMenuSwitch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 154);
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
            this.btnKeluar.Location = new System.Drawing.Point(0, 477);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(300, 54);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click_1);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpanel.Location = new System.Drawing.Point(300, 108);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(900, 585);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lo";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSideMenuSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAkun;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox btnSideMenuSwitch;
        private System.Windows.Forms.Panel panelMenu;
    }
}