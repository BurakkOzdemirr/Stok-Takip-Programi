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
    public partial class mida : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        public static DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public mida()
        {
            InitializeComponent();
        }
        void vericek()
        {
            string sec = "select * from digeraks ";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "digeraks");

        }
        private void mida_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            vericek();
            bs.DataSource = ds.Tables["digeraks"];
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
            string sec = "select * from digeraks where stokadi like '%" + tbua.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "digeraks");
        }

        private void tbfa_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from digeraks where aciklama like '%" + tbfa.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "digeraks");
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
            Form1.me.Show();
        }

        private void diğerAksesuarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1.ms.Show();
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
