using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Автосервіс
{
    public partial class Act : Form
    {

    private static Work work1 = new Work();
        public Act()
        {
            InitializeComponent();
        }
        public Act(int id)
        {
           InitializeComponent();
            ReportTitle reportTitle = new ReportTitle();
            reportTitle.Title = "Акт виконаних робіт №" + id.ToString();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("WorkDataSet", GetWorksById(id)));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Title", reportTitle.Title));
            this.reportViewer1.RefreshReport();
        }
        DataTable GetWorksById(int id)
        {
            Connection.OpenConnection();
            Work work = new Work();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection.GetConnection();
            /* command.CommandText = "SELECT works.id AS WorksId, cars.marks AS CarMark, cars.registration_mark AS RegistrationMark, clients.name AS ClientName, workers.name AS WorkerName, services.name AS ServiceName, services.price AS Price, works.times_start AS StartTime, works.times_finish AS FinishTime " +
                                  "FROM (((works " +
                                  "INNER JOIN cars ON cars.id = works.cars_id) " +
                                  "INNER JOIN workers ON workers.id = works.workers_id) " +
                                  "INNER JOIN clients ON clients.id = cars.clients_id) " +
                                  "INNER JOIN services ON services.id = works.services_id;";*/
            command.CommandText = "SELECT works.id, services.name AS ServiceName, services.price AS Price, clients.name, cars.marks, cars.registration_mark AS CarNumber, workers.name AS WorkerName, works.times_start, works.times_finish " +
                                  "FROM (((works " +
                                  "INNER JOIN cars ON cars.id = works.cars_id) " +
                                  "INNER JOIN workers ON workers.id = works.workers_id) " +
                                  "INNER JOIN clients ON clients.id = cars.clients_id) " +
                                  "INNER JOIN services ON services.id = works.services_id " +
                                  "WHERE works.id = " + id.ToString() + ";";
            DataTable table = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        private void Act_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
