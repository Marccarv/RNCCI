using System;
using System.Collections.Generic;

namespace PatientClient.Classes
{
    /// <summary>
    /// Class that creates a vehicle request
    /// </summary>
    public class VRequest
    {

        /// Constructor of VRequest class
        #region Constructor

        public string TeamId { get; set; }
        public string Plate { get; set; }
        public DateTime RequestTime { get; set; }
        public string Zone { get; set; }

        public VRequest()
        {
            this.TeamId = "";
            this.Plate = "";
            this.RequestTime = DateTime.Now;
            this.Zone = "";
        }

        public VRequest(string teamId, string plate, DateTime requestTime, string zone)
        {
            this.TeamId = teamId;
            this.Plate = plate;
            this.RequestTime = requestTime;
            this.Zone = zone;
        }

        #endregion

    }

    public class VRequests
    {

        /// Attributes of VRequests class
        #region Atributos

        static List<VRequest> vehicleRequest;

        #endregion

        /// Constructor of VRequests class
        #region Construtor

        /// <summary>
        /// Constructor of Materials class
        /// </summary>
        static VRequests()
        {
            vehicleRequest = new List<VRequest>();
        }

        #endregion

        /// Methods of VRequests class
        #region Metodos

        /// <summary>
        /// Method used to add a new vehicle request
        /// </summary>
        /// <param name="v">VRequest parameter</param>
        /// <returns></returns>
        public static int Add_VehicleRequest(VRequest v)
        {
            try
            {
                /// Add this request to a list
                vehicleRequest.Add(v);

                return 1;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        #endregion

    }
}

