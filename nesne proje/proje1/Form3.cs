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
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        
        public Form3()
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

        private void button2_Click(object sender, EventArgs e)
        {OleDbCommand cmd1 = new OleDbCommand();
        if (con.State == ConnectionState.Closed) con.Open();
        cmd1.Connection = con;
            cmd1.CommandText = "update kullaniciler set sifre=@sf where tckimlikno=@tc";
            cmd1.Parameters.AddWithValue("@sf", tbys.Text);
            cmd1.Parameters.AddWithValue("@tc", tbtc.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Şifreniz değiştirilmiştir.");
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }
        

        

        private void Form3_Load(object sender, EventArgs e)
        {

            
            
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullaniciler where kullaniciadi='" + tbka.Text + "' AND tckimlikno='" + tbtc.Text + "' AND annekizlik='" + tbc.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               lys.Visible=true;
                tbys.Visible=true;
                kaydet.Visible=true;
                
            }
            else
                MessageBox.Show("Bilgilerinizi kontrol ediniz.");
            vericek();
        }

        private void geridön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f2.ShowDialog();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            tbc.Clear();
            tbka.Clear();
            tbtc.Clear();
            tbys.Clear();

            lys.Visible = false;
            tbys.Visible = false;
            kaydet.Visible = false;
        }
    }
}
