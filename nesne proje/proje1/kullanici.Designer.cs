namespace proje1
{
    partial class kullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanici));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbak = new System.Windows.Forms.TextBox();
            this.cbht = new System.Windows.Forms.ComboBox();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.tbad = new System.Windows.Forms.TextBox();
            this.tbsoy = new System.Windows.Forms.TextBox();
            this.tbka = new System.Windows.Forms.TextBox();
            this.tbs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.Button();
            this.bd = new System.Windows.Forms.Button();
            this.bkaydet = new System.Windows.Forms.Button();
            this.biptal = new System.Windows.Forms.Button();
            this.bsil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ileri = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tcarama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aramad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbak);
            this.groupBox1.Controls.Add(this.cbht);
            this.groupBox1.Controls.Add(this.tbtc);
            this.groupBox1.Controls.Add(this.tbad);
            this.groupBox1.Controls.Add(this.tbsoy);
            this.groupBox1.Controls.Add(this.tbka);
            this.groupBox1.Controls.Add(this.tbs);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(102, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt İşlemleri";
            // 
            // tbak
            // 
            this.tbak.Location = new System.Drawing.Point(17, 187);
            this.tbak.Name = "tbak";
            this.tbak.Size = new System.Drawing.Size(119, 20);
            this.tbak.TabIndex = 7;
            // 
            // cbht
            // 
            this.cbht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbht.Items.AddRange(new object[] {
            "Yönetici",
            "Personel"});
            this.cbht.Location = new System.Drawing.Point(17, 217);
            this.cbht.Name = "cbht";
            this.cbht.Size = new System.Drawing.Size(121, 21);
            this.cbht.TabIndex = 6;
            // 
            // tbtc
            // 
            this.tbtc.Location = new System.Drawing.Point(17, 23);
            this.tbtc.MaxLength = 11;
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(119, 20);
            this.tbtc.TabIndex = 1;
            this.tbtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtc_KeyPress);
            // 
            // tbad
            // 
            this.tbad.Location = new System.Drawing.Point(17, 58);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(119, 20);
            this.tbad.TabIndex = 5;
            // 
            // tbsoy
            // 
            this.tbsoy.Location = new System.Drawing.Point(17, 91);
            this.tbsoy.Name = "tbsoy";
            this.tbsoy.Size = new System.Drawing.Size(119, 20);
            this.tbsoy.TabIndex = 4;
            // 
            // tbka
            // 
            this.tbka.Location = new System.Drawing.Point(17, 122);
            this.tbka.Name = "tbka";
            this.tbka.Size = new System.Drawing.Size(119, 20);
            this.tbka.TabIndex = 3;
            // 
            // tbs
            // 
            this.tbs.Location = new System.Drawing.Point(17, 151);
            this.tbs.Name = "tbs";
            this.tbs.PasswordChar = '*';
            this.tbs.Size = new System.Drawing.Size(119, 20);
            this.tbs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(66, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(55, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre :";
            // 
            // by
            // 
            this.by.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.by.Location = new System.Drawing.Point(6, 19);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(75, 23);
            this.by.TabIndex = 28;
            this.by.Text = "YENİ";
            this.by.UseVisualStyleBackColor = true;
            this.by.Click += new System.EventHandler(this.by_Click);
            // 
            // bd
            // 
            this.bd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bd.Location = new System.Drawing.Point(103, 35);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(75, 23);
            this.bd.TabIndex = 29;
            this.bd.Text = "DÜZELT";
            this.bd.UseVisualStyleBackColor = true;
            this.bd.Click += new System.EventHandler(this.bd_Click);
            // 
            // bkaydet
            // 
            this.bkaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bkaydet.Location = new System.Drawing.Point(214, 19);
            this.bkaydet.Name = "bkaydet";
            this.bkaydet.Size = new System.Drawing.Size(75, 23);
            this.bkaydet.TabIndex = 31;
            this.bkaydet.Text = "KAYDET";
            this.bkaydet.UseVisualStyleBackColor = true;
            this.bkaydet.Click += new System.EventHandler(this.bkaydet_Click);
            // 
            // biptal
            // 
            this.biptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.biptal.Location = new System.Drawing.Point(214, 54);
            this.biptal.Name = "biptal";
            this.biptal.Size = new System.Drawing.Size(75, 23);
            this.biptal.TabIndex = 32;
            this.biptal.Text = "İPTAL";
            this.biptal.UseVisualStyleBackColor = true;
            this.biptal.Click += new System.EventHandler(this.biptal_Click);
            // 
            // bsil
            // 
            this.bsil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bsil.Location = new System.Drawing.Point(6, 55);
            this.bsil.Name = "bsil";
            this.bsil.Size = new System.Drawing.Size(75, 23);
            this.bsil.TabIndex = 30;
            this.bsil.Text = "SİL";
            this.bsil.UseVisualStyleBackColor = true;
            this.bsil.Click += new System.EventHandler(this.bsil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.by);
            this.groupBox2.Controls.Add(this.bsil);
            this.groupBox2.Controls.Add(this.biptal);
            this.groupBox2.Controls.Add(this.bkaydet);
            this.groupBox2.Controls.Add(this.bd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(273, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 82);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // ileri
            // 
            this.ileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileri.Location = new System.Drawing.Point(362, 274);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(72, 23);
            this.ileri.TabIndex = 72;
            this.ileri.Text = "İleri";
            this.ileri.UseVisualStyleBackColor = true;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // geri
            // 
            this.geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.Location = new System.Drawing.Point(273, 274);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(73, 23);
            this.geri.TabIndex = 71;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Hesap Türü :";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(560, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Stok Eklemeye Git";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(709, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Anasayfaya Git";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tcarama
            // 
            this.tcarama.Location = new System.Drawing.Point(96, 20);
            this.tcarama.Name = "tcarama";
            this.tcarama.Size = new System.Drawing.Size(121, 20);
            this.tcarama.TabIndex = 76;
            this.tcarama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "TC Kimlik No:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aramad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tcarama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(599, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 82);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama";
            // 
            // aramad
            // 
            this.aramad.Location = new System.Drawing.Point(96, 54);
            this.aramad.Name = "aramad";
            this.aramad.Size = new System.Drawing.Size(121, 20);
            this.aramad.TabIndex = 79;
            this.aramad.TextChanged += new System.EventHandler(this.aramad_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(60, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Ad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(27, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 79;
            this.label8.Text = "Anne kızlık\r\n   soyadı:\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(273, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 153);
            this.groupBox4.TabIndex = 80;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kullanıcılar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(9, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(549, 130);
            this.dataGridView1.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tckimlikno";
            this.Column1.HeaderText = "TC Kimlik No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ad";
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soyad";
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "kullaniciadi";
            this.Column4.HeaderText = "Kullanıcı Adı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "hesapturu";
            this.Column5.HeaderText = "Hesap Türü";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "annekizlik";
            this.Column6.HeaderText = "Anne kızlık soyadı";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "sifre";
            this.Column7.HeaderText = "Şifre";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(695, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 81;
            this.checkBox1.Text = "Tümünü Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
            // 
            // kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(842, 304);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kullanici";
            this.Text = "Kullanıcı Ekleme";
            this.Load += new System.EventHandler(this.kullanici_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.TextBox tbad;
        private System.Windows.Forms.TextBox tbsoy;
        private System.Windows.Forms.TextBox tbka;
        private System.Windows.Forms.TextBox tbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button by;
        private System.Windows.Forms.Button bd;
        private System.Windows.Forms.Button bkaydet;
        private System.Windows.Forms.Button biptal;
        private System.Windows.Forms.Button bsil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tcarama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aramad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbht;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}