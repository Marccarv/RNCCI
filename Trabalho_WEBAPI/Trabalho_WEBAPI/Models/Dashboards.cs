using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{

    #region Dashboard Patients

    public class DPatient
    {

        /// <summary>
        /// Constructor of DPatient class
        /// </summary>
        #region Constructor

        public string UnitName { get; set; }
        public int Count { get; set; }

        public DPatient()
        {
            this.UnitName = "";
            this.Count = 0;
        }

        public DPatient(string unitName, int count)
        {
            this.UnitName = unitName;
            this.Count = count;
        }

        #endregion

    }

    public class DPatients
    {

        /// <summary>
        /// Method used to create a patient dashboard
        /// </summary>
        /// <returns>patients list</returns>
        #region Methods

        public List<DPatient> DashboardPatients()
        {
            List<DPatient> list = new();
            try
            {

                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connection do database
                MySqlConnection connection = new(connectionString);

                /// Select query
                string query = "SELECT unit_name, COUNT(*) FROM patient GROUP BY unit_name";

                /// Create a command to execute
                MySqlCommand command = new(query, connection);

                /// Execute and read data
                connection.Open();
                using (MySqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new DPatient(read["unit_name"].ToString(), Convert.ToInt32(read["COUNT(*)"].ToString())));
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

    #endregion

    #region Dashboard Visits

    public class DVisit
    {

        /// <summary>
        /// Constructor of DVisit class
        /// </summary>
        #region Constructor

        public string UnitName { get; set; }
        public int Count { get; set; }

        public DVisit()
        {
            this.UnitName = "";
            this.Count = 0;
        }

        public DVisit(string unitName, int count)
        {
            this.UnitName = unitName;
            this.Count = count;
        }

        #endregion

    }


    public class DVisits
    {

        #region Metodos

        /// <summary>
        /// Method used to create a visits dashboard
        /// </summary>
        /// <returns>visits list</returns>
        public List<DVisit> DashboardVisits()
        {
            List<DVisit> list = new();
            try
            {

                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connection to database
                MySqlConnection connection = new(connectionString);

                /// Select Query
                string query = "SELECT p.unit_name Unidade, COUNT(p.unit_name) Visitas FROM visitor INNER JOIN patient p USING (patient_un) GROUP BY p.unit_name ORDER BY COUNT(p.unit_name) DESC";

                /// Create a command to execute
                MySqlCommand command = new(query, connection);

                /// Execute and read data
                connection.Open();
                using (MySqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new DVisit(read["Unidade"].ToString(), Convert.ToInt32(read["Visitas"].ToString())));
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

    #endregion

    #region Dashboard Vehicles

    public class DVehicle
    {

        /// <summary>
        /// Constructor of DVehicle class
        /// </summary>
        #region Constructor

        public string UnitName { get; set; }
        public string TeamId { get; set; }

        public DVehicle()
        {
            this.UnitName = "";
            this.TeamId = "";
        }

        public DVehicle(string unitName, string teamId)
        {
            this.UnitName = unitName;
            this.TeamId = teamId;
        }

        #endregion

    }


    public class DVehicles
    {

        #region Metodos

        /// <summary>
        /// Method used to create a vehicle dashboard
        /// </summary>
        /// <returns>vehicle list</returns>
        public List<DVehicle> DashboardVehicles()
        {
            List<DVehicle> list = new();
            try
            {

                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Conexao a BD
                MySqlConnection connection = new(connectionString);

                /// Select Query
                string query = "SELECT t.unit_name Unidade, COUNT(vr.team_id) Requisicoes FROM vehiclerequest vr INNER JOIN team t USING(team_id) GROUP BY t.unit_name ORDER BY COUNT(vr.team_id) ASC;";

                /// Create a command to execute
                MySqlCommand command = new(query, connection);

                /// Execute and read data
                connection.Open();
                using (MySqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new DVehicle(read["Unidade"].ToString(), read["Requisicoes"].ToString()));
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

    #endregion

}