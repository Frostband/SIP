
namespace SIP
{
    partial class frmPeminjaman
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
            this.label1 = new System.Windows.Forms.Label();
            this.nimBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.tglPinjam = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.yellowbar2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transaksi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nimBox
            // 
            this.nimBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nimBox.BackColor = System.Drawing.SystemColors.Info;
            this.nimBox.Location = new System.Drawing.Point(300, 115);
            this.nimBox.Name = "nimBox";
            this.nimBox.Size = new System.Drawing.Size(288, 39);
            this.nimBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chartreuse;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tanggal Peminjaman";
            // 
            // isbnBox
            // 
            this.isbnBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbnBox.BackColor = System.Drawing.SystemColors.Info;
            this.isbnBox.Location = new System.Drawing.Point(300, 160);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(288, 39);
            this.isbnBox.TabIndex = 8;
            // 
            // tglPinjam
            // 
            this.tglPinjam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tglPinjam.Location = new System.Drawing.Point(300, 213);
            this.tglPinjam.Name = "tglPinjam";
            this.tglPinjam.Size = new System.Drawing.Size(288, 39);
            this.tglPinjam.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSubmit.Location = new System.Drawing.Point(237, 322);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 46);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // yellowbar2
            // 
            this.yellowbar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yellowbar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.yellowbar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yellowbar2.Location = new System.Drawing.Point(0, -1);
            this.yellowbar2.Name = "yellowbar2";
            this.yellowbar2.Size = new System.Drawing.Size(600, 71);
            this.yellowbar2.TabIndex = 13;
            this.yellowbar2.TabStop = false;
            this.yellowbar2.Click += new System.EventHandler(this.yellowbar2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 111);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Chartreuse;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(156, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 45);
            this.label4.TabIndex = 15;
            this.label4.Text = "Peminjaman Buku";
            // 
            // transaksi
            // 
            this.transaksi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transaksi.BackColor = System.Drawing.SystemColors.Info;
            this.transaksi.Location = new System.Drawing.Point(300, 70);
            this.transaksi.Name = "transaksi";
            this.transaksi.Size = new System.Drawing.Size(288, 39);
            this.transaksi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID Transaksi";
            // 
            // deadline
            // 
            this.deadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deadline.Location = new System.Drawing.Point(300, 262);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(288, 39);
            this.deadline.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "DEADLINE";
            // 
            // frmPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transaksi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tglPinjam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nimBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yellowbar2);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPeminjaman";
            this.Load += new System.EventHandler(this.frmPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nimBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.DateTimePicker tglPinjam;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox yellowbar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker deadline;
        private System.Windows.Forms.Label label6;
    }
}