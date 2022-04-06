
namespace WithClassSql_Crud2
{
    partial class FormRandevu
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
            this.cmbBolumler = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRandevu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm:";
            // 
            // cmbBolumler
            // 
            this.cmbBolumler.FormattingEnabled = true;
            this.cmbBolumler.Location = new System.Drawing.Point(64, 17);
            this.cmbBolumler.Name = "cmbBolumler";
            this.cmbBolumler.Size = new System.Drawing.Size(142, 21);
            this.cmbBolumler.TabIndex = 1;
            this.cmbBolumler.SelectedIndexChanged += new System.EventHandler(this.cmbBolumler_SelectedIndexChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(274, 20);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(147, 20);
            this.dtpTarih.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(64, 52);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(248, 20);
            this.txtHasta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hasta:";
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Location = new System.Drawing.Point(26, 82);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.Size = new System.Drawing.Size(289, 251);
            this.dgvHastalar.TabIndex = 4;
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(321, 82);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(100, 251);
            this.lstDoktorlar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doktor:";
            // 
            // btnRandevu
            // 
            this.btnRandevu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.Location = new System.Drawing.Point(26, 339);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(395, 42);
            this.btnRandevu.TabIndex = 6;
            this.btnRandevu.Text = "Randevu Oluştur";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // FormRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 382);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.lstDoktorlar);
            this.Controls.Add(this.dgvHastalar);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbBolumler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRandevu";
            this.Text = "FormRandevu";
            this.Load += new System.EventHandler(this.FormRandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBolumler;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRandevu;
    }
}