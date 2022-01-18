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
    public partial class Form4 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbCommand cmd = new OleDbCommand();
        
        static public string adı ;
        public Form4()
        {
            InitializeComponent();
        }
        void vericek()
        {
            
            OleDbDataAdapter da =new OleDbDataAdapter("select * from aksesuarstok",con);
            ds.Clear();
            da.Fill(ds, "aksesuarstok");
           }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            
            if (Form2.ht =="Yönetici")
                bka.Visible = true;
            else
                bka.Visible = false;

            con.Open();
           vericek();
            cbsm.DataSource = ds.Tables["aksesuarstok"];
            cbsm.DisplayMember = "stokadi";
            cbsm.ValueMember = "stokkodu";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (adı == "jant")
            {
                this.Hide();
                Form1.j.Show();
            }
            else if (adı == "bodykit")
            {
                this.Hide();
                Form1.bk.Show();
            }
            else if (adı == "sessistemi")
            {
                this.Hide();
                Form1.ss.Show();
            }
            else if (adı == "egzoz")
            {
                this.Hide();
               Form1.eg.Show();
            }
            else if (adı == "digeraks")
            {
                this.Hide();
                Form1.dia.Show();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void bka_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullanici k = new kullanici();
            k.Show();
        }

        
        private void cbsm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            adı = cbsm.Text ;
        }
    }
}
