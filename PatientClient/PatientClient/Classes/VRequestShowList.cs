namespace PatientClient.Classes
{
    /// <summary>
    /// Class used to show the list of vehicle requests
    /// </summary>
    public class VRequestShowList
    {

        /// Constructor of VRequestShowList class
        #region Constructor

        public string UnitName { get; set; }
        public string RequestTime { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleType { get; set; }


        public VRequestShowList()
        {
            this.UnitName = "";
            this.RequestTime = "";
            this.VehicleBrand = "";
            this.VehicleType = "";
        }

        public VRequestShowList(string unitName, string requestTime, string vehicleBrand, string vehicleType)
        {
            this.UnitName = unitName;
            this.RequestTime = requestTime;
            this.VehicleBrand = vehicleBrand;
            this.VehicleType = vehicleType;
        }

        #endregion

    }
}