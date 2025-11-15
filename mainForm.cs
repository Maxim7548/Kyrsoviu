using MetroFramework.Forms;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автосервіс
{
    public partial class mainForm : MetroForm
    {
       
        public mainForm()
        {
            InitializeComponent();
        }
        private void EnableButtons()
        {
            metroButtonAct.Enabled = true;
            metroButtonEditUsers.Enabled = true;
            metroButtonEditWorkers.Enabled = true;
            metroButtonWorkers.Enabled = true;
            metroButtonWorks.Enabled = true;
            metroButtonSettings.Enabled = true;
        }
        private void HidePanels()
        {
            metroPanelAct.Visible = false;
            metroPanelWorks.Visible = false;
            metroPanelEditWorkers.Visible = false;
            metroPanelUsers.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.dbDataSet.workers);
            this.worksTableAdapter.Fill(this.dbDataSet.works);
            this.carsTableAdapter.Fill(this.dbDataSet.cars);
            metroComboBoxVacationReason.Items.AddRange(new string[]
            {
                "Хвороба",
                "Відпустка",
                "Пропуск за власний рахунок",
                "Прогул",
                "Інше"
            });
            metroButtonCancelVacation.Visible = false;
            metroButtonSaveVacation.Visible = false;
            metroButtonAddVaction.Visible = true;
            //string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
            //using (OleDbConnection connection = new OleDbConnection(connectionString))
            //{
            //    connection.Open();
            //    DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);


            //}


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            EnableButtons();
            HidePanels();
            metroPanelAct.Visible = true;
            metroPanelAct.Focus();
            getWorks();
            metroButtonAct.Enabled = false;
        }

        private void AddWorksColumnsToGrid(DataGridView grid)
        {
           // grid.Columns["id"].Width = 40;
            grid.Columns["ServiceName"].Width = 150;
            grid.Columns["StartTime"].Width = 120;
            grid.Columns["FinishTime"].Width = 120;
           // grid.Columns["id"].HeaderText = "id роботи";
            grid.Columns["CarMark"].HeaderText = "Марка авто";
            grid.Columns["ClientName"].HeaderText = "ПІБ клієнта";
            grid.Columns["WorkerName"].HeaderText = "ПІБ працівника";
            grid.Columns["ServiceName"].HeaderText = "Назва послуги";
            grid.Columns["StartTime"].HeaderText = "Час початку";
            grid.Columns["FinishTime"].HeaderText = "Час завершення";
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.ReadOnly = true;
            }
        }
        private void AddWorkersColumnsToGrid(DataGridView grid)
        {
            // grid.Columns["id"].Width = 40;
            //grid.Columns["WorkerName"].Width = 150;
            //grid.Columns["WorkerPosition"].Width = 150;
            // grid.Columns["id"].HeaderText = "id роботи";
            grid.Columns["WorkerName"].HeaderText = "ПІБ працівника";
            grid.Columns["WorkerPosition"].HeaderText = "Посада працівника";
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void getWorks()
        {
            
            
            Connection.OpenConnection();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection.GetConnection();
            command.CommandText = "SELECT cars.marks AS CarMark, clients.name AS ClientName, workers.name AS WorkerName, services.name AS ServiceName, works.times_start AS StartTime, works.times_finish AS FinishTime " +
                                  "FROM (((works " +
                                  "INNER JOIN cars ON cars.id = works.cars_id) " +
                                  "INNER JOIN workers ON workers.id = works.workers_id) " +
                                  "INNER JOIN clients ON clients.id = cars.clients_id) " +
                                  "INNER JOIN services ON services.id = works.services_id;";
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            metroGridAct.DataSource = table;
            AddWorksColumnsToGrid(metroGridAct);
            Connection.CloseConnection();
        }
        private void getWorkers()
        {
            try
            {
                var conn = Connection.GetConnection();
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT name AS WorkerName, specialty AS WorkerPosition FROM workers;";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    metroGridWorkers.DataSource = table;
                    AddWorkersColumnsToGrid(metroGridWorkers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}\nInner: {ex.InnerException}");
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
/**
 * 
 * * Фільтр за типом пропуска 
 * 
 **/
        private void getVacations()
        {
            try
            {
                var conn = Connection.GetConnection();
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT workers.name AS WorkerName, workers_vacations.reason AS Reason, workers_vacations.start_date AS StartDate, workers_vacations.finish_date AS EndDate " +
                                          "FROM (workers_vacations " +
                                          "INNER JOIN workers ON workers.id = workers_vacations.workers_id);";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    metroGridWorkersVacations.DataSource = table;
                    AddVacationsColumnsToGrid(metroGridWorkersVacations);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}\nInner: {ex.InnerException}");
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        private void AddVacationsColumnsToGrid(DataGridView grid)
        {
            // grid.Columns["id"].Width = 40;
            //grid.Columns["WorkerName"].Width = 150;
            grid.Columns["StartDate"].Width = 120;
            grid.Columns["EndDate"].Width = 120;
            //grid.Columns["Reason"].Width = 200;
            // grid.Columns["id"].HeaderText = "id роботи";
            grid.Columns["WorkerName"].HeaderText = "ПІБ працівника";
            grid.Columns["StartDate"].HeaderText = "Дата початку";
            grid.Columns["EndDate"].HeaderText = "Дата завершення";
            grid.Columns["Reason"].HeaderText = "Причина відпустки";
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroGridAct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonWorks_Click(object sender, EventArgs e)
        {
            EnableButtons();
            HidePanels();
            metroPanelWorks.Visible = true;
            metroPanelWorks.Focus();
            metroButtonWorks.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonEditWorkers_Click(object sender, EventArgs e)
        {
            EnableButtons();
            HidePanels();
            metroPanelEditWorkers.Visible = true;
            metroPanelEditWorkers.Focus();
            getWorkers();
            getVacations();
            metroButtonEditWorkers.Enabled = false;
            
            
        }

        private void metroGridWorkersVacations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGridWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButtonAddVaction_Click(object sender, EventArgs e)
        {
            metroButtonSaveVacation.Visible = true;
            metroButtonCancelVacation.Visible = true;
            metroButtonAddVaction.Visible = false;
        }

        private void metroButtonSaveVacation_Click(object sender, EventArgs e)
        {
            metroButtonCancelVacation.Visible = false;
            metroButtonSaveVacation.Visible = false;
            metroButtonAddVaction.Visible = true;
        }

        private void metroButtonCancelVacation_Click(object sender, EventArgs e)
        {
            metroButtonCancelVacation.Visible = false;
            metroButtonSaveVacation.Visible = false;
            metroButtonAddVaction.Visible = true;
        }
        private void loadUsers()
        {
            try
            {
                var conn = Connection.GetConnection();
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT login AS UserName, is_admin AS UserRole FROM users;";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    table.Columns["UserName"].DataType = typeof(string);

                    AddUsersColumnsToGrid(metroGridUsers);
                    metroGridUsers.DataSource = table;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}\nInner: {ex.InnerException}");
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        private void AddUsersColumnsToGrid(DataGridView grid)
        {
            // grid.Columns["id"].Width = 40;
            //grid.Columns["WorkerName"].Width = 150;
            //grid.Columns["WorkerPosition"].Width = 150;
            // grid.Columns["id"].HeaderText = "id роботи";
            metroGridUsers.Columns.Add("UserName", "Логін");
            metroGridUsers.Columns.Add("UserRole", "Роль");
            metroGridUsers.Columns["UserName"].ValueType = typeof(string);
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.ReadOnly = true;
            }
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.Cells["UserRole"].Value = (row.Cells["UserRole"].Value.ToString() == "True") ? "Адміністратор" : "Користувач";
            }
        }
        private void metroButtonEditUsers_Click(object sender, EventArgs e)
        {
            HidePanels();
            EnableButtons();
            metroPanelUsers.Visible = true;
            metroPanelUsers.Focus();
            metroButtonEditUsers.Enabled = false;
            loadUsers();
        }
    }
}
