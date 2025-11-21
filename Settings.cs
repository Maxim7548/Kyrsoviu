using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework;


namespace Автосервіс
{
    public partial class Settings : MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.AppTheme == "Dark")
            {
                metroRadioButtonDark.Checked = true;
            }
            else
            {
                metroRadioButtonLight.Checked = true;
            }
        }

        private void metroRadioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AppTheme = "Light";
            Properties.Settings.Default.Save();
            ThemeHelper.SetTheme(MetroFramework.MetroThemeStyle.Light);
            ThemeHelper.ApplyToAllOpenForms();
        }

        private void metroRadioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AppTheme = "Dark";
            Properties.Settings.Default.Save();
            ThemeHelper.SetTheme(MetroFramework.MetroThemeStyle.Dark);
            ThemeHelper.ApplyToAllOpenForms();
        }

       
    }
}
