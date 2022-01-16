using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    public class MRequest
    {

        /// <summary>
        /// Constructor of MRequest class
        /// </summary>
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

        /// <summary>
        /// Method used to request a material
        /// </summary>
        /// <param name="mrequest">mrequest parameter</param>
        #region Methods

        public void MaterialRequest(MRequest mrequest)
        {
            try
            {
                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connection to database
                MySqlConnection connection = new(connectionString);

                /// Insert query
                string query = "INSERT INTO materialrequest(unit_name, material_id, material_amount) VALUE(@unit_name, @material_id, @material_amount)";

                /// Create a command to execute
                MySqlCommand command = new(query, connection);

                /// Instanciate parameters
                command.Parameters.Add("@unit_name", MySqlDbType.VarChar);
                command.Parameters["@unit_name"].Value = mrequest.UnitName;

                command.Parameters.Add("@material_id", MySqlDbType.Int32);
                command.Parameters["@material_id"].Value = mrequest.MaterialId;

                command.Parameters.Add("@material_amount", MySqlDbType.Int32);
                command.Parameters["@material_amount"].Value = mrequest.MaterialQuantity;

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