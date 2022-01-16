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
    public partial class Visits : Form
    {

        #region Constructor

        public Visits()
        {
            InitializeComponent();
            //dataGridView1.Visible = false;
            //buttonCheckPatient.Visible = false;
        }

        #endregion

        #region Initial Page

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {
            LoadPage();
        }

        #endregion

        #region PatientUN

        private void labelPatientUN_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPatientUN_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region TimeIn

        private void labelTimeIn_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTimeIn_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerTimeIn.Value = DateTime.Now;
        }

        #endregion

        #region Button RegisterTimeIn

        /// <summary>
        /// Method used to regist a visit in
        /// </summary>
        private void buttonRegisterTimeIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an object visitor
                Visitor visitor = new Visitor(textBoxPatientUN.Text, dateTimePickerTimeIn.Value, dateTimePickerTimeIn.Value);

                // Insert this object in a list
                Visitors.Add_Visitor(visitor);

                // API
                StringBuilder url = new StringBuilder();
                url.Append("https://localhost:44311/visits/create");
                HttpWebRequest req = WebRequest.Create(url.ToString()) as HttpWebRequest;
                req.Headers.Add("Authorization", "Bearer " + Program.token);
                req.Method = "POST";
                req.ContentType = "application/json; charset=utf-8";
                req.Timeout = 30000;

                string jsonString = JsonSerializer.Serialize(visitor);
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
                        string message = String.Format("Post falhou!!");
                        throw new ApplicationException(message);
                    }
                }
                MessageBox.Show("New Visit has been registed!");
                ClearData();
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region Button CheckPatient

        private void buttonCheckPatient_Click(object sender, EventArgs e)
        {
            // Get data from database with proper selects
            try
            {
                // String creation
                StringBuilder url = new StringBuilder();

                // String content
                url.Append("https://localhost:44311/visits/patientinfo/");
                url.Append(textBoxPatientUN.Text.ToString());

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
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Patient>));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    List<Patient> jsonResponse = (List<Patient>)objResponse;

                    //USAR NO OUTRO CASO DE ERRO  FAZER BOTAO 2 TRUE VISIBLE
                    dataGridView1.Rows.Clear();
                    foreach (Patient patient in jsonResponse)
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["Patient"].Value = patient.Name;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region PatientName

        private void textBoxPatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPatientName_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region GridView

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Visits_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Method used to clear fields
        /// </summary>
        private void ClearData()
        {
            this.textBoxPatientUN.Text = "";
            this.dateTimePickerTimeIn.Value = DateTime.Now;
        }

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
        }

        #endregion

    }
}
