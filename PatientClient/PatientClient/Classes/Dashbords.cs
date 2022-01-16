namespace PatientClient.Classes
{
    /// Dashboards classes

    #region Dashboard Patients

    /// <summary>
    /// Class that creates a dashboard patient
    /// </summary>
    public class DPatient
    {

        /// Constructor of DPatient class
        #region Constructor

        public string UnitName { get; set; }
        public int Count { get; set; }

        public DPatient()
        {
            this.UnitName = "";
            this.Count = 0;
        }

        public DPatient(string unitName, int count)
        {
            this.UnitName = unitName;
            this.Count = count;
        }

        #endregion

    }

    #endregion

    #region Dashboard Visits

    /// <summary>
    /// Class that creates a dashboard visit
    /// </summary>
    public class DVisit
    {

        /// Constructor of DVisit class
        #region Constructor

        public string UnitName { get; set; }
        public int Count { get; set; }

        public DVisit()
        {
            this.UnitName = "";
            this.Count = 0;
        }

        public DVisit(string unitName, int count)
        {
            this.UnitName = unitName;
            this.Count = count;
        }

        #endregion

    }

    #endregion

    #region Dashboard Vehicles

    /// <summary>
    /// Class that creates a dashboard vehicle
    /// </summary>
    public class DVehicle
    {

        /// Constructor of DVehicle class
        #region Constructor

        public string UnitName { get; set; }
        public string TeamId { get; set; }

        public DVehicle()
        {
            this.UnitName = "";
            this.TeamId = "";
        }

        public DVehicle(string unitName, string teamId)
        {
            this.UnitName = unitName;
            this.TeamId = teamId;
        }

        #endregion

    }

    #endregion

}
