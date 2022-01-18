namespace proje1
{
    partial class mdgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdgiris));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbu = new System.Windows.Forms.ComboBox();
            this.lbla = new System.Windows.Forms.Label();
            this.bara = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(365, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // cbu
            // 
            this.cbu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbu.FormattingEnabled = true;
            this.cbu.Location = new System.Drawing.Point(199, 12);
            this.cbu.Name = "cbu";
            this.cbu.Size = new System.Drawing.Size(121, 21);
            this.cbu.TabIndex = 7;
            this.cbu.SelectedIndexChanged += new System.EventHandler(this.cbu_SelectedIndexChanged);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.BackColor = System.Drawing.Color.White;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbla.Location = new System.Drawing.Point(12, 15);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(178, 13);
            this.lbla.TabIndex = 8;
            this.lbla.Text = "Aradığınız ürün türünü seçiniz:";
            // 
            // bara
            // 
            this.bara.Location = new System.Drawing.Point(288, 48);
            this.bara.Name = "bara";
            this.bara.Size = new System.Drawing.Size(75, 23);
            this.bara.TabIndex = 9;
            this.bara.Text = "GİRİŞ";
            this.bara.UseVisualStyleBackColor = true;
            this.bara.Click += new System.EventHandler(this.bara_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mdgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje1.Properties.Resources.lamborghini_tail_light1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 108);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bara);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.cbu);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(421, 147);
            this.MinimumSize = new System.Drawing.Size(421, 147);
            this.Name = "mdgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Misafir Giriş";
            this.Activated += new System.EventHandler(this.mdgiris_Activated);
            this.Load += new System.EventHandler(this.mdgiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cbu;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Button bara;
        private System.Windows.Forms.Button button1;
    }
}