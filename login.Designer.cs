namespace Автосервіс
{
    partial class login
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
            this.metroTextBoxLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBoxLogin
            // 
            // 
            // 
            // 
            this.metroTextBoxLogin.CustomButton.Image = null;
            this.metroTextBoxLogin.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.metroTextBoxLogin.CustomButton.Name = "";
            this.metroTextBoxLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLogin.CustomButton.TabIndex = 1;
            this.metroTextBoxLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLogin.CustomButton.UseSelectable = true;
            this.metroTextBoxLogin.CustomButton.Visible = false;
            this.metroTextBoxLogin.Lines = new string[0];
            this.metroTextBoxLogin.Location = new System.Drawing.Point(196, 131);
            this.metroTextBoxLogin.MaxLength = 32767;
            this.metroTextBoxLogin.Name = "metroTextBoxLogin";
            this.metroTextBoxLogin.PasswordChar = '\0';
            this.metroTextBoxLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLogin.SelectedText = "";
            this.metroTextBoxLogin.SelectionLength = 0;
            this.metroTextBoxLogin.SelectionStart = 0;
            this.metroTextBoxLogin.ShortcutsEnabled = true;
            this.metroTextBoxLogin.Size = new System.Drawing.Size(209, 23);
            this.metroTextBoxLogin.TabIndex = 0;
            this.metroTextBoxLogin.UseSelectable = true;
            this.metroTextBoxLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(194, 208);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '\0';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(209, 23);
            this.metroTextBoxPassword.TabIndex = 1;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(196, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Логін";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(196, 171);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Пароль";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(196, 274);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(209, 48);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Увійти";
            this.metroButton1.UseSelectable = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 438);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxLogin);
            this.Name = "login";
            this.Resizable = false;
            this.Text = "Вхід";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxLogin;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}