using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PatientClient
{
    public partial class Form1 : Form
    {

        #region Fields

        private Button currentButton;
        private Form activeForm;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            customizeDesignMaterial();
            buttonClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Customization

        private void panelRegisterLeftTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRegisterLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRegisterTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelregisterCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelHomeText_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelMaterialSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region Buttons

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonMenuRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Register(), sender);

            Color color = (ColorTranslator.FromHtml("#E89B4F"));
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            panelRegisterTop.BackColor = color;
            panelRegisterLeftTop.BackColor = ChangeColorBrightness(color, -0.3);
            hideSubMenu();
            hideSubMenuMaterial();
        }


        private void buttonMenuVehicles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.VehicleHome(), sender);
            showSubMenu(panelVehiclesSubmenu);
            labelHomeText.Text = "";

            Color color = (ColorTranslator.FromHtml("#0555F7"));
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            panelRegisterTop.BackColor = color;
            panelRegisterLeftTop.BackColor = ChangeColorBrightness(color, -0.3);
            hideSubMenuMaterial();
        }


        private void buttonMenuVisits_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.VisitsHome(), sender);
            labelHomeText.Text = "";

            Color color = (ColorTranslator.FromHtml("#686FF8"));
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            panelRegisterTop.BackColor = color;
            panelRegisterLeftTop.BackColor = ChangeColorBrightness(color, -0.3);
            hideSubMenu();
            hideSubMenuMaterial();
        }


        private void buttonVehiclesRequest_Click(object sender, EventArgs e)
        {
            OpenChildFormSubmenu(new Forms.VehicleRequest(), sender);
        }


        private void buttonRequestHistory_Click(object sender, EventArgs e)
        {
            OpenChildFormSubmenu(new Forms.HistoryRequest(), sender);
        }


        private void buttonMenuMaterial_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MaterialHome(), sender);
            showSubMenuMaterial(panelMaterialSubmenu);
            labelHomeText.Text = "";

            Color color = (ColorTranslator.FromHtml("#627300"));
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            panelRegisterTop.BackColor = color;
            panelRegisterLeftTop.BackColor = ChangeColorBrightness(color, -0.3);
            hideSubMenu();
        }


        private void buttonMaterialRequest_Click(object sender, EventArgs e)
        {
            OpenChildFormSubmenu(new Forms.MaterialRequest(), sender);
        }


        private void buttonMaterialRequestLog_Click(object sender, EventArgs e)
        {
            OpenChildFormSubmenu(new Forms.MaterialRequestLog(), sender);
        }


        private void buttonMenuDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardHome(), sender);
            labelHomeText.Text = "";

            Color color = (ColorTranslator.FromHtml("#54C2DE"));
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            panelRegisterTop.BackColor = color;
            panelRegisterLeftTop.BackColor = ChangeColorBrightness(color, -0.3);
            hideSubMenu();
            hideSubMenuMaterial();
        }

        #endregion

        #region Top Buttons
        private void buttonCloseTop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }


        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Hours
        private void timerHour_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.ToString("H:mm:ss");
            label1.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
        }

        private void labelHour_Click(object sender, EventArgs e)
        {

        }

        private void labelDays_Click(object sender, EventArgs e)
        {

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
                    buttonClose.Visible = true;
                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in panelRegisterLeft.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(26, 32, 40);
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
            labelHomeText.Text = childForm.Text;
        }


        private void OpenChildFormSubmenu(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelregisterCenter.Controls.Add(childForm);
            this.panelregisterCenter.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHomeText.Text = childForm.Text;
        }


        private void panelRegisterTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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


        private void customizeDesign()
        {
            panelVehiclesSubmenu.Visible = false;

        }


        private void hideSubMenu()
        {
            if (panelVehiclesSubmenu.Visible == true)
                panelVehiclesSubmenu.Visible = false;
        }


        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void customizeDesignMaterial()
        {
            panelMaterialSubmenu.Visible = false;

        }


        private void hideSubMenuMaterial()
        {
            if (panelMaterialSubmenu.Visible == true)
                panelMaterialSubmenu.Visible = false;
        }


        private void showSubMenuMaterial(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenuMaterial();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

    }
}