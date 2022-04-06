
namespace Form_02_Sayi_Tahmin_Oyunu
{
    partial class Form1
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
            this.btnBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblHile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBaslat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(42, 29);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(150, 35);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tahminini Gir";
            // 
            // txtTahmin
            // 
            this.txtTahmin.BackColor = System.Drawing.Color.Lavender;
            this.txtTahmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTahmin.Location = new System.Drawing.Point(42, 98);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(150, 27);
            this.txtTahmin.TabIndex = 2;
            // 
            // btnTahmin
            // 
            this.btnTahmin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTahmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(42, 130);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(150, 35);
            this.btnTahmin.TabIndex = 3;
            this.btnTahmin.Text = "TAHMİN ET";
            this.btnTahmin.UseVisualStyleBackColor = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(40, 177);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(37, 13);
            this.lblMesaj.TabIndex = 4;
            this.lblMesaj.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(219, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "PUAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(219, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "HAK";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHak
            // 
            this.lblHak.BackColor = System.Drawing.Color.PaleGreen;
            this.lblHak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHak.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.ForeColor = System.Drawing.Color.Red;
            this.lblHak.Location = new System.Drawing.Point(219, 137);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(121, 23);
            this.lblHak.TabIndex = 5;
            this.lblHak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.Color.PaleGreen;
            this.lblPuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.Red;
            this.lblPuan.Location = new System.Drawing.Point(219, 65);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(121, 23);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHile
            // 
            this.lblHile.AutoSize = true;
            this.lblHile.Location = new System.Drawing.Point(42, 196);
            this.lblHile.Name = "lblHile";
            this.lblHile.Size = new System.Drawing.Size(35, 13);
            this.lblHile.TabIndex = 7;
            this.lblHile.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 212);
            this.Controls.Add(this.lblHile);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaslat);
            this.Name = "Form1";
            this.Text = "Sayı Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblHile;
    }
}

