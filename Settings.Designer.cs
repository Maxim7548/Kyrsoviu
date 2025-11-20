namespace Автосервіс
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroRadioButtonDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonLight = new MetroFramework.Controls.MetroRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroRadioButtonDark);
            this.metroPanel1.Controls.Add(this.metroRadioButtonLight);
            this.metroPanel1.Controls.Add(this.label7);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(568, 100);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroRadioButtonDark
            // 
            this.metroRadioButtonDark.AutoSize = true;
            this.metroRadioButtonDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButtonDark.Location = new System.Drawing.Point(350, 53);
            this.metroRadioButtonDark.Name = "metroRadioButtonDark";
            this.metroRadioButtonDark.Size = new System.Drawing.Size(64, 19);
            this.metroRadioButtonDark.TabIndex = 9;
            this.metroRadioButtonDark.Text = "Темна";
            this.metroRadioButtonDark.UseSelectable = true;
            this.metroRadioButtonDark.CheckedChanged += new System.EventHandler(this.metroRadioButtonDark_CheckedChanged);
            // 
            // metroRadioButtonLight
            // 
            this.metroRadioButtonLight.AutoSize = true;
            this.metroRadioButtonLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButtonLight.Location = new System.Drawing.Point(73, 53);
            this.metroRadioButtonLight.Name = "metroRadioButtonLight";
            this.metroRadioButtonLight.Size = new System.Drawing.Size(64, 19);
            this.metroRadioButtonLight.TabIndex = 8;
            this.metroRadioButtonLight.Text = "Світла";
            this.metroRadioButtonLight.UseSelectable = true;
            this.metroRadioButtonLight.CheckedChanged += new System.EventHandler(this.metroRadioButtonLight_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(568, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Вибір теми";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 160);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(568, 100);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вибір шляху до бази даних";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Settings";
            this.Text = "Налаштування";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonDark;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonLight;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
    }
}