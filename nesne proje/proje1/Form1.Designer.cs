namespace proje1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bmg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bkg = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // bmg
            // 
            this.bmg.BackColor = System.Drawing.Color.Transparent;
            this.bmg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmg.ForeColor = System.Drawing.Color.Black;
            this.bmg.Location = new System.Drawing.Point(289, 381);
            this.bmg.Name = "bmg";
            this.bmg.Size = new System.Drawing.Size(134, 35);
            this.bmg.TabIndex = 24;
            this.bmg.Text = "Misafir Girişi";
            this.toolTip1.SetToolTip(this.bmg, "Giriş yaparak elimizde olan \r\nürünleri,açıklamalarını ve \r\nfiyatlarını görebilirs" +
        "iniz.");
            this.bmg.UseVisualStyleBackColor = false;
            this.bmg.Click += new System.EventHandler(this.bmg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(138, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 100);
            this.label1.TabIndex = 23;
            this.label1.Text = "Araç Aksesuar Stok \r\n   Takip Programı";
            // 
            // bkg
            // 
            this.bkg.BackColor = System.Drawing.Color.Transparent;
            this.bkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bkg.ForeColor = System.Drawing.Color.Black;
            this.bkg.Location = new System.Drawing.Point(52, 381);
            this.bkg.Name = "bkg";
            this.bkg.Size = new System.Drawing.Size(134, 35);
            this.bkg.TabIndex = 22;
            this.bkg.Text = "Kullanıcı Girişi";
            this.toolTip1.SetToolTip(this.bkg, "Giriş yaparak stok ve kullanıcı \r\ndeğişikliği yapabilirsiniz.");
            this.bkg.UseVisualStyleBackColor = false;
            this.bkg.Click += new System.EventHandler(this.bkg_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.Color.Black;
            this.cikis.Location = new System.Drawing.Point(533, 381);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(134, 35);
            this.cikis.TabIndex = 25;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje1.Properties.Resources.asgf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 428);
            this.ControlBox = false;
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.bmg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bkg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(715, 467);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(715, 467);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bmg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bkg;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

