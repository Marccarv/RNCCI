using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    public class VRequestShowList
    {

        /// <summary>
        /// Constrcutor of VRequestShowList class
        /// </summary>
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


    public class VRequestShowLists
    {

        #region Methods

        /// <summary>
        /// Method used to list the requested vehicles
        /// </summary>
        /// <returns>list of requested vehicles</returns>
        public List<VRequestShowList> VehicleRequestList()
        {
            List<VRequestShowList> list = new();
            try
            {

                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connection to database
                MySqlConnection connection = new(connectionString);

                /// Select query
                string query = "SELECT t.unit_name, r.request_time, v.vehicle_brand, v.vehicle_type FROM vehiclerequest r " +
                    "INNER JOIN team t USING(team_id) " +
                    "INNER JOIN vehicle v USING(plate) " +
                    "ORDER BY r.vehiclerequest_id DESC";

                /// Create command to execute
                MySqlCommand command = new(query, connection);

                /// Execute and read data
                connection.Open();
                using (MySqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new VRequestShowList(read["unit_name"].ToString(), read["request_time"].ToString(), read["vehicle_brand"].ToString(), read["vehicle_type"].ToString()));
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