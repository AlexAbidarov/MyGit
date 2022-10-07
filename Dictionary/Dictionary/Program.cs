using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Skins;

namespace Dictionary {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            SkinManager.EnableFormSkins();
            //DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Dictionary.mdb", false);
            if(path != string.Empty) {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                    string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User ID={1};Password={2}", path,
                    "Admin", ""), AutoCreateOption.DatabaseAndSchema);
                Application.Run(new frmMain());
            }
        }
    }
}