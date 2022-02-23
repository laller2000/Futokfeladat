using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futoverseny
{
    static class Program
    {
        public static Form form_eredmeny = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_eredmeny = new Form_Eredmeny();
            Application.Run(new Form1());
        }
    }
}
