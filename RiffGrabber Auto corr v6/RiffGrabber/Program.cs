using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lbass_test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
              Application.Run(new rfg_mainwin());
            //       Application.Run(new rgr_main());
        
        }
    }
}
