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
    public partial class VisitsLog : Form
    {

        #region Constructor

        public VisitsLog()
        {
            InitializeComponent();
            LoadPage();
        }

        #endregion

        #region GridView

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region PatientUN

        private void textBoxPatientUN_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Button CheckLogs

        /// <summary>
        /// Method used to check visits logs
        /// </summary>
        private void buttonCheckLogs_Click(object sender, EventArgs e)
        {
            // Get data from database with proper selects
            try
            {
                // String creation
                StringBuilder url = new StringBuilder();

                // String content
                url.Append("https://localhost:44311/visits/log/");
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
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<VisitorLog>));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    List<VisitorLog> jsonResponse = (List<VisitorLog>)objResponse;

                    //USAR NO OUTRO CASO DE ERRO  FAZER BOTAO 2 TRUE VISIBLE
                    dataGridView1.Rows.Clear();
                    foreach (VisitorLog visitorlog in jsonResponse)
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["TimeIn"].Value = visitorlog.TimeIn;
                        dataGridView1.Rows[index].Cells["TimeOut"].Value = visitorlog.TimeOut;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method used to edit the data grid view
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
