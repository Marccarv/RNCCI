using System;
using System.Collections.Generic;

namespace PatientClient.Classes
{
    /// <summary>
    /// Class that creates a material request
    /// </summary>
    public class MRequest
    {

        /// Constructor of MRquest class
        #region Constructor

        public string UnitName { get; set; }
        public int MaterialId { get; set; }
        public int MaterialQuantity { get; set; }

        public MRequest()
        {
            this.UnitName = "";
            this.MaterialId = 0;
            this.MaterialQuantity = 0;
        }

        public MRequest(string unitName, int materialId, int materialQuantity)
        {
            this.UnitName = unitName;
            this.MaterialId = materialId;
            this.MaterialQuantity = materialQuantity;
        }

        #endregion

    }

    public class MRequests
    {

        /// Attributes of MRequests class
        #region Atributos

        static List<MRequest> materialRequest;

        #endregion

        /// Constructor of MRequests class
        #region Construtor

        static MRequests()
        {
            materialRequest = new List<MRequest>();
        }

        #endregion

        /// Methods of MRequests class
        #region Metodos

        /// Method used to add requests to a list
        public static int Add_MaterialRequest(MRequest m)
        {
            try
            {
                /// Add this material request
                materialRequest.Add(m);

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
