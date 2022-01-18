namespace proje1
{
    partial class digeraksrapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(digeraksrapor));
            this.bgeri = new System.Windows.Forms.Button();
            this.bcık = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet5 = new proje1.DataSet5();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new proje1.DataSet5TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bgeri
            // 
            this.bgeri.Location = new System.Drawing.Point(668, 269);
            this.bgeri.Name = "bgeri";
            this.bgeri.Size = new System.Drawing.Size(81, 41);
            this.bgeri.TabIndex = 5;
            this.bgeri.Text = "Geri Dön";
            this.bgeri.UseVisualStyleBackColor = true;
            this.bgeri.Click += new System.EventHandler(this.bgeri_Click);
            // 
            // bcık
            // 
            this.bcık.Location = new System.Drawing.Point(765, 269);
            this.bcık.Name = "bcık";
            this.bcık.Size = new System.Drawing.Size(81, 41);
            this.bcık.TabIndex = 4;
            this.bcık.Text = "Programdan Çık";
            this.bcık.UseVisualStyleBackColor = true;
            this.bcık.Click += new System.EventHandler(this.bcık_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet5";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proje1.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(855, 263);
            this.reportViewer1.TabIndex = 6;
            // 
            // DataSet5
            // 
            this.DataSet5.DataSetName = "DataSet5";
            this.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet5;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // digeraksrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 313);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bgeri);
            this.Controls.Add(this.bcık);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(870, 352);
            this.MinimumSize = new System.Drawing.Size(870, 352);
            this.Name = "digeraksrapor";
            this.Text = "Diğer Aksesuar Raporlama";
            this.Load += new System.EventHandler(this.digeraksrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bgeri;
        private System.Windows.Forms.Button bcık;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet5 DataSet5;
        private DataSet5TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}