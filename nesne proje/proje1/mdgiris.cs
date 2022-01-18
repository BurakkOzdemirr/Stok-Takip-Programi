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
    public partial class mdgiris : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbCommand cmd = new OleDbCommand();
        static public string adı;
        int c = 1;
        public mdgiris()
        {
            InitializeComponent();
        }
        void vericek()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("select * from aksesuarstok", con);
            ds.Clear();
            da.Fill(ds, "aksesuarstok");
        }

        private void mdgiris_Load(object sender, EventArgs e)
        {
            
            lbla.Visible = false; bara.Visible = false; cbu.Visible = false;
            con.Open();
            vericek();
            cbu.DataSource = ds.Tables["aksesuarstok"];
            cbu.DisplayMember = "stokadi";
            cbu.ValueMember = "stokkodu";
            con.Close();
            }

        private void mdgiris_Activated(object sender, EventArgs e)
        {
            if (c == 1)
            {
                
                c++;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
                for (int i = 1; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    System.Threading.Thread.Sleep(20);
                }

                lbla.Visible = true; bara.Visible = true; cbu.Visible = true; progressBar1.Visible = false; 
            }
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.Show();
        }

        private void cbu_SelectedIndexChanged(object sender, EventArgs e)
        {
            adı = cbu.Text;
        }

        private void bara_Click(object sender, EventArgs e)
        {
            if (adı == "Jant")
            {
                this.Hide();
                Form1.mj.Show();
            }
            else if (adı == "Bodykit")
            {
                this.Hide();
                Form1.mbkt.Show();
            }
            else if (adı == "Ses Sistemi")
            {
                this.Hide();
                Form1.ms.Show();
            }
            else if (adı == "Egzoz")
            {
                this.Hide();
                Form1.me.Show();
            }
            else if (adı == "Diğer Aksesuarlar")
            {
                this.Hide();
                Form1.mda.Show();
            }
        }
    }
}
