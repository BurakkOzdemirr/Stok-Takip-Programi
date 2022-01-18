using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form1 : Form
    {
        static public Form2 f2 = new Form2();
        static public Form1 f1 = new Form1();
        static public Form3 f3 = new Form3();
        static public Form4 f4 = new Form4();
        static public bodykit bk = new bodykit();
        static public jant j=new jant();
        static public sessistemi ss = new sessistemi();
        static public egzoz eg = new egzoz();
        static public digeraks dia = new digeraks();
        static public mdgiris md = new mdgiris();
        static public mij mj = new mij();
        static public mibkt mbkt = new mibkt();
        static public miss ms = new miss();
        static public mieg me = new mieg();
        static public mida mda = new mida();
        public Form1()
        {
            InitializeComponent();
        }
         private void bkg_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            f2.Show();
          }

        private void cikis_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(c==DialogResult.Yes)
                Application.Exit();
        }

        private void bmg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.md.Show();

        }
    }
}
