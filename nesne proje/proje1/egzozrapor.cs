using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace proje1
{
    public partial class egzozrapor : Form
    {
        public egzozrapor()
        {
            InitializeComponent();
        }

        private void egzozrapor_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSet2", egzoz.ds.Tables["egzoz"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bgeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.eg.Show();
        }

        private void bcık_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
