using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientClient.Forms
{
    public partial class DashboardHome : Form
    {

        #region Attributes

        private Button currentButton;
        private Form activeForm;

        #endregion

        #region Constructor

        public DashboardHome()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void buttonDashboardPatients_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardPatients(), sender);
            Color color = (ColorTranslator.FromHtml("#1A2028"));
            currentButton = (Button)sender;
            currentButton.BackColor = color;
        }

        private void buttonDashboardVisits_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardVisits(), sender);
            Color color = (ColorTranslator.FromHtml("#1A2028"));
            currentButton = (Button)sender;
            currentButton.BackColor = color;
        }

        private void buttonDashboardVehicles_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardVehicles(), sender);
            Color color = (ColorTranslator.FromHtml("#1A2028"));
            currentButton = (Button)sender;
            currentButton.BackColor = color;
        }

        #endregion

        #region Methods

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.Gainsboro;
                    currentButton.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in tableLayoutPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(84, 194, 222);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10F, System.Drawing.FontStyle.Bold);
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelregisterCenter.Controls.Add(childForm);
            this.panelregisterCenter.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        #endregion

    }
}
