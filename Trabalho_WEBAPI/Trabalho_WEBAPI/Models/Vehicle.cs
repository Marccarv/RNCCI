using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    public class Vehicle
    {

        /// <summary>
        /// Constructor of Vehicle class
        /// </summary>
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


    public class Vehicles
    {

        #region Methods

        /// <summary>
        /// Method user to search for a vehicle in a zone
        /// </summary>
        /// <param name="zone"></param>
        /// <returns>list of vehicles in a zone</returns>
        public List<Vehicle> VehicleSearch(string zone)
        {
            List<Vehicle> list = new();
            try
            {
                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connect to database
                MySqlConnection connection = new(connectionString);

                /// Select query
                string query = "SELECT * from vehicle WHERE zone = @zone";

                /// Create a command to execute
                MySqlCommand command = new(query, connection);

                /// Instanciate parameters
                command.Parameters.Add("@zone", MySqlDbType.VarChar);
                command.Parameters["@zone"].Value = zone;

                connection.Open();

                using (MySqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new Vehicle(read["vehicle_brand"].ToString(), read["plate"].ToString(), read["vehicle_type"].ToString(), read["zone"].ToString()));
                    }
                    connection.Close();
                }
                return list;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return list;
            }
        }

        #endregion

    }
}
