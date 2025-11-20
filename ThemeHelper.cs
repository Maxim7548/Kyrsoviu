using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;


namespace Автосервіс
{


    public static class ThemeHelper
    {
        public static MetroStyleManager AppStyleManager { get; private set; } = new MetroStyleManager();

        public static void Init(MetroThemeStyle theme)
        {
            AppStyleManager.Theme = theme;
        }

        public static void ApplyToForm(Form form)
        {
            if (form is MetroForm mf)
            {
                mf.StyleManager = AppStyleManager;
            }

            // Рекурсивно встановити Theme для metro-контролів у формі
            ApplyThemeToControlsRecursive(form, AppStyleManager.Theme);
            form.Refresh();
        }

        private static void ApplyThemeToControlsRecursive(Control parent, MetroThemeStyle theme)
        {
            foreach (Control c in parent.Controls)
            {
                var prop = c.GetType().GetProperty("Theme");
                if (prop != null && prop.PropertyType == typeof(MetroThemeStyle))
                    prop.SetValue(c, theme, null);

                if (c.HasChildren) ApplyThemeToControlsRecursive(c, theme);
            }
        }

        public static void ApplyToAllOpenForms()
        {
            foreach (Form f in Application.OpenForms)
                ApplyToForm(f);
        }

        public static void SetTheme(MetroThemeStyle theme)
        {
            AppStyleManager.Theme = theme;
            ApplyToAllOpenForms();
        }
    }
}
