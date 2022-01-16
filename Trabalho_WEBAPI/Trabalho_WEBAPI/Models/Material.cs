using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    public class Material
    {

        /// <summary>
        /// Constructor of Material class
        /// </summary>
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


    public class Materials
    {

        #region Methods
        /// <summary>
        /// Method used to list the materials
        /// </summary>
        /// <returns>Materials list</returns>
        public List<Material> MaterialList()
        {
            List<Material> list = new();
            try
            {

                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connection to database
                MySqlConnection connextion = new(connectionString);

                /// Select query
                string query = "SELECT * FROM material;";

                /// Create a command to execute
                MySqlCommand command = new(query, connextion);

                /// Execute and read data
                connextion.Open();
                using (MySqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new Material(Convert.ToInt32(read["material_id"].ToString()), read["material_name"].ToString(), Convert.ToInt32(read["material_amount"].ToString())));
                    }
                    connextion.Close();
                }
                return list;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return list;
            }
        }


        /// <summary>
        /// Method used to edit a material stock
        /// </summary>
        /// <param name="material">material parameter</param>
        public void EditMaterial(Material material)
        {
            try
            {
                /// ConnectionString
                string cs = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connect to database
                MySqlConnection connection = new(cs);

                /// Update query
                string query = "UPDATE material SET material_amount = (material_amount - '" + material.MaterialStock + "') WHERE material_id = '" + material.MaterialId + "'";


                /// Creation of a command to execute
                MySqlCommand command = new(query, connection);

                /// Instantiate parameters
                command.Parameters.Add("@material_id", MySqlDbType.Int32);
                command.Parameters["@material_id"].Value = material.MaterialId;

                command.Parameters.Add("@material_name", MySqlDbType.VarChar);
                command.Parameters["@material_name"].Value = material.MaterialName;

                command.Parameters.Add("@material_amount", MySqlDbType.Int32);
                command.Parameters["@material_amount"].Value = material.MaterialStock;

                connection.Open();

                /// Insert data
                if (command.ExecuteNonQuery() != 1)
                {
                    throw new InvalidProgramException();
                }

                connection.Close();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        #endregion

    }
}
