
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
            this.label4 = new System.Windows.Forms.Label();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.tglPinjam = new System.Windows.Forms.DateTimePicker();
            this.tglBalikSet = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.yellowbar = new System.Windows.Forms.PictureBox();
            this.yellowbar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nimBox
            // 
            this.nimBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nimBox.Location = new System.Drawing.Point(366, 10);
            this.nimBox.Name = "nimBox";
            this.nimBox.Size = new System.Drawing.Size(222, 29);
            this.nimBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tanggal Peminjaman";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tanggal Pengembalian";
            // 
            // isbnBox
            // 
            this.isbnBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbnBox.Location = new System.Drawing.Point(366, 62);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(222, 29);
            this.isbnBox.TabIndex = 8;
            // 
            // tglPinjam
            // 
            this.tglPinjam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tglPinjam.Location = new System.Drawing.Point(366, 113);
            this.tglPinjam.Name = "tglPinjam";
            this.tglPinjam.Size = new System.Drawing.Size(222, 29);
            this.tglPinjam.TabIndex = 9;
            // 
            // tglBalikSet
            // 
            this.tglBalikSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tglBalikSet.Location = new System.Drawing.Point(366, 163);
            this.tglBalikSet.Name = "tglBalikSet";
            this.tglBalikSet.Size = new System.Drawing.Size(222, 29);
            this.tglBalikSet.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(265, 322);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 33);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // yellowbar
            // 
            this.yellowbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yellowbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.yellowbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yellowbar.Location = new System.Drawing.Point(0, 0);
            this.yellowbar.Name = "yellowbar";
            this.yellowbar.Size = new System.Drawing.Size(600, 50);
            this.yellowbar.TabIndex = 12;
            this.yellowbar.TabStop = false;
            // 
            // yellowbar2
            // 
            this.yellowbar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yellowbar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.yellowbar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yellowbar2.Location = new System.Drawing.Point(0, 102);
            this.yellowbar2.Name = "yellowbar2";
            this.yellowbar2.Size = new System.Drawing.Size(600, 50);
            this.yellowbar2.TabIndex = 13;
            this.yellowbar2.TabStop = false;
            // 
            // frmPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tglBalikSet);
            this.Controls.Add(this.tglPinjam);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nimBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yellowbar);
            this.Controls.Add(this.yellowbar2);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPeminjaman";
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nimBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.DateTimePicker tglPinjam;
        private System.Windows.Forms.DateTimePicker tglBalikSet;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox yellowbar;
        private System.Windows.Forms.PictureBox yellowbar2;
    }
}