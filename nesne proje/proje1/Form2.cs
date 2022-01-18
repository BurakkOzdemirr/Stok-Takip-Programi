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
    public partial class Form2 : Form
    {
        public static string tc;
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        OleDbCommand cmd = new OleDbCommand();
        OleDbCommand cmd1 = new OleDbCommand();
        static public string ht;
        static public string ka;
        
        public Form2()
        {
            InitializeComponent();
        }
        void vericek()
        {
            string sec = "select * from kullaniciler";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "kullaniciler");
        }

        private void bi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1.f3.Show();
            
        }

        private void bg_Click(object sender, EventArgs e)
        {

            
            con.Open();
            cmd.Connection = con;
            cmd1.Connection = con;
            cmd.CommandText = "SELECT * FROM kullaniciler where  kullaniciadi='" + tbka.Text + "' AND sifre='" + tbs.Text + "'and tckimlikno";
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                tc = dr["tckimlikno"].ToString();
                cmd1.CommandText = "select from kullaniciler where hesapturu ";
                ht = dr["hesapturu"].ToString();
                ka = tbka.Text;

                this.Hide();
                Form1.f4.ShowDialog();
            }
            else
                MessageBox.Show("Bilgilerinizi kontrol ediniz.");
            vericek();
            dr.Close();
            con.Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vericek();
            
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bg.PerformClick();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            tbka.Clear();
            tbs.Clear();
            tbka.Focus();

        }
    }
}
