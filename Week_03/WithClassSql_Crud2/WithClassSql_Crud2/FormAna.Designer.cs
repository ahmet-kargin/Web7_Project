
namespace WithClassSql_Crud2
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
            this.btnHastalar = new System.Windows.Forms.Button();
            this.btnBolumler = new System.Windows.Forms.Button();
            this.btnDoktorlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastalar
            // 
            this.btnHastalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastalar.Location = new System.Drawing.Point(74, 38);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(286, 66);
            this.btnHastalar.TabIndex = 0;
            this.btnHastalar.Text = "HASTALAR";
            this.btnHastalar.UseVisualStyleBackColor = true;
            // 
            // btnBolumler
            // 
            this.btnBolumler.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumler.Location = new System.Drawing.Point(74, 120);
            this.btnBolumler.Name = "btnBolumler";
            this.btnBolumler.Size = new System.Drawing.Size(286, 66);
            this.btnBolumler.TabIndex = 0;
            this.btnBolumler.Text = "BÖLÜMLER";
            this.btnBolumler.UseVisualStyleBackColor = true;
            // 
            // btnDoktorlar
            // 
            this.btnDoktorlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorlar.Location = new System.Drawing.Point(74, 203);
            this.btnDoktorlar.Name = "btnDoktorlar";
            this.btnDoktorlar.Size = new System.Drawing.Size(286, 66);
            this.btnDoktorlar.TabIndex = 0;
            this.btnDoktorlar.Text = "DOKTORLAR";
            this.btnDoktorlar.UseVisualStyleBackColor = true;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 309);
            this.Controls.Add(this.btnDoktorlar);
            this.Controls.Add(this.btnBolumler);
            this.Controls.Add(this.btnHastalar);
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTANE OTOMASYONU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHastalar;
        private System.Windows.Forms.Button btnBolumler;
        private System.Windows.Forms.Button btnDoktorlar;
    }
}

