﻿using System;
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
    public partial class jant : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\proje1.mdb");
        public static DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        Boolean yenikayitmi;
        int baş;
        int kacincikayit;
        public jant()
        {
            InitializeComponent();
        }
        void vericek()
        {
            string sec = "select  j.*,kul.kullaniciadi from jant as j,kullaniciler as kul where j.tckimlikno=kul.tckimlikno";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            if (ds.Tables["jant"] != null)
                ds.Tables["jant"].Clear();
            da.Fill(ds, "jant");
            toolStripLabel1.Text = "Stok sayısı=" + ds.Tables["jant"].Rows.Count;

        }

        private void jant_Load(object sender, EventArgs e)
        {
            lka.Text = Form2.ka;
            tbsk.ReadOnly = true; tbekleyenka.ReadOnly = true;
            bkaydet.Visible = biptal.Visible = false;
            if (con.State == ConnectionState.Closed) con.Open();
            string sec = "select * from kullaniciler";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            da.Fill(ds, "kullaniciler");
            cbka.DataSource = ds.Tables["kullaniciler"];
            cbka.ValueMember = "tckimlikno";
            cbka.DisplayMember = "kullaniciadi";
            vericek();
            bs.DataSource = ds.Tables["jant"];
            dataGridView1.DataSource = bs;
            tbsk.DataBindings.Add("Text", bs, "stokkodu");
            tbsadi.DataBindings.Add("Text", bs, "stokadi");
            tbsadedi.DataBindings.Add("Text", bs, "stokadedi");
            tbekleyenka.DataBindings.Add("Text", bs, "kullaniciadi");
            dateTimePicker1.DataBindings.Add("Text", bs, "eklemetarihi");
            tbaciklama.DataBindings.Add("Text", bs, "aciklama");
            pictureBox1.DataBindings.Add("ImageLocation", bs, "resim");
            tbtf.DataBindings.Add("Text", bs, "tanefiyat");
            
        }

        private void by_Click(object sender, EventArgs e)
        {
            
            tbsadi.Focus();
            bkaydet.Visible = biptal.Visible = true;
            yenikayitmi = true;
            kacincikayit = ds.Tables["jant"].Rows.Count;
            pictureBox1.ImageLocation = "";
            tbekleyenka.ReadOnly = true;
            tbekleyenka.Text = Form2.ka;
        }

        private void bd_Click(object sender, EventArgs e)
        {
            tbekleyenka.ReadOnly = true;
            tbsadi.Focus();
            bkaydet.Visible = biptal.Visible = true;
            yenikayitmi = false;
            kacincikayit = bs.Position;
        }

        private void bkaydet_Click(object sender, EventArgs e)
        {
            bkaydet.Visible = biptal.Visible = false;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;

            if (yenikayitmi)
            {
                cmd.CommandText = "insert into jant (stokadi,stokadedi,tckimlikno,eklemetarihi,aciklama,resim,tanefiyat) Values (@sadi,@sadedi,@tc,@tarih,@aciklama,@resim,@tf)";
                cmd.Parameters.AddWithValue("@sadi", tbsadi.Text);
                cmd.Parameters.AddWithValue("@sadedi", (tbsadedi.Text).ToString());
                cmd.Parameters.AddWithValue("@tc", Form2.tc);
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@aciklama", tbaciklama.Text);
                cmd.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                cmd.Parameters.AddWithValue("@tf", tbtf.Text);
            }
            else
            {
                cmd.CommandText = "update jant set stokadi=@sa,stokadedi=@sadedi,eklemetarihi=@tarih,aciklama=@aciklama,resim=@resim,tanefiyat=@tf where stokkodu=@sk";
                
                cmd.Parameters.AddWithValue("@sa", tbsadi.Text);
                cmd.Parameters.AddWithValue("@sadedi", (tbsadedi.Text).ToString());
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@aciklama", tbaciklama.Text);
                cmd.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                cmd.Parameters.AddWithValue("@tf", tbtf.Text);
                cmd.Parameters.AddWithValue("@sk", int.Parse(tbsk.Text));
            }
            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt Gerçekleştirildi");
            vericek();
            bs.Position = kacincikayit;
        }

        private void bsil_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Emin misiniz?", "Bilgi", MessageBoxButtons.YesNo);
            if (c == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from jant where stokkodu=@sk";
                cmd.Parameters.AddWithValue("@sk", int.Parse(tbsk.Text));
                cmd.ExecuteNonQuery();
                vericek();
                MessageBox.Show("Kaydınız Silindi");
            }
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            geri.Enabled = true;
            baş = ds.Tables["jant"].Rows.Count;
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
            bkaydet.Visible = biptal.Visible = false;
            tbekleyenka.ReadOnly = false;
            vericek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resim\\";
            DialogResult c = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

       

        private void saarama_TextChanged(object sender, EventArgs e)
        {
            string sec = "select * from jant where stokadi like '%" + saarama.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            if (ds.Tables["jant"] != null)
                ds.Tables["jant"].Clear();
            da.Fill(ds, "jant");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { vericek();  saarama.Clear(); }
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void sesistemiStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.ss.Show();
        }

        private void egzozStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.eg.Show();
        }

        private void jantStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.bk.Show();
        }

        private void jantStoğunaGeçişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.ShowDialog();
        }

        private void sessistemiStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void braporla_Click(object sender, EventArgs e)
        {
            this.Hide();
            jantrapor jr = new jantrapor();
            jr.Show();
        }

        private void diğerAksesuarStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.dia.Show();
        }

        private void cbka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sec = "select  j.*,kul.kullaniciadi from jant as j,kullaniciler as kul where j.tckimlikno=kul.tckimlikno and j.tckimlikno='" + cbka.SelectedValue + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
                if (ds.Tables["jant"] != null)
                    ds.Tables["jant"].Clear();
                da.Fill(ds, "jant");
            }
            catch { }
        }

        private void tbsadedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
