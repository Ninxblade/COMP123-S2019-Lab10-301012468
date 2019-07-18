using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301012468
{
    static class Program
    {
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM, new StartForm());
            Forms.Add(FormName.MAIN_FORM, new MainForm());
            Forms.Add(FormName.END_FORM, new EndForm());

            Application.Run(Forms[FormName.MAIN_FORM]);
        }
    }
}
