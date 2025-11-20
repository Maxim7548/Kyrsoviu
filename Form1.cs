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
    public partial class Form1 : MetroForm
    {
        public Form1()
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.worksTableAdapter.Fill(this.dbDataSet.works);
            this.carsTableAdapter.Fill(this.dbDataSet.cars);

            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);


            }

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
            grid.Columns["id"].Width = 40;
            grid.Columns["ServiceName"].Width = 150;
            grid.Columns["StartTime"].Width = 100;
            grid.Columns["FinishTime"].Width = 100;
            grid.Columns["id"].HeaderText = "id роботи";
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


        private void getWorks()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;Persist Security Info=False;";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT works.id, cars.marks AS CarMark, clients.name AS ClientName, workers.name AS WorkerName, services.name AS ServiceName, works.times_start AS StartTime, works.times_finish AS FinishTime " +
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
            connection.Close();
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
    }
}
