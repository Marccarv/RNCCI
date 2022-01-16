using System;
using System.Windows.Forms;

namespace PatientClient.Forms
{
    public partial class Register : Form
    {
        #region Constructor

        public Register()
        {
            InitializeComponent();
        }

        #endregion

        #region Customization
        private void panelregisterCenter_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region Buttons

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Instance the service
            PatientService.PatientsClient co = new PatientService.PatientsClient();

            // Create a patient
            PatientService.Patient p = new PatientService.Patient();
            p.patient_un = textBoxUtentNumber.Text;
            p.name = textBoxUsername.Text;
            p.birthday = dateTimePickerBirthday.Value;
            p.unit_name = comboBoxRNCCI.Text;
            p.contact = textBoxContact.Text;
            p.address = textBoxAddress.Text;
            p.register_date = dateTimePickerCurrentDay.Value;


            co.RegisterPatient(p);

            MessageBox.Show("Adicionado com Sucesso!");

            DataClear();
        }

        #endregion

        #region Username
        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region UtentNumber

        private void labelUtentNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUtentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Contact
        private void labelContact_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContact_TextChanged(object sender, EventArgs e)
        {
            /*
            // Instanciar o serviço
            PatientService.PatientsClient co = new PatientService.PatientsClient();
            string contact = textBoxContact.Text;
            co.UniqueContact(contact);
            */
        }
        #endregion

        #region RNCCI
        private void labelRNCCI_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRNCCI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Birthday
        private void labelBirthday_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region CurrentDay
        private void labelCurrentDay_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerCurrentDay_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerCurrentDay.Value = DateTime.Now;
        }
        #endregion

        #region Address
        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }


        #endregion

        #region Methods

        /// <summary>
        /// Method used to clear fields
        /// </summary>
        private void DataClear()
        {
            textBoxUsername.Text = textBoxContact.Text = textBoxAddress.Text = textBoxUtentNumber.Text = "";
            dateTimePickerBirthday.Value = DateTime.Now;
            comboBoxRNCCI.Items.Clear();
        }
        #endregion
    }
}
