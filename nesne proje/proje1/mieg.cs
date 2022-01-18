using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace proje1
{
    public partial class mieg : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        public static DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public mieg()
        {
            InitializeComponent();
        }
        void vericek()
        {
            string sec = "select * from egzoz ";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "egzoz");

        }

        private void mieg_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            vericek();
            bs.DataSource = ds.Tables["egzoz"];
            dataGridView1.DataSource = bs;
            pictureBox1.DataBindings.Add("ImageLocation", bs, "resim");
        }

        

        private void bgd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.md.Show();
        }

        private void tbua_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from egzoz where stokadi like '%" + tbua.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "egzoz");
        }

        private void tbfa_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from egzoz where aciklama like '%" + tbfa.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "egzoz");
        }

        private void sesSistemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.mbkt.Show();
        }

        private void jantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.mj.Show();
        }

        private void egzozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.ms.Show();
        }

        private void diğerAksesuarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.mda.Show();
        }

        private void girişEkranınaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.Show();
        }

        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
