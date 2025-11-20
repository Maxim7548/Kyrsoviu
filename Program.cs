using MetroFramework.Components;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автосервіс
{
    internal static class Program
    {
        public static MetroStyleManager AppStyleManager;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Program.cs (Main)
            ThemeHelper.Init(Properties.Settings.Default.AppTheme == "Dark" ? MetroThemeStyle.Dark : MetroThemeStyle.Light);
            var main = new mainForm();
            ThemeHelper.ApplyToForm(main);
            Application.Run(main);
        }
    }
}
