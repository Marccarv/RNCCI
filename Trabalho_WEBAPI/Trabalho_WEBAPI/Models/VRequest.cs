using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    public class VRequest
    {

        /// <summary>
        /// Constructor of VRequest class
        /// </summary>
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

        /// <summary>
        /// VRequests Methods
        /// </summary>
        /// <param name="vrequest">vrequest paratemeter</param>
        #region Methods

        public void Vehicle_Request(VRequest vrequest)
        {
            try
            {
                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connection to databse
                MySqlConnection connection = new(connectionString);

                /// Insert query
                string query = "INSERT INTO vehiclerequest (team_id, plate, request_time, zone) VALUES(@team_id, @plate, @request_time, @zone);";

                /// Create a command to execute
                MySqlCommand command = new(query, connection);

                /// Instanciate parameters
                command.Parameters.Add("@team_id", MySqlDbType.VarChar);
                command.Parameters["@team_id"].Value = vrequest.TeamId;

                command.Parameters.Add("@plate", MySqlDbType.VarChar);
                command.Parameters["@plate"].Value = vrequest.Plate;

                command.Parameters.Add("@request_time", MySqlDbType.VarChar);
                command.Parameters["@request_time"].Value = vrequest.RequestTime;

                command.Parameters.Add("@zone", MySqlDbType.VarChar);
                command.Parameters["@zone"].Value = vrequest.Zone;

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
