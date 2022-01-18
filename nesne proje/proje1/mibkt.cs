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
    public partial class mibkt : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        public static DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        
        public mibkt()
        {
            InitializeComponent();
        }
        void vericek()
        {
            string sec = "select * from bodykit ";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "bodykit");

        }

        private void mibkt_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            vericek();
            bs.DataSource = ds.Tables["bodykit"];
            dataGridView1.DataSource = bs;
            pictureBox1.DataBindings.Add("ImageLocation", bs, "resim");
            
        }

        private void tbua_TextChanged_1(object sender, EventArgs e)
        {
            string sec = "select * from bodykit where stokadi like '%" + tbua.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "bodykit");
        }

        private void tbfa_TextChanged_1(object sender, EventArgs e)
        {
            string sec = "select * from bodykit where aciklama like '%" + tbfa.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "bodykit");
        }

        private void bgd_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1.md.Show();
        }

        

        private void sesSistemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.ms.Show();
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
            Form1.mda.Show();
        }

        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girişEkranınaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.Show();
        }
 
    }
}
