
namespace PersonelTakipUygulamasi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbDurumu = new System.Windows.Forms.ComboBox();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.lblDurumu = new System.Windows.Forms.Label();
            this.dtpIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblIseBaslamaTarihi = new System.Windows.Forms.Label();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.rdbTam = new System.Windows.Forms.RadioButton();
            this.rdbIceren = new System.Windows.Forms.RadioButton();
            this.rdbBaslangic = new System.Windows.Forms.RadioButton();
            this.pnlAraclar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.pnlButonlar.SuspendLayout();
            this.pnlAraclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.BackColor = System.Drawing.Color.Silver;
            this.btnHepsiniSil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.ForeColor = System.Drawing.Color.Teal;
            this.btnHepsiniSil.Location = new System.Drawing.Point(301, 49);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(126, 34);
            this.btnHepsiniSil.TabIndex = 0;
            this.btnHepsiniSil.Text = "HEPSİNİ SİL";
            this.btnHepsiniSil.UseVisualStyleBackColor = false;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnGuncelle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Teal;
            this.btnGuncelle.Location = new System.Drawing.Point(219, 9);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(208, 34);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbDurumu
            // 
            this.cmbDurumu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDurumu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDurumu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurumu.FormattingEnabled = true;
            this.cmbDurumu.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbDurumu.Location = new System.Drawing.Point(184, 273);
            this.cmbDurumu.Name = "cmbDurumu";
            this.cmbDurumu.Size = new System.Drawing.Size(243, 27);
            this.cmbDurumu.TabIndex = 8;
            this.cmbDurumu.Tag = "Durumu";
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbUnvan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnvan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] {
            "İşçi",
            "Ekip Lideri",
            "Yönetici Yardımcısı",
            "Yönetici"});
            this.cmbUnvan.Location = new System.Drawing.Point(184, 240);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(243, 27);
            this.cmbUnvan.TabIndex = 7;
            this.cmbUnvan.Tag = "Unvan";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDepartman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartman.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Muhasebe",
            "Satış",
            "Üretim",
            "Teknik"});
            this.cmbDepartman.Location = new System.Drawing.Point(184, 207);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(243, 27);
            this.cmbDepartman.TabIndex = 6;
            this.cmbDepartman.Tag = "Departman";
            // 
            // lblDurumu
            // 
            this.lblDurumu.BackColor = System.Drawing.Color.DimGray;
            this.lblDurumu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurumu.ForeColor = System.Drawing.Color.White;
            this.lblDurumu.Location = new System.Drawing.Point(8, 272);
            this.lblDurumu.Name = "lblDurumu";
            this.lblDurumu.Size = new System.Drawing.Size(170, 26);
            this.lblDurumu.TabIndex = 0;
            this.lblDurumu.Text = "DURUMU";
            this.lblDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpIseBaslamaTarihi
            // 
            this.dtpIseBaslamaTarihi.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpIseBaslamaTarihi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpIseBaslamaTarihi.Location = new System.Drawing.Point(184, 174);
            this.dtpIseBaslamaTarihi.Name = "dtpIseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.Size = new System.Drawing.Size(243, 26);
            this.dtpIseBaslamaTarihi.TabIndex = 5;
            this.dtpIseBaslamaTarihi.Tag = "IseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.ValueChanged += new System.EventHandler(this.dtpIseBaslamaTarihi_ValueChanged);
            // 
            // lblUnvan
            // 
            this.lblUnvan.BackColor = System.Drawing.Color.DimGray;
            this.lblUnvan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan.ForeColor = System.Drawing.Color.White;
            this.lblUnvan.Location = new System.Drawing.Point(8, 239);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(170, 26);
            this.lblUnvan.TabIndex = 0;
            this.lblUnvan.Text = "ÜNVAN";
            this.lblUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogumTarihi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogumTarihi.Location = new System.Drawing.Point(184, 142);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(243, 26);
            this.dtpDogumTarihi.TabIndex = 4;
            this.dtpDogumTarihi.Tag = "DogumTarihi";
            this.dtpDogumTarihi.ValueChanged += new System.EventHandler(this.dtpDogumTarihi_ValueChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Silver;
            this.btnTemizle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Teal;
            this.btnTemizle.Location = new System.Drawing.Point(155, 49);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(126, 34);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Teal;
            this.btnSil.Location = new System.Drawing.Point(9, 49);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 34);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.Silver;
            this.btnGetir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.Teal;
            this.btnGetir.Location = new System.Drawing.Point(9, 89);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(204, 34);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lblDepartman
            // 
            this.lblDepartman.BackColor = System.Drawing.Color.DimGray;
            this.lblDepartman.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.ForeColor = System.Drawing.Color.White;
            this.lblDepartman.Location = new System.Drawing.Point(8, 206);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(170, 26);
            this.lblDepartman.TabIndex = 0;
            this.lblDepartman.Text = "DEPARTMAN";
            this.lblDepartman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIseBaslamaTarihi
            // 
            this.lblIseBaslamaTarihi.BackColor = System.Drawing.Color.DimGray;
            this.lblIseBaslamaTarihi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIseBaslamaTarihi.ForeColor = System.Drawing.Color.White;
            this.lblIseBaslamaTarihi.Location = new System.Drawing.Point(8, 174);
            this.lblIseBaslamaTarihi.Name = "lblIseBaslamaTarihi";
            this.lblIseBaslamaTarihi.Size = new System.Drawing.Size(170, 26);
            this.lblIseBaslamaTarihi.TabIndex = 0;
            this.lblIseBaslamaTarihi.Text = "İŞE BAŞLAMA TARİHİ";
            this.lblIseBaslamaTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelNo.Location = new System.Drawing.Point(184, 109);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(243, 26);
            this.txtPersonelNo.TabIndex = 3;
            this.txtPersonelNo.Tag = "PersonelNo";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.BackColor = System.Drawing.Color.DimGray;
            this.lblPersonelNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.ForeColor = System.Drawing.Color.White;
            this.lblPersonelNo.Location = new System.Drawing.Point(8, 108);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(170, 26);
            this.lblPersonelNo.TabIndex = 0;
            this.lblPersonelNo.Text = "PERSONEL NO";
            this.lblPersonelNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Silver;
            this.btnBul.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.Color.Teal;
            this.btnBul.Location = new System.Drawing.Point(223, 89);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(204, 34);
            this.btnBul.TabIndex = 0;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Silver;
            this.btnKaydet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Teal;
            this.btnKaydet.Location = new System.Drawing.Point(9, 9);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(204, 34);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.BackColor = System.Drawing.Color.DimGray;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.ForeColor = System.Drawing.Color.White;
            this.lblDogumTarihi.Location = new System.Drawing.Point(8, 142);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(170, 26);
            this.lblDogumTarihi.TabIndex = 0;
            this.lblDogumTarihi.Text = "DOĞUM TARİHİ";
            this.lblDogumTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.AllowUserToAddRows = false;
            this.dgvCalisanlar.AllowUserToDeleteRows = false;
            this.dgvCalisanlar.AllowUserToResizeColumns = false;
            this.dgvCalisanlar.AllowUserToResizeRows = false;
            this.dgvCalisanlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCalisanlar.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalisanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.EnableHeadersVisualStyles = false;
            this.dgvCalisanlar.Location = new System.Drawing.Point(461, 117);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.ReadOnly = true;
            this.dgvCalisanlar.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvCalisanlar.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlar.Size = new System.Drawing.Size(518, 475);
            this.dgvCalisanlar.TabIndex = 7;
            this.dgvCalisanlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellEnter);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(184, 77);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(243, 26);
            this.txtTcNo.TabIndex = 2;
            this.txtTcNo.Tag = "TcNo";
            // 
            // lblTcNo
            // 
            this.lblTcNo.BackColor = System.Drawing.Color.DimGray;
            this.lblTcNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.ForeColor = System.Drawing.Color.White;
            this.lblTcNo.Location = new System.Drawing.Point(8, 76);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(170, 26);
            this.lblTcNo.TabIndex = 0;
            this.lblTcNo.Text = "TC KİMLİK NO";
            this.lblTcNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(184, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(243, 26);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Tag = "Soyad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.BackColor = System.Drawing.Color.DimGray;
            this.lblSoyad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.White;
            this.lblSoyad.Location = new System.Drawing.Point(8, 44);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(170, 26);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "SOYADI";
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(184, 13);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(243, 26);
            this.txtAd.TabIndex = 0;
            this.txtAd.Tag = "Ad";
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.Color.DimGray;
            this.lblAd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(8, 12);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(170, 26);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "ADI";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(9, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(967, 98);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wissen Akademie - PERSONEL TAKİP UYGULAMASI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButonlar.Controls.Add(this.rdbTam);
            this.pnlButonlar.Controls.Add(this.rdbIceren);
            this.pnlButonlar.Controls.Add(this.rdbBaslangic);
            this.pnlButonlar.Controls.Add(this.btnHepsiniSil);
            this.pnlButonlar.Controls.Add(this.btnBul);
            this.pnlButonlar.Controls.Add(this.btnGuncelle);
            this.pnlButonlar.Controls.Add(this.btnTemizle);
            this.pnlButonlar.Controls.Add(this.btnSil);
            this.pnlButonlar.Controls.Add(this.btnGetir);
            this.pnlButonlar.Controls.Add(this.btnKaydet);
            this.pnlButonlar.Controls.Add(this.button3);
            this.pnlButonlar.Location = new System.Drawing.Point(15, 436);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(439, 156);
            this.pnlButonlar.TabIndex = 6;
            // 
            // rdbTam
            // 
            this.rdbTam.AutoSize = true;
            this.rdbTam.Checked = true;
            this.rdbTam.Location = new System.Drawing.Point(339, 129);
            this.rdbTam.Name = "rdbTam";
            this.rdbTam.Size = new System.Drawing.Size(88, 17);
            this.rdbTam.TabIndex = 2;
            this.rdbTam.TabStop = true;
            this.rdbTam.Text = "Tam Eşleşme";
            this.rdbTam.UseVisualStyleBackColor = true;
            // 
            // rdbIceren
            // 
            this.rdbIceren.AutoSize = true;
            this.rdbIceren.Location = new System.Drawing.Point(261, 130);
            this.rdbIceren.Name = "rdbIceren";
            this.rdbIceren.Size = new System.Drawing.Size(55, 17);
            this.rdbIceren.TabIndex = 2;
            this.rdbIceren.Text = "İçeren";
            this.rdbIceren.UseVisualStyleBackColor = true;
            // 
            // rdbBaslangic
            // 
            this.rdbBaslangic.AutoSize = true;
            this.rdbBaslangic.Location = new System.Drawing.Point(157, 129);
            this.rdbBaslangic.Name = "rdbBaslangic";
            this.rdbBaslangic.Size = new System.Drawing.Size(73, 17);
            this.rdbBaslangic.TabIndex = 2;
            this.rdbBaslangic.Text = "Başlangıcı";
            this.rdbBaslangic.UseVisualStyleBackColor = true;
            // 
            // pnlAraclar
            // 
            this.pnlAraclar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAraclar.Controls.Add(this.cmbDurumu);
            this.pnlAraclar.Controls.Add(this.cmbUnvan);
            this.pnlAraclar.Controls.Add(this.cmbDepartman);
            this.pnlAraclar.Controls.Add(this.lblDurumu);
            this.pnlAraclar.Controls.Add(this.dtpIseBaslamaTarihi);
            this.pnlAraclar.Controls.Add(this.lblUnvan);
            this.pnlAraclar.Controls.Add(this.dtpDogumTarihi);
            this.pnlAraclar.Controls.Add(this.lblDepartman);
            this.pnlAraclar.Controls.Add(this.lblIseBaslamaTarihi);
            this.pnlAraclar.Controls.Add(this.txtPersonelNo);
            this.pnlAraclar.Controls.Add(this.lblDogumTarihi);
            this.pnlAraclar.Controls.Add(this.lblPersonelNo);
            this.pnlAraclar.Controls.Add(this.txtTcNo);
            this.pnlAraclar.Controls.Add(this.lblTcNo);
            this.pnlAraclar.Controls.Add(this.txtSoyad);
            this.pnlAraclar.Controls.Add(this.lblSoyad);
            this.pnlAraclar.Controls.Add(this.txtAd);
            this.pnlAraclar.Controls.Add(this.lblAd);
            this.pnlAraclar.Location = new System.Drawing.Point(15, 117);
            this.pnlAraclar.Name = "pnlAraclar";
            this.pnlAraclar.Size = new System.Drawing.Size(439, 312);
            this.pnlAraclar.TabIndex = 5;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 604);
            this.Controls.Add(this.dgvCalisanlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlButonlar);
            this.Controls.Add(this.pnlAraclar);
            this.Name = "FormAna";
            this.Text = "Personel Takip Uygulaması";
            this.Load += new System.EventHandler(this.FormAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.pnlButonlar.ResumeLayout(false);
            this.pnlButonlar.PerformLayout();
            this.pnlAraclar.ResumeLayout(false);
            this.pnlAraclar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbDurumu;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label lblDurumu;
        private System.Windows.Forms.DateTimePicker dtpIseBaslamaTarihi;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblIseBaslamaTarihi;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.Panel pnlAraclar;
        private System.Windows.Forms.RadioButton rdbTam;
        private System.Windows.Forms.RadioButton rdbIceren;
        private System.Windows.Forms.RadioButton rdbBaslangic;
    }
}

