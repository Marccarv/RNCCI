using System.Windows.Forms;

namespace PatientClient
{
    class Program
    {

        #region Attributes

        public static string token;

        #endregion

        #region Main

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion

    }
}
