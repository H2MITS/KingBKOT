using Cindy_Restaurant;
using Cindy_Restaurant.Form_View;
using Cindy_Restaurant.Forms;
using KingBarbeque;
using KingBarbeque.Forms;
using KingBKOT.Form_View;
using KingBKOT.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace KingBKOT
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
            Application.Run(new frmSplash());
        }
    }
}
