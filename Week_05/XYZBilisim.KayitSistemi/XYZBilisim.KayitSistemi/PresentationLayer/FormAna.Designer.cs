
namespace XYZBilisim.KayitSistemi
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
            this.dgvKursiyerler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursiyerler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKursiyerler
            // 
            this.dgvKursiyerler.AllowUserToAddRows = false;
            this.dgvKursiyerler.AllowUserToDeleteRows = false;
            this.dgvKursiyerler.AllowUserToResizeColumns = false;
            this.dgvKursiyerler.AllowUserToResizeRows = false;
            this.dgvKursiyerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursiyerler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKursiyerler.Location = new System.Drawing.Point(0, 0);
            this.dgvKursiyerler.MultiSelect = false;
            this.dgvKursiyerler.Name = "dgvKursiyerler";
            this.dgvKursiyerler.ReadOnly = true;
            this.dgvKursiyerler.RowHeadersVisible = false;
            this.dgvKursiyerler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKursiyerler.Size = new System.Drawing.Size(426, 150);
            this.dgvKursiyerler.TabIndex = 0;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 280);
            this.Controls.Add(this.dgvKursiyerler);
            this.Name = "FormAna";
            this.Text = "FormAna";
            this.Load += new System.EventHandler(this.FormAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursiyerler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKursiyerler;
    }
}

