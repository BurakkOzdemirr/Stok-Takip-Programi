namespace proje1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.kaydet = new System.Windows.Forms.Button();
            this.tbys = new System.Windows.Forms.TextBox();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.lys = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbka = new System.Windows.Forms.TextBox();
            this.geridön = new System.Windows.Forms.Button();
            this.tamam = new System.Windows.Forms.Button();
            this.lgs = new System.Windows.Forms.Label();
            this.tbc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(217, 196);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(74, 23);
            this.kaydet.TabIndex = 23;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbys
            // 
            this.tbys.Location = new System.Drawing.Point(157, 159);
            this.tbys.Name = "tbys";
            this.tbys.PasswordChar = '*';
            this.tbys.Size = new System.Drawing.Size(110, 20);
            this.tbys.TabIndex = 21;
            // 
            // tbtc
            // 
            this.tbtc.Location = new System.Drawing.Point(157, 36);
            this.tbtc.MaxLength = 11;
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(110, 20);
            this.tbtc.TabIndex = 20;
            // 
            // lys
            // 
            this.lys.AutoSize = true;
            this.lys.BackColor = System.Drawing.SystemColors.Control;
            this.lys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lys.Location = new System.Drawing.Point(74, 162);
            this.lys.Name = "lys";
            this.lys.Size = new System.Drawing.Size(74, 13);
            this.lys.TabIndex = 19;
            this.lys.Text = "Yeni Şifre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "TC Kimlik Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // tbka
            // 
            this.tbka.Location = new System.Drawing.Point(157, 9);
            this.tbka.Name = "tbka";
            this.tbka.Size = new System.Drawing.Size(110, 20);
            this.tbka.TabIndex = 16;
            // 
            // geridön
            // 
            this.geridön.Location = new System.Drawing.Point(77, 99);
            this.geridön.Name = "geridön";
            this.geridön.Size = new System.Drawing.Size(74, 23);
            this.geridön.TabIndex = 37;
            this.geridön.Text = "Geri Dön";
            this.geridön.UseVisualStyleBackColor = true;
            this.geridön.Click += new System.EventHandler(this.geridön_Click);
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(193, 99);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(74, 23);
            this.tamam.TabIndex = 36;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // lgs
            // 
            this.lgs.AutoSize = true;
            this.lgs.BackColor = System.Drawing.SystemColors.Control;
            this.lgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lgs.Location = new System.Drawing.Point(12, 67);
            this.lgs.Name = "lgs";
            this.lgs.Size = new System.Drawing.Size(139, 13);
            this.lgs.TabIndex = 34;
            this.lgs.Text = "Annenizin kızlık soyadı:";
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(157, 64);
            this.tbc.Name = "tbc";
            this.tbc.Size = new System.Drawing.Size(110, 20);
            this.tbc.TabIndex = 32;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje1.Properties.Resources.IMG_0405;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 234);
            this.ControlBox = false;
            this.Controls.Add(this.geridön);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.lgs);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.tbys);
            this.Controls.Add(this.tbtc);
            this.Controls.Add(this.lys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox tbys;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.Label lys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbka;
        private System.Windows.Forms.Button geridön;
        private System.Windows.Forms.Button tamam;
        private System.Windows.Forms.Label lgs;
        private System.Windows.Forms.TextBox tbc;
    }
}