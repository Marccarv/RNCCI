namespace PatientClient.Classes
{
    /// <summary>
    /// Class that creates a patient used in visits
    /// </summary>
    public class Patient
    {

        /// Constructor of Patient class
        #region Constructor

        public string PatientUn { get; set; }
        public string Name { get; set; }

        public Patient()
        {
            this.PatientUn = "";
            this.Name = "";
        }

        public Patient(string patientUn, string name)
        {
            this.PatientUn = patientUn;
            this.Name = name;
        }

        #endregion

    }
}