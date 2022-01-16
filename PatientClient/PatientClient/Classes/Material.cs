using System;
using System.Collections.Generic;

namespace PatientClient.Classes
{
    /// <summary>
    /// Class that creates a material
    /// </summary>
    public class Material
    {

        /// Constructor of Material class
        #region Constructor

        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public int MaterialStock { get; set; }

        public Material()
        {
            this.MaterialId = 0;
            this.MaterialName = "";
            this.MaterialStock = 0;
        }

        public Material(int materialId, string materialName, int materialStock)
        {
            this.MaterialId = materialId;
            this.MaterialName = materialName;
            this.MaterialStock = materialStock;
        }

        #endregion

    }

    /// <summary>
    /// Class used to create a list of materials
    /// </summary>
    public class Materials
    {

        /// Attributes of Materials class
        #region Attributes

        static List<Material> material;

        #endregion

        /// Constructor of Materials class
        #region Construtor

        static Materials()
        {
            material = new List<Material>();
        }

        #endregion

        /// Methods of Materials class
        #region Metodos

        /// Method used to add materials to a list 
        public static int Add_Material(Material m)
        {
            try
            {
                /// Add this material
                material.Add(m);

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
