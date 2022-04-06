
namespace WithClassSql_Crud1
{
    partial class FormAna
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
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnDsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHastalar.Location = new System.Drawing.Point(0, 0);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.Size = new System.Drawing.Size(691, 254);
            this.dgvHastalar.TabIndex = 0;
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(95, 298);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(194, 69);
            this.btnYeni.TabIndex = 1;
            this.btnYeni.Text = "Yeni Kayıt";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnDsil
            // 
            this.btnDsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDsil.Location = new System.Drawing.Point(372, 298);
            this.btnDsil.Name = "btnDsil";
            this.btnDsil.Size = new System.Drawing.Size(194, 69);
            this.btnDsil.TabIndex = 1;
            this.btnDsil.Text = "Düzelt/Sil";
            this.btnDsil.UseVisualStyleBackColor = true;
            this.btnDsil.Click += new System.EventHandler(this.btnDsil_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 406);
            this.Controls.Add(this.btnDsil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.dgvHastalar);
            this.Name = "FormAna";
            this.Text = "Hastane Otomasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.Load += new System.EventHandler(this.FormAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnDsil;
    }
}

