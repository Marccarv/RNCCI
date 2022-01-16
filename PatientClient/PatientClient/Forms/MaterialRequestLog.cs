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
    public partial class MaterialRequestLog : Form
    {

        #region Constructor

        public MaterialRequestLog()
        {
            InitializeComponent();
            LoadPage();
        }

        #endregion

        #region Methods

        private void buttonAllResults_Click(object sender, EventArgs e)
        {
            try
            {
                // String creation
                StringBuilder url = new StringBuilder();

                // String content
                url.Append("https://localhost:44311/order/requestlist");

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
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<MRequestShowList>));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    List<MRequestShowList> jsonResponse = (List<MRequestShowList>)objResponse;
                    foreach (MRequestShowList mrequestshowlist in jsonResponse)
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["Unit"].Value = mrequestshowlist.UnitName;
                        dataGridView1.Rows[index].Cells["MaterialName"].Value = mrequestshowlist.MaterialName;
                        dataGridView1.Rows[index].Cells["MaterialAmount"].Value = mrequestshowlist.MaterialQuantity;
                    }
                }
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
            buttonAllResults.Enabled = false;
        }

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