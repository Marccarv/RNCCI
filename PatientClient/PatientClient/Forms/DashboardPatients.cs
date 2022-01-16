using PatientClient.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace PatientClient.Forms
{
    public partial class DashboardPatients : Form
    {

        #region Constructor

        public DashboardPatients()
        {

            InitializeComponent();
            LoadPage();
            DashboardTable();
            //DashboardChart();
            //chartDashbordPatients.Visible = false;

        }

        #endregion

        #region Customization

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }


        private void chartDashbordPatients_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Methods

        public void DashboardTable()
        {
            try
            {
                // String creation
                StringBuilder url = new StringBuilder();

                // String content
                url.Append("https://localhost:44311/dashboard/patients");

                // API
                HttpWebRequest request = WebRequest.Create(url.ToString()) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    // Verify if service is up
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        // Exception error message
                        string message = String.Format("Get falhou!!");
                        throw new ApplicationException(message);
                    }

                    // Convert Json into a class
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<DPatient>));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    List<DPatient> jsonResponse = (List<DPatient>)objResponse;
                    foreach (DPatient dashboardPatients in jsonResponse)
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["Unit"].Value = dashboardPatients.UnitName;
                        dataGridView1.Rows[index].Cells["PatientsNumber"].Value = dashboardPatients.Count;
                    }
                }
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        //public void DashboardChart()
        //{
        //    try
        //    {
        //        // String creation
        //        StringBuilder url = new StringBuilder();

        //        // String content
        //        url.Append("https://localhost:44311/dashboard/patients");

        //        // API
        //        HttpWebRequest request = WebRequest.Create(url.ToString()) as HttpWebRequest;
        //        using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
        //        {
        //            // Verify if service is up
        //            if (response.StatusCode != HttpStatusCode.OK)
        //            {
        //                // Exception error message
        //                string message = String.Format("Get falhou!!");
        //                throw new ApplicationException(message);
        //            }

        //            // Convert Json into a class
        //            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<DPatient>));
        //            object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
        //            List<DPatient> jsonResponse = (List<DPatient>)objResponse;
        //            foreach (DPatient dashboardPatients in jsonResponse)
        //            {
        //                foreach (var unit_name in dashboardPatients.unit_name)
        //                {
        //                    UNITNAME un = new UNITNAME(dashboardPatients.unit_name);
        //                    UNITNAMES.Add_DashboardUnitName(un);
        //                }
        //                foreach (var count in dashboardPatients.count)
        //                {
        //                    COUNT ct = new COUNT(dashboardPatients.count);
        //                    COUNTS.Add_DashboardCount(ct);
        //                }

        //                //DPatient dp = new DPatient(dashboardPatients.unit_name, dashboardPatients.count);
        //                //DPatients.Add_DashboardPatient(dp);
        //                chartDashbordPatients.Series[0].Points.AddXY(un, ct);
        //                //ArrayList UnitName = new ArrayList();
        //                //ArrayList Count = new ArrayList();
        //                //foreach (var unit_name in dashboardPatients.unit_name)
        //                //{
        //                //    UnitName.Add(dashboardPatients.unit_name);
        //                //}
        //                //foreach (var count in dashboardPatients.unit_name)
        //                //{
        //                //    Count.Add(dashboardPatients.count);
        //                //}
        //                //UnitName.Add(dashboardPatients.unit_name);
        //                //Count.Add(dashboardPatients.count);


        //                //var index = dataGridView1.Rows.Add();
        //                //dataGridView1.Rows[index].Cells["Unit"].Value = dashboardPatients.unit_name;
        //                //dataGridView1.Rows[index].Cells["PatientsNumber"].Value = dashboardPatients.count;
        //                //chartDashbordPatients.Series[0].Points.DataBindXY(dashboardPatients.unit_name, dashboardPatients.count);
        //            }
        //        }
        //    }
        //    catch (ApplicationException exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}


        void LoadPage()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.FromArgb(49, 66, 82);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tw Cen MT Condensed Extra Bold", 15);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(49, 66, 82);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
        }

        #endregion

    }
}