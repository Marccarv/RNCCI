namespace PatientClient.Classes
{
    /// <summary>
    /// Class that creates the visitor log
    /// </summary>
    public class VisitorLog
    {

        /// Constructor of VisitorLog class
        #region Constructor

        public string PatientUn { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }

        public VisitorLog()
        {
            this.PatientUn = "";
            this.TimeIn = "";
            this.TimeOut = "";
        }

        public VisitorLog(string patientUn, string timeIn, string timeOut)
        {
            this.PatientUn = patientUn;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
        }

        #endregion

    }
}
