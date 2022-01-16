namespace PatientClient.Classes
{
    /// <summary>
    /// Class used to show the list of material requests
    /// </summary>
    public class MRequestShowList
    {

        /// Constructor of MRequestShowList class
        #region Constructor

        public string UnitName { get; set; }
        public string MaterialName { get; set; }
        public int MaterialQuantity { get; set; }

        public MRequestShowList()
        {
            this.UnitName = "";
            this.MaterialName = "";
            this.MaterialQuantity = 0;
        }

        public MRequestShowList(string unitName, string materialName, int materialQuantity)
        {
            this.UnitName = unitName;
            this.MaterialName = materialName;
            this.MaterialQuantity = materialQuantity;
        }

        #endregion

    }
}