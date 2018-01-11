using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Master
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
            var main_form = new FormMenu();
            main_form.StartPosition = FormStartPosition.Manual;
            main_form.Left = 0;
            main_form.Top = 0;
            main_form.Show();
            Application.Run();
        }
    }
}
