namespace Автосервіс
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new Автосервіс.DbDataSet();
            this.carsTableAdapter = new Автосервіс.DbDataSetTableAdapters.carsTableAdapter();
            this.metroButtonAct = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTileCreate = new MetroFramework.Controls.MetroTile();
            this.metroButtonWorks = new MetroFramework.Controls.MetroButton();
            this.metroPanelGap = new MetroFramework.Controls.MetroPanel();
            this.metroPanelCreateDocument = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAct = new MetroFramework.Controls.MetroPanel();
            this.labelAct = new System.Windows.Forms.Label();
            this.metroGridAct = new MetroFramework.Controls.MetroGrid();
            this.worksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worksTableAdapter = new Автосервіс.DbDataSetTableAdapters.worksTableAdapter();
            this.metroButtonWorkers = new MetroFramework.Controls.MetroButton();
            this.metroPanelEdit = new MetroFramework.Controls.MetroPanel();
            this.metroTileEdit = new MetroFramework.Controls.MetroTile();
            this.metroButtonEditWorkers = new MetroFramework.Controls.MetroButton();
            this.metroButtonEditUsers = new MetroFramework.Controls.MetroButton();
            this.metroButtonExit = new MetroFramework.Controls.MetroButton();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.metroButtonSettings = new MetroFramework.Controls.MetroButton();
            this.metroPanelWorks = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanelCreateDocument.SuspendLayout();
            this.metroPanelAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).BeginInit();
            this.metroPanelEdit.SuspendLayout();
            this.metroPanelWorks.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.dbDataSetBindingSource;
            // 
            // dbDataSetBindingSource
            // 
            this.dbDataSetBindingSource.DataSource = this.dbDataSet;
            this.dbDataSetBindingSource.Position = 0;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "DbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // metroButtonAct
            // 
            this.metroButtonAct.AutoSize = true;
            this.metroButtonAct.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonAct.Location = new System.Drawing.Point(0, 41);
            this.metroButtonAct.Name = "metroButtonAct";
            this.metroButtonAct.Size = new System.Drawing.Size(236, 37);
            this.metroButtonAct.TabIndex = 3;
            this.metroButtonAct.Text = "Створити акт виконання робіт";
            this.metroButtonAct.UseSelectable = true;
            this.metroButtonAct.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.metroPanel1.Controls.Add(this.metroButtonSettings);
            this.metroPanel1.Controls.Add(this.metroButtonLogout);
            this.metroPanel1.Controls.Add(this.metroButtonExit);
            this.metroPanel1.Controls.Add(this.metroPanelEdit);
            this.metroPanel1.Controls.Add(this.metroPanelCreateDocument);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(236, 471);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTileCreate
            // 
            this.metroTileCreate.ActiveControl = null;
            this.metroTileCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTileCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileCreate.Location = new System.Drawing.Point(0, 0);
            this.metroTileCreate.Name = "metroTileCreate";
            this.metroTileCreate.Size = new System.Drawing.Size(236, 41);
            this.metroTileCreate.TabIndex = 2;
            this.metroTileCreate.Text = "Створення документації";
            this.metroTileCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCreate.UseSelectable = true;
            this.metroTileCreate.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroButtonWorks
            // 
            this.metroButtonWorks.AutoSize = true;
            this.metroButtonWorks.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonWorks.Location = new System.Drawing.Point(0, 78);
            this.metroButtonWorks.Name = "metroButtonWorks";
            this.metroButtonWorks.Size = new System.Drawing.Size(236, 37);
            this.metroButtonWorks.TabIndex = 4;
            this.metroButtonWorks.Text = "Створити звіт виконаних робіт";
            this.metroButtonWorks.UseSelectable = true;
            this.metroButtonWorks.Click += new System.EventHandler(this.metroButtonWorks_Click);
            // 
            // metroPanelGap
            // 
            this.metroPanelGap.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelGap.HorizontalScrollbarBarColor = true;
            this.metroPanelGap.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelGap.HorizontalScrollbarSize = 10;
            this.metroPanelGap.Location = new System.Drawing.Point(256, 60);
            this.metroPanelGap.Name = "metroPanelGap";
            this.metroPanelGap.Size = new System.Drawing.Size(64, 471);
            this.metroPanelGap.TabIndex = 3;
            this.metroPanelGap.VerticalScrollbarBarColor = true;
            this.metroPanelGap.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelGap.VerticalScrollbarSize = 10;
            // 
            // metroPanelCreateDocument
            // 
            this.metroPanelCreateDocument.Controls.Add(this.metroButtonWorkers);
            this.metroPanelCreateDocument.Controls.Add(this.metroButtonWorks);
            this.metroPanelCreateDocument.Controls.Add(this.metroButtonAct);
            this.metroPanelCreateDocument.Controls.Add(this.metroTileCreate);
            this.metroPanelCreateDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelCreateDocument.HorizontalScrollbarBarColor = true;
            this.metroPanelCreateDocument.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelCreateDocument.HorizontalScrollbarSize = 10;
            this.metroPanelCreateDocument.Location = new System.Drawing.Point(0, 0);
            this.metroPanelCreateDocument.Name = "metroPanelCreateDocument";
            this.metroPanelCreateDocument.Size = new System.Drawing.Size(236, 155);
            this.metroPanelCreateDocument.TabIndex = 4;
            this.metroPanelCreateDocument.VerticalScrollbarBarColor = true;
            this.metroPanelCreateDocument.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelCreateDocument.VerticalScrollbarSize = 10;
            // 
            // metroPanelAct
            // 
            this.metroPanelAct.AutoSize = true;
            this.metroPanelAct.Controls.Add(this.metroGridAct);
            this.metroPanelAct.Controls.Add(this.labelAct);
            this.metroPanelAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAct.HorizontalScrollbarBarColor = true;
            this.metroPanelAct.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAct.HorizontalScrollbarSize = 10;
            this.metroPanelAct.Location = new System.Drawing.Point(320, 60);
            this.metroPanelAct.Name = "metroPanelAct";
            this.metroPanelAct.Size = new System.Drawing.Size(976, 471);
            this.metroPanelAct.TabIndex = 4;
            this.metroPanelAct.VerticalScrollbarBarColor = true;
            this.metroPanelAct.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAct.VerticalScrollbarSize = 10;
            this.metroPanelAct.Visible = false;
            // 
            // labelAct
            // 
            this.labelAct.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAct.Location = new System.Drawing.Point(0, 0);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(976, 26);
            this.labelAct.TabIndex = 3;
            this.labelAct.Text = "Створити акт виконання робіт";
            this.labelAct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroGridAct
            // 
            this.metroGridAct.AllowUserToAddRows = false;
            this.metroGridAct.AllowUserToDeleteRows = false;
            this.metroGridAct.AllowUserToOrderColumns = true;
            this.metroGridAct.AllowUserToResizeRows = false;
            this.metroGridAct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridAct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridAct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAct.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridAct.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroGridAct.EnableHeadersVisualStyles = false;
            this.metroGridAct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAct.Location = new System.Drawing.Point(0, 26);
            this.metroGridAct.Name = "metroGridAct";
            this.metroGridAct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridAct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAct.Size = new System.Drawing.Size(976, 167);
            this.metroGridAct.TabIndex = 4;
            this.metroGridAct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridAct_CellContentClick);
            // 
            // worksBindingSource
            // 
            this.worksBindingSource.DataMember = "works";
            this.worksBindingSource.DataSource = this.dbDataSetBindingSource;
            // 
            // worksTableAdapter
            // 
            this.worksTableAdapter.ClearBeforeFill = true;
            // 
            // metroButtonWorkers
            // 
            this.metroButtonWorkers.AutoSize = true;
            this.metroButtonWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonWorkers.Location = new System.Drawing.Point(0, 115);
            this.metroButtonWorkers.Name = "metroButtonWorkers";
            this.metroButtonWorkers.Size = new System.Drawing.Size(236, 37);
            this.metroButtonWorkers.TabIndex = 5;
            this.metroButtonWorkers.Text = "Створити звіт по працівнику";
            this.metroButtonWorkers.UseSelectable = true;
            // 
            // metroPanelEdit
            // 
            this.metroPanelEdit.Controls.Add(this.metroButtonEditUsers);
            this.metroPanelEdit.Controls.Add(this.metroButtonEditWorkers);
            this.metroPanelEdit.Controls.Add(this.metroTileEdit);
            this.metroPanelEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelEdit.HorizontalScrollbarBarColor = true;
            this.metroPanelEdit.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelEdit.HorizontalScrollbarSize = 10;
            this.metroPanelEdit.Location = new System.Drawing.Point(0, 155);
            this.metroPanelEdit.Name = "metroPanelEdit";
            this.metroPanelEdit.Size = new System.Drawing.Size(236, 119);
            this.metroPanelEdit.TabIndex = 5;
            this.metroPanelEdit.VerticalScrollbarBarColor = true;
            this.metroPanelEdit.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelEdit.VerticalScrollbarSize = 10;
            // 
            // metroTileEdit
            // 
            this.metroTileEdit.ActiveControl = null;
            this.metroTileEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTileEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileEdit.Location = new System.Drawing.Point(0, 0);
            this.metroTileEdit.Name = "metroTileEdit";
            this.metroTileEdit.Size = new System.Drawing.Size(236, 41);
            this.metroTileEdit.TabIndex = 3;
            this.metroTileEdit.Text = "Редагування даних";
            this.metroTileEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileEdit.UseSelectable = true;
            // 
            // metroButtonEditWorkers
            // 
            this.metroButtonEditWorkers.AutoSize = true;
            this.metroButtonEditWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonEditWorkers.Location = new System.Drawing.Point(0, 41);
            this.metroButtonEditWorkers.Name = "metroButtonEditWorkers";
            this.metroButtonEditWorkers.Size = new System.Drawing.Size(236, 37);
            this.metroButtonEditWorkers.TabIndex = 4;
            this.metroButtonEditWorkers.Text = "Редагувати дані про працівників";
            this.metroButtonEditWorkers.UseSelectable = true;
            // 
            // metroButtonEditUsers
            // 
            this.metroButtonEditUsers.AutoSize = true;
            this.metroButtonEditUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonEditUsers.Location = new System.Drawing.Point(0, 78);
            this.metroButtonEditUsers.Name = "metroButtonEditUsers";
            this.metroButtonEditUsers.Size = new System.Drawing.Size(236, 37);
            this.metroButtonEditUsers.TabIndex = 5;
            this.metroButtonEditUsers.Text = "Редагувати дані про користувачів";
            this.metroButtonEditUsers.UseSelectable = true;
            // 
            // metroButtonExit
            // 
            this.metroButtonExit.AutoSize = true;
            this.metroButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButtonExit.Location = new System.Drawing.Point(0, 434);
            this.metroButtonExit.Name = "metroButtonExit";
            this.metroButtonExit.Size = new System.Drawing.Size(236, 37);
            this.metroButtonExit.TabIndex = 6;
            this.metroButtonExit.Text = "Вийти з програми";
            this.metroButtonExit.UseSelectable = true;
            this.metroButtonExit.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.AutoSize = true;
            this.metroButtonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButtonLogout.Location = new System.Drawing.Point(0, 397);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(236, 37);
            this.metroButtonLogout.TabIndex = 7;
            this.metroButtonLogout.Text = "Вийти з облікового запису";
            this.metroButtonLogout.UseSelectable = true;
            // 
            // metroButtonSettings
            // 
            this.metroButtonSettings.AutoSize = true;
            this.metroButtonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButtonSettings.Location = new System.Drawing.Point(0, 360);
            this.metroButtonSettings.Name = "metroButtonSettings";
            this.metroButtonSettings.Size = new System.Drawing.Size(236, 37);
            this.metroButtonSettings.TabIndex = 8;
            this.metroButtonSettings.Text = "Налаштування";
            this.metroButtonSettings.UseSelectable = true;
            // 
            // metroPanelWorks
            // 
            this.metroPanelWorks.Controls.Add(this.label1);
            this.metroPanelWorks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelWorks.HorizontalScrollbarBarColor = true;
            this.metroPanelWorks.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelWorks.HorizontalScrollbarSize = 10;
            this.metroPanelWorks.Location = new System.Drawing.Point(320, 60);
            this.metroPanelWorks.Name = "metroPanelWorks";
            this.metroPanelWorks.Size = new System.Drawing.Size(976, 471);
            this.metroPanelWorks.TabIndex = 5;
            this.metroPanelWorks.VerticalScrollbarBarColor = true;
            this.metroPanelWorks.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelWorks.VerticalScrollbarSize = 10;
            this.metroPanelWorks.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Створити звіт виконаних робіт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 551);
            this.Controls.Add(this.metroPanelWorks);
            this.Controls.Add(this.metroPanelAct);
            this.Controls.Add(this.metroPanelGap);
            this.Controls.Add(this.metroPanel1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanelCreateDocument.ResumeLayout(false);
            this.metroPanelCreateDocument.PerformLayout();
            this.metroPanelAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).EndInit();
            this.metroPanelEdit.ResumeLayout(false);
            this.metroPanelEdit.PerformLayout();
            this.metroPanelWorks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dbDataSetBindingSource;
        private DbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private DbDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private MetroFramework.Controls.MetroButton metroButtonAct;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTileCreate;
        private MetroFramework.Controls.MetroButton metroButtonWorks;
        private MetroFramework.Controls.MetroPanel metroPanelGap;
        private MetroFramework.Controls.MetroPanel metroPanelCreateDocument;
        private MetroFramework.Controls.MetroPanel metroPanelAct;
        private System.Windows.Forms.Label labelAct;
        private MetroFramework.Controls.MetroGrid metroGridAct;
        private System.Windows.Forms.BindingSource worksBindingSource;
        private DbDataSetTableAdapters.worksTableAdapter worksTableAdapter;
        private MetroFramework.Controls.MetroButton metroButtonWorkers;
        private MetroFramework.Controls.MetroPanel metroPanelEdit;
        private MetroFramework.Controls.MetroTile metroTileEdit;
        private MetroFramework.Controls.MetroButton metroButtonExit;
        private MetroFramework.Controls.MetroButton metroButtonEditUsers;
        private MetroFramework.Controls.MetroButton metroButtonEditWorkers;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroButton metroButtonSettings;
        private MetroFramework.Controls.MetroPanel metroPanelWorks;
        private System.Windows.Forms.Label label1;
    }
}

