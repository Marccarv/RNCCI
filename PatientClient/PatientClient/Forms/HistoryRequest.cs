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
    public partial class HistoryRequest : Form
    {

        #region Constructor

        public HistoryRequest()
        {
            InitializeComponent();
            LoadPage();
        }

        #endregion

        #region Button AllResults

        private void buttonAllResults_Click(object sender, EventArgs e)
        {
            try
            {
                // String creation
                StringBuilder url = new StringBuilder();

                // String content
                url.Append("https://localhost:44311/vehicle/requestlist");

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
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<VRequestShowList>));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    List<VRequestShowList> jsonResponse = (List<VRequestShowList>)objResponse;
                    foreach (VRequestShowList vehiclerequest in jsonResponse)
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["Unit"].Value = vehiclerequest.UnitName;
                        dataGridView1.Rows[index].Cells["Date"].Value = vehiclerequest.RequestTime;
                        dataGridView1.Rows[index].Cells["VehicleBrand"].Value = vehiclerequest.VehicleBrand;
                        dataGridView1.Rows[index].Cells["VehicleType"].Value = vehiclerequest.VehicleType;
                    }
                }
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
            buttonAllResults.Enabled = false;
        }

        #endregion

        #region GridView

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Methods

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
