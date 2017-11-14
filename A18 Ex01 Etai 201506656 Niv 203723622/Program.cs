using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
