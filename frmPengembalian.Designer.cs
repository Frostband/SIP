
namespace SIP
{
    partial class frmPengembalian
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tglBalik = new System.Windows.Forms.DateTimePicker();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nimBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yellowbar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TransaksiBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yellowbar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSubmit.Location = new System.Drawing.Point(234, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 48);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tglBalik
            // 
            this.tglBalik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tglBalik.Location = new System.Drawing.Point(331, 248);
            this.tglBalik.Name = "tglBalik";
            this.tglBalik.Size = new System.Drawing.Size(222, 39);
            this.tglBalik.TabIndex = 19;
            // 
            // isbnBox
            // 
            this.isbnBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbnBox.BackColor = System.Drawing.SystemColors.Info;
            this.isbnBox.Location = new System.Drawing.Point(331, 188);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(257, 39);
            this.isbnBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tanggal Pengembalian";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "ISBN";
            // 
            // nimBox
            // 
            this.nimBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nimBox.BackColor = System.Drawing.SystemColors.Info;
            this.nimBox.Location = new System.Drawing.Point(331, 127);
            this.nimBox.Name = "nimBox";
            this.nimBox.Size = new System.Drawing.Size(257, 39);
            this.nimBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "NIM";
            // 
            // yellowbar
            // 
            this.yellowbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yellowbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.yellowbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yellowbar.Location = new System.Drawing.Point(0, 57);
            this.yellowbar.Name = "yellowbar";
            this.yellowbar.Size = new System.Drawing.Size(600, 185);
            this.yellowbar.TabIndex = 21;
            this.yellowbar.TabStop = false;
            this.yellowbar.Click += new System.EventHandler(this.yellowbar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(146, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 45);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pengembalian Buku";
            // 
            // TransaksiBox
            // 
            this.TransaksiBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransaksiBox.BackColor = System.Drawing.SystemColors.Info;
            this.TransaksiBox.Location = new System.Drawing.Point(331, 71);
            this.TransaksiBox.Name = "TransaksiBox";
            this.TransaksiBox.Size = new System.Drawing.Size(257, 39);
            this.TransaksiBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "ID Transaksi";
            // 
            // yellowbar2
            // 
            this.yellowbar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yellowbar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.yellowbar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yellowbar2.Location = new System.Drawing.Point(203, 309);
            this.yellowbar2.Name = "yellowbar2";
            this.yellowbar2.Size = new System.Drawing.Size(186, 70);
            this.yellowbar2.TabIndex = 26;
            this.yellowbar2.TabStop = false;
            // 
            // frmPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TransaksiBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tglBalik);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nimBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yellowbar);
            this.Controls.Add(this.yellowbar2);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPengembalian";
            this.Load += new System.EventHandler(this.frmPengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowbar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker tglBalik;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nimBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox yellowbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TransaksiBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox yellowbar2;
    }
}