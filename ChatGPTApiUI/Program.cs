using System;
using System.Windows.Forms;

namespace ChatGPTApiUI {

    internal static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string appDataDir = "AppData";
            string filePath = System.IO.Path.Combine(appDataDir, "apikey.json");
            if(System.IO.File.Exists(filePath) && new System.IO.FileInfo(filePath).Length > 0) {
                Application.Run(new frm_main());
                return;
            }
            Application.Run(new frm_apikey());
        }
    }
}