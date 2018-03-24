using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
//using System.Globalization;
//using System.Threading;

namespace vivaprocess
{
    static class Program
    {
        public static frmMain frmMain;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.frmMain = new frmMain();

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            IniFile file = new IniFile(Application.StartupPath.ToString() + "\\vivaprocess.ini");
            vivaprocess.Global.user_this = "admin";
            vivaprocess.Global.station_type = file.ReadString("General", "station_type");
            vivaprocess.Global.ora_serv = file.ReadString("General", "ora_serv");
            vivaprocess.Global.ora_user = "kuhni_modul";
            vivaprocess.Global.ora_pass = "kuhni";
            vivaprocess.Global.zakazReklamac = "";
            vivaprocess.Global.vse = 1;
            vivaprocess.Global.slegFlag = 0;
            //vivaprocess.Global.rptStart = "01.02.2017";
            /*CultureInfo culture = new CultureInfo("ru-RU", false);
            culture.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;*/
            Application.Run(Program.frmMain);
        }
    }
    public class Global
    {
        public static string station_type, user_this, prava; //type: server or workstation/work place, user this programm
        public static int flagExit, vse, slegFlag; //flag
        public static string slegDate, slegNN;
        public static string ora_serv, ora_user, ora_pass; //db oracle from tns
        public static string path_zip, path_now, path_arc; //path for work
        public static string rptStart, rptEnd, rptClient, zakazReklamac, zakazReklamacD, zakazReklamacC, zakazReklamacCl, rptMaterial;
    }
    /// <summary>
    /// Class to read from INI files. Based loosely on the Delphi class of the same name.
    /// </summary>
    public class IniFile
    {
        private string fileName;

        /// <summary>
        /// Creates a new <see cref="IniFile"/> instance.
        /// </summary>
        /// <param name="fileName">Name of the INI file.</param>
        public IniFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException(fileName + " does not exist", fileName);
            this.fileName = fileName;
        }

        // native methods
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
          string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileSection(string section, IntPtr lpReturnedString,
          int nSize, string lpFileName);

        /// <summary>
        /// Reads a string value from the INI file.
        /// </summary>
        /// <param name="section">Section to read.</param>
        /// <param name="key">Key to read.</param>
        public string ReadString(string section, string key)
        {
            const int bufferSize = 255;
            StringBuilder temp = new StringBuilder(bufferSize);
            GetPrivateProfileString(section, key, "", temp, bufferSize, fileName);
            return temp.ToString();
        }

        /// <summary>
        /// Reads a whole section of the INI file.
        /// </summary>
        /// <param name="section">Section to read.</param>
        public string[] ReadSection(string section)
        {
            const int bufferSize = 2048;

            StringBuilder returnedString = new StringBuilder();

            IntPtr pReturnedString = Marshal.AllocCoTaskMem(bufferSize);
            try
            {
                int bytesReturned = GetPrivateProfileSection(section, pReturnedString, bufferSize, fileName);

                //bytesReturned -1 to remove trailing \0
                for (int i = 0; i < bytesReturned - 1; i++)
                    returnedString.Append((char)Marshal.ReadByte(new IntPtr((uint)pReturnedString + (uint)i)));
            }
            finally
            {
                Marshal.FreeCoTaskMem(pReturnedString);
            }

            string sectionData = returnedString.ToString();
            return sectionData.Split('\0');
        }
    }
}
