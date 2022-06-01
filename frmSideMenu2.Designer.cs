
namespace SIP
{
    partial class frmSideMenu2
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
            this.btnLaporan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaporan
            // 
            this.btnLaporan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Image = global::SIP.Properties.Resources.book_white_36;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(0, 12);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(178, 35);
            this.btnLaporan.TabIndex = 2;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // frmSideMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(178, 191);
            this.Controls.Add(this.btnLaporan);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSideMenu2";
            this.Text = "frmSideMenu";
            this.Load += new System.EventHandler(this.frmSideMenu2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaporan;
    }
}