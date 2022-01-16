using PatientClient.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace PatientClient.Forms
{
    public partial class VehicleRequest : Form
    {

        #region Constructor

        public VehicleRequest()
        {
            InitializeComponent();
        }

        #endregion

        #region LoadPage

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {
            LoadPage();
        }

        #endregion

        #region Zone

        private void labelZone_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxZone.Enabled = false;
        }

        #endregion

        #region Button Zone

        /// <summary>
        /// Method used to search for a vehicle in specific zone
        /// </summary>
        private void buttonZone_Click(object sender, EventArgs e)
        {
            // Get data from database with proper selects
            try
            {
                // String creation
                StringBuilder url = new StringBuilder();

                // String content
                url.Append("https://localhost:44311/vehicle/search/");
                url.Append(comboBoxZone.Text.ToString());

                // API
                HttpWebRequest request = WebRequest.Create(url.ToString()) as HttpWebRequest;

                // Verify if service is up
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        // Exception error message
                        string message = String.Format("Get method as failed!");
                        throw new ApplicationException(message);
                    }

                    // Convert Json into a class
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Vehicle>));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    List<Vehicle> jsonResponse = (List<Vehicle>)objResponse;

                    //USAR NO OUTRO CASO DE ERRO  FAZER BOTAO 2 TRUE VISIBLE
                    dataGridView1.Rows.Clear();
                    foreach (Vehicle vehicle in jsonResponse)
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["Brand"].Value = vehicle.VehicleBrand;
                        dataGridView1.Rows[index].Cells["Plate"].Value = vehicle.Plate;
                        dataGridView1.Rows[index].Cells["Type"].Value = vehicle.VehicleType;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region Grid

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Plate

        private void textBoxPlate_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Team Number

        private void labelTeamNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTeamNumber_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region DateTime

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        #endregion

        #region Request Button

        /// <summary>
        /// Method used to create a vehicle request
        /// </summary>
        private void buttonRequest_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a vehicle request object
                VRequest vehicleRequest = new VRequest(textBoxTeamNumber.Text, textBoxPlate.Text, dateTimePicker1.Value, comboBoxZone.Text);

                // Add this request to a list
                VRequests.Add_VehicleRequest(vehicleRequest);

                // API
                StringBuilder url = new StringBuilder();
                url.Append("https://localhost:44311/vehicle/request");
                HttpWebRequest req = WebRequest.Create(url.ToString()) as HttpWebRequest;
                req.Headers.Add("Authorization", "Bearer " + Program.token);
                req.Method = "POST";
                req.ContentType = "application/json; charset=utf-8";
                req.Timeout = 30000;

                string jsonString = JsonSerializer.Serialize(vehicleRequest);
                req.ContentLength = jsonString.Length;
                var sw = new StreamWriter(req.GetRequestStream());
                sw.Write(jsonString);
                sw.Close();

                using (HttpWebResponse response = req.GetResponse() as HttpWebResponse)
                {
                    // Verify if service is up
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        // Exception error message
                        string message = String.Format("Post method as failed!");
                        throw new ApplicationException(message);
                    }
                }
                MessageBox.Show("Request has been made successfully!");
                ClearDataRequest();
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method used to edit data grid view
        /// </summary>
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

            dateTimePicker1.Visible = false;
        }

        /// <summary>
        /// Method to clear fields
        /// </summary>
        void ClearDataRequest()
        {
            textBoxPlate.Text = textBoxTeamNumber.Text = "";
            comboBoxZone.Items.Clear();
        }
        #endregion

    }
}
