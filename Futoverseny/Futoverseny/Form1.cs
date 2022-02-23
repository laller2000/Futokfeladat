using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Futoverseny
{
    public partial class Form1 : Form
    {
        List<Futok> futokLista = new List<Futok>();
        public Form1()
        {
            InitializeComponent();
        }

        private void megnyitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK==openFileDialog1.ShowDialog())
            {
                using (StreamReader olvas=new StreamReader(openFileDialog1.FileName))
                {
                    while (!olvas.EndOfStream)
                    {
                        Futok fut = new Futok(olvas.ReadLine());
                        futokLista.Add(fut);
                    }
                    olvas.Close();
                }
            }
        }

        private void button1_adatBe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < futokLista.Count; i++)
            {
                listBox1_Resztvevok.Items.Add(futokLista[i]);
            }
        }

        private void listBox1_Resztvevok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Futok full = (Futok)listBox1_Resztvevok.Items[listBox1_Resztvevok.SelectedIndex];
            textBox1_Rajtszam.Text = full.Rajtszam.ToString();
            textBox2_Orszag.Text = full.Orszag;
            textBox3_Ido.Text = full.Idoeredmeny;
            textBox4_eletkor.Text = full.Szuletesdatum.ToString();
        }

        private void button2_Bezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eredménylistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_eredmeny.Show();
        }
    }
}
