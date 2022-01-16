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
    public partial class MaterialRequest : Form
    {

        #region Constructor

        public MaterialRequest()
        {
            InitializeComponent();
            LoadPage();
            MaterialList();
        }

        #endregion

        #region GridView

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Customization

        private void textBoxMaterialAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            CreateRequest();
            RetifyStock();
            ClearDataRequest();
            this.dataGridView1.Rows.Clear();
            MaterialList();
        }


        /// <summary>
        /// Method used to list all material
        /// </summary>
        private void MaterialList()
        {
            try
            {
                // String creation
                StringBuilder url = new StringBuilder();

                // String content
                url.Append("https://localhost:44311/order/material");

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
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Material>));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    List<Material> jsonResponse = (List<Material>)objResponse;
                    foreach (Material material in jsonResponse)
                    {
                        var index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells["MaterialID"].Value = material.MaterialId;
                        dataGridView1.Rows[index].Cells["MaterialName"].Value = material.MaterialName;
                        dataGridView1.Rows[index].Cells["MaterialAmount"].Value = material.MaterialStock;
                    }
                }
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        /// <summary>
        /// Method used to create a material request
        /// </summary>
        public void CreateRequest()
        {
            try
            {
                // Create a material request object
                MRequest materialRequest = new MRequest(comboBoxUnit.Text, Convert.ToInt32(comboBoxMaterialID.Text), Convert.ToInt32(textBoxMaterialAmount.Text));

                // Add this request to a list
                MRequests.Add_MaterialRequest(materialRequest);

                // API
                StringBuilder url = new StringBuilder();
                url.Append("https://localhost:44311/order/request");
                HttpWebRequest req = WebRequest.Create(url.ToString()) as HttpWebRequest;
                req.Headers.Add("Authorization", "Bearer " + Program.token);
                req.Method = "POST";
                req.ContentType = "application/json; charset=utf-8";
                req.Timeout = 30000;

                string jsonString = JsonSerializer.Serialize(materialRequest);
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
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        /// <summary>
        /// Method used to retify stock (subtract at total)
        /// </summary>
        public void RetifyStock()
        {
            try
            {
                // Create an object material
                Material material = new Material(Convert.ToInt32(comboBoxMaterialID.Text), "", Convert.ToInt32(textBoxMaterialAmount.Text));

                // Insert this object in a list
                Materials.Add_Material(material);

                // API
                StringBuilder url = new StringBuilder();
                url.Append("https://localhost:44311/order/edit");
                HttpWebRequest req = WebRequest.Create(url.ToString()) as HttpWebRequest;
                req.Headers.Add("Authorization", "Bearer " + Program.token);
                req.Method = "PUT";
                req.ContentType = "application/json; charset=utf-8";
                req.Timeout = 30000;

                string jsonString = JsonSerializer.Serialize(material);
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
                        string message = String.Format("PUT method as failed!");
                        throw new ApplicationException(message);
                    }
                }
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
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


        /// <summary>
        /// Method used to clear fields
        /// </summary>
        public void ClearDataRequest()
        {
            textBoxMaterialAmount.Text = "";
            comboBoxMaterialID.Items.Clear();
            comboBoxUnit.Items.Clear();
        }

        #endregion

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
