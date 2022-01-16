using PatientClient.Classes;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace PatientClient.Forms
{
    public partial class VisitsOut : Form
    {

        #region Constructor

        public VisitsOut()
        {
            InitializeComponent();
        }

        #endregion

        #region Customization

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }


        private void VisitsOut_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region PatientUN

        private void textBoxPatientUN_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region DatePicker TimeOut

        private void dateTimePickerTimeOut_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerTimeOut.Value = DateTime.Now;
        }

        #endregion

        #region Button ResgisterTimeOut

        /// <summary>
        /// Method used to regist the end of a visit
        /// </summary>
        private void buttonRegisterTimeOut_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an object Visitor
                Visitor visitor = new Visitor(textBoxPatientUN.Text, dateTimePickerTimeOut.Value, dateTimePickerTimeOut.Value);

                // Insert this object into a list
                Visitors.Add_Visitor(visitor);

                // API
                StringBuilder url = new StringBuilder();
                url.Append("https://localhost:44311/visits/edit");
                HttpWebRequest req = WebRequest.Create(url.ToString()) as HttpWebRequest;
                req.Headers.Add("Authorization", "Bearer " + Program.token);
                req.Method = "PUT";
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
                MessageBox.Show("Visit has ended!");
                ClearData();
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method used to clear fields
        /// </summary>
        private void ClearData()
        {
            this.textBoxPatientUN.Text = "";
            this.dateTimePickerTimeOut.Value = DateTime.Now;
        }

        #endregion

    }
}
