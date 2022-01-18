namespace proje1
{
    partial class sessistrapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sessistrapor));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet4 = new proje1.DataSet4();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new proje1.DataSet4TableAdapters.DataTable1TableAdapter();
            this.bgeri = new System.Windows.Forms.Button();
            this.bcık = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet4";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proje1.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet4;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // bgeri
            // 
            this.bgeri.Location = new System.Drawing.Point(599, 252);
            this.bgeri.Name = "bgeri";
            this.bgeri.Size = new System.Drawing.Size(81, 36);
            this.bgeri.TabIndex = 4;
            this.bgeri.Text = "Geri Dön";
            this.bgeri.UseVisualStyleBackColor = true;
            this.bgeri.Click += new System.EventHandler(this.bgeri_Click);
            // 
            // bcık
            // 
            this.bcık.Location = new System.Drawing.Point(686, 252);
            this.bcık.Name = "bcık";
            this.bcık.Size = new System.Drawing.Size(81, 36);
            this.bcık.TabIndex = 3;
            this.bcık.Text = "Programdan Çık";
            this.bcık.UseVisualStyleBackColor = true;
            this.bcık.Click += new System.EventHandler(this.bcık_Click);
            // 
            // sessistrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 300);
            this.ControlBox = false;
            this.Controls.Add(this.bgeri);
            this.Controls.Add(this.bcık);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(795, 339);
            this.MinimumSize = new System.Drawing.Size(795, 339);
            this.Name = "sessistrapor";
            this.Text = "Ses Sistemi Raporlama";
            this.Load += new System.EventHandler(this.sessistrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button bgeri;
        private System.Windows.Forms.Button bcık;
    }
}