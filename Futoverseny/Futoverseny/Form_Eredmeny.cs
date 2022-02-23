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
    public partial class Form_Eredmeny : Form
    {
        List<Futok> futokLISTA = new List<Futok>();
        public Form_Eredmeny()
        {
            InitializeComponent();
        }
        private void Form_Eredmeny_Load(object sender, EventArgs e)
        {
            using (StreamReader olvas=new StreamReader("futok.txt"))
            {
                while (!olvas.EndOfStream)
                {
                    Futok fut = new Futok(olvas.ReadLine());
                    futokLISTA.Add(fut);
                }
                olvas.Close();
            }
            for (int i = 0; i < futokLISTA.Count; i++)
            {
                listBox1_Eredmeny.Items.Add(futokLISTA[i].Nev);
                listBox1_Eredmeny.Items.Add(futokLISTA[i].Idoeredmeny);
                
            }
            
        }
        private void listBox1_Eredmeny_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var item in listBox1_Eredmeny.Items)
            {
                using (StreamWriter iras=new StreamWriter("EREDMENYEK.txt"))
                {
                    for (int i = 0; i <listBox1_Eredmeny.Items.Count; i++)
                    {
                        iras.WriteLine(listBox1_Eredmeny.Items[i]);
                    }
                    iras.Close();
                }
               
            }
        }

    }
}
