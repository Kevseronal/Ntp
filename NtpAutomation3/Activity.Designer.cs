namespace NtpAutomation3
{
    partial class Activity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity));
            this.dgwEvents = new System.Windows.Forms.DataGridView();
            this.cbxFree = new System.Windows.Forms.ComboBox();
            this.cbxFaculty = new System.Windows.Forms.ComboBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblFree = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnCbxRemove = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwEvents
            // 
            this.dgwEvents.BackgroundColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwEvents.Location = new System.Drawing.Point(39, 299);
            this.dgwEvents.Name = "dgwEvents";
            this.dgwEvents.RowTemplate.Height = 24;
            this.dgwEvents.Size = new System.Drawing.Size(1309, 464);
            this.dgwEvents.TabIndex = 0;
            this.dgwEvents.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwEvents_CellMouseDoubleClick_1);
            // 
            // cbxFree
            // 
            this.cbxFree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFree.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFree.FormattingEnabled = true;
            this.cbxFree.Items.AddRange(new object[] {
            "Ücretsiz",
            "Ücretli"});
            this.cbxFree.Location = new System.Drawing.Point(178, 58);
            this.cbxFree.Name = "cbxFree";
            this.cbxFree.Size = new System.Drawing.Size(202, 32);
            this.cbxFree.TabIndex = 1;
            // 
            // cbxFaculty
            // 
            this.cbxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFaculty.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFaculty.FormattingEnabled = true;
            this.cbxFaculty.Items.AddRange(new object[] {
            "Hemşirelik Fakültesi",
            "Edebiyat Fakültesi",
            "Eczacılık Fakültesi",
            "Eğitim Fakültesi",
            "Fen Fakültesi",
            "İletişim Fakültesi",
            "Mühendislik Fakültesi",
            "Spor Bilimleri Fakültesi",
            "Tıp Fakültesi"});
            this.cbxFaculty.Location = new System.Drawing.Point(178, 117);
            this.cbxFaculty.Name = "cbxFaculty";
            this.cbxFaculty.Size = new System.Drawing.Size(202, 32);
            this.cbxFaculty.TabIndex = 2;
            this.cbxFaculty.SelectedIndexChanged += new System.EventHandler(this.cbxFaculty_SelectedIndexChanged);
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Alman Dili ve Edebiyatı",
            "Almanca Mütercim ve Tercümanlık",
            "Amerikan Kültürü ve Edebiyatı",
            "Astronomi ve Uzay Bilimleri",
            "Bahçe Bitkileri",
            "Beslenme ve Diyetetik",
            "Bilgisayar Mühendisliği",
            "Bilgisayar ve Öğrenim Teknolojileri",
            "Bitki Koruma",
            "Biyokimya",
            "Biyoloji",
            "Biyomühendislik",
            "Coğrafya",
            "Çocuk Gelişimi",
            "Deri Mühendisliği",
            "Diş Hekimliği",
            "Ebelik",
            "Eczacılık",
            "Elektrik Elektronik Mühendisliği",
            "Felsefe",
            "Fen Bilgisi Öğretmenliği",
            "Fizik",
            "Fizyoterapi ve Rehabilitasyon",
            "Gazetecilik",
            "Gıda Mühendisliği",
            "Görsel İletişim Tasarımı",
            "Halkla İlişkiler ve Tanıtım",
            "Hemşirelik",
            "İktisat",
            "İngiliz Dili ve Edebiyatı",
            "İngilizce Mütercim ve Tercümanlık",
            "İnşaat Mühendisliği",
            "İslami Dinler",
            "İstatistik",
            "İşletme",
            "Kimya",
            "Kimya Mühendisliği",
            "Klasik Arkeoloji",
            "Makine Mühendisliği",
            "Matematik",
            "Moda Tasarımı",
            "Okul Öncesi Öğretmenliği",
            "Özel Eğitim Öğretmenliği",
            "Peyzaj Mimarlığı",
            "Protohistorya ve Ön Asya Arkeolojisi",
            "Psikoloji",
            "Radyo, Televizyon ve Sinema",
            "Rehberlik ve Psikolojik Danışmanlık",
            "Reklamcılık",
            "Sanat Tarihi",
            "Sınıf Öğretmenliği",
            "Sosyal Bilgiler Öğretmenliği",
            "Sosyoloji",
            "Su Ürünleri Mühendisliği",
            "Süt Teknolojisi",
            "Tarım Ekonomisi",
            "Tarım Makineleri ve Teknolojileri",
            "Tarımsal Yapılar ve Sulama",
            "Tarih",
            "Tarla Bitkileri",
            "Tekstil Mühendisliği",
            "Tıp",
            "Toprak Bilimi ve Bitki Besleme",
            "Turizm İşletmeciliği",
            "Turizm Rehberliği",
            "Türk Dili ve Edebiyatı",
            "Türkçe Öğretmenliği",
            "Uluslararası İlişkiler",
            "Zootekni"});
            this.cbxDepartment.Location = new System.Drawing.Point(178, 176);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(202, 32);
            this.cbxDepartment.TabIndex = 3;
            // 
            // lblFree
            // 
            this.lblFree.AutoSize = true;
            this.lblFree.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFree.Location = new System.Drawing.Point(83, 61);
            this.lblFree.Name = "lblFree";
            this.lblFree.Size = new System.Drawing.Size(72, 24);
            this.lblFree.TabIndex = 4;
            this.lblFree.Text = "Ücret : ";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaculty.Location = new System.Drawing.Point(67, 120);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(88, 24);
            this.lblFaculty.TabIndex = 5;
            this.lblFaculty.Text = "Fakülte : ";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartment.Location = new System.Drawing.Point(75, 179);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(80, 24);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "Bölüm : ";
            // 
            // btnCbxRemove
            // 
            this.btnCbxRemove.BackColor = System.Drawing.Color.Gold;
            this.btnCbxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCbxRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCbxRemove.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCbxRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnCbxRemove.Image")));
            this.btnCbxRemove.Location = new System.Drawing.Point(178, 228);
            this.btnCbxRemove.Name = "btnCbxRemove";
            this.btnCbxRemove.Size = new System.Drawing.Size(81, 35);
            this.btnCbxRemove.TabIndex = 7;
            this.btnCbxRemove.UseVisualStyleBackColor = false;
            this.btnCbxRemove.Click += new System.EventHandler(this.btnCbxRemove_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Gold;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilter.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.Location = new System.Drawing.Point(287, 228);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(93, 35);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(445, 176);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(148, 29);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Etkinlik Ara : ";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(599, 173);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(268, 36);
            this.tbxSearch.TabIndex = 10;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(599, 225);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(115, 35);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(758, 228);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 35);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(954, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1331, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1386, 789);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnCbxRemove);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblFree);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.cbxFaculty);
            this.Controls.Add(this.cbxFree);
            this.Controls.Add(this.dgwEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Activity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEvents;
        private System.Windows.Forms.ComboBox cbxFree;
        private System.Windows.Forms.ComboBox cbxFaculty;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label lblFree;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnCbxRemove;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}