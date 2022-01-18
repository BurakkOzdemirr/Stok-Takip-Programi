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
    public partial class kullanici : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
     
        
        int kacincikayit;
        int baş;
        OleDbDataReader dr;
        public kullanici()
        {
            InitializeComponent();
        }
        void vericek()
        {
            string sec = "select * from kullaniciler";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "kullaniciler");
           
            dataGridView1.DataSource = bs;

        }

        private void kullanici_Load(object sender, EventArgs e)
        {
            
            bkaydet.Visible = biptal.Visible = false;
            if (con.State == ConnectionState.Closed) con.Open();

            vericek();
            bs.DataSource = ds.Tables["kullaniciler"];
            dataGridView1.DataSource = bs;
            tbtc.DataBindings.Add("Text", bs, "tckimlikno");
            tbad.DataBindings.Add("Text", bs, "ad");
            tbsoy.DataBindings.Add("Text", bs, "soyad");
            tbka.DataBindings.Add("Text", bs, "kullaniciadi");
            tbs.DataBindings.Add("Text", bs, "sifre");
            cbht.DataBindings.Add("Text", bs, "hesapturu");
            tbak.DataBindings.Add("Text", bs, "annekizlik");
            
            
        }

        private void by_Click(object sender, EventArgs e)
        {
            tbad.Clear();
            tbtc.Clear();
            tbsoy.Clear();
            tbka.Clear();
            tbs.Clear();
            tbak.Clear();
            tbtc.Focus();
            bkaydet.Visible = biptal.Visible = true;
            
            kacincikayit = ds.Tables["kullaniciler"].Rows.Count;
            
        }

        private void bd_Click(object sender, EventArgs e)
        {
            tbad.Focus();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "update kullaniciler set ad=@ad,soyad=@soy,kullaniciadi=@ka,sifre=@sif,hesapturu=@ht,annekizlik=@ak where tckimlikno=@tc";
            cmd.Parameters.AddWithValue("@ad", tbad.Text);
            cmd.Parameters.AddWithValue("@soy", tbsoy.Text);
            cmd.Parameters.AddWithValue("@ka", tbka.Text);
            cmd.Parameters.AddWithValue("@sif", tbs.Text);
            cmd.Parameters.AddWithValue("@ht", cbht.Text);
            cmd.Parameters.AddWithValue("@ak", tbak.Text);
            cmd.Parameters.AddWithValue("@tc", tbtc.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Düzeltildi.");
            vericek();
            kacincikayit = bs.Position;
        }

        private void bkaydet_Click(object sender, EventArgs e)
        {   
            if (tbad.Text == "" || tbak.Text == "" || tbka.Text == "" || tbs.Text == "" || tbsoy.Text == "" || tbtc.Text == "")
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            else
            {
                bkaydet.Visible = biptal.Visible = false;
                OleDbCommand cmd = new OleDbCommand();
                OleDbCommand cmd1 = new OleDbCommand();
                cmd.Connection = con;
                cmd1.Connection = con;
                cmd1.CommandText = "Select * from kullaniciler where tckimlikno=@tc1";
                cmd1.Parameters.AddWithValue("@tc1", tbtc.Text);
                dr = cmd1.ExecuteReader();
                if (dr.Read())
                { MessageBox.Show("Bu TC kimlik numarası ile daha önce kayıt yapılmış."); dr.Close(); tbtc.Clear(); bkaydet.Visible = biptal.Visible = true; }
                else
                {
                    dr.Close();
                    cmd.CommandText = "insert into kullaniciler (tckimlikno,ad,soyad,kullaniciadi,sifre,hesapturu,annekizlik) Values (@tc,@ad,@soy,@ka,@sif,@ht,@ak)";
                    cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                    cmd.Parameters.AddWithValue("@ad", tbad.Text);
                    cmd.Parameters.AddWithValue("@soy", tbsoy.Text);
                    cmd.Parameters.AddWithValue("@ka", tbka.Text);
                    cmd.Parameters.AddWithValue("@sif", tbs.Text);
                    cmd.Parameters.AddWithValue("@ht", cbht.Text);
                    cmd.Parameters.AddWithValue("@ak", tbak.Text);


                    string tc = tbtc.Text;
                    int a = tc.Length;
                    if (a == 11)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Gerçekleştirildi");
                        vericek();
                        bs.Position = kacincikayit;
                    }
                    else
                    {
                        tbtc.Clear();
                        MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.");
                        bkaydet.Visible = biptal.Visible = true;
                    }


                }
            }
            
           

        }

        private void bsil_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Eminmisiniz?", "Bilgi", MessageBoxButtons.YesNo);
            if (c == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from kullaniciler where tckimlikno=@tc";
                cmd.Parameters.AddWithValue("@tc", UInt64.Parse(tbtc.Text));
                cmd.ExecuteNonQuery();
                vericek();
                MessageBox.Show("Kaydınız Silindi");
            }
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            geri.Enabled = true;
            baş = ds.Tables["kullaniciler"].Rows.Count;
            bs.Position++;
            if (--baş == bs.Position)
                ileri.Enabled = false;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            ileri.Enabled = true;
            bs.Position--;
            if (0 == bs.Position)
                geri.Enabled = false;
        }

        private void biptal_Click(object sender, EventArgs e)
        {
            bkaydet.Visible = biptal.Visible = false; vericek();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from kullaniciler where tckimlikno like '%" + tcarama.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "kullaniciler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f4.ShowDialog();
        }

        private void aramad_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from kullaniciler where ad like '%" + aramad.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "kullaniciler");
        }

        private void tbtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            vericek();
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

       
    }
}
