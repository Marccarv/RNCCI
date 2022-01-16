namespace PatientClient.Classes
{
    /// <summary>
    /// Class that creates a vehicle
    /// </summary>
    public class Vehicle
    {

        /// Constructor of Vehicle class
        #region Constructor

        public string VehicleBrand { get; set; }
        public string Plate { get; set; }
        public string VehicleType { get; set; }
        public string Zone { get; set; }

        public Vehicle()
        {
            this.VehicleBrand = "";
            this.Plate = "";
            this.VehicleType = "";
            this.Zone = "";
        }

        public Vehicle(string vehicleBrand, string plate, string vehicleType, string zone)
        {
            this.VehicleBrand = vehicleBrand;
            this.Plate = plate;
            this.VehicleType = vehicleType;
            this.Zone = zone;
        }

        #endregion

    }
}