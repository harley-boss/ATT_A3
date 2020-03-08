using System;

using System.Windows.Forms;

namespace A3_MongoDB_hboss {
    static class MainLine {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new A3_Form());
        }
    }
}
