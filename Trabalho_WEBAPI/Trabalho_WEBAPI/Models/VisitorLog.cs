using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    /// <summary>
    /// Class that creates the visitor log
    /// </summary>
    public class VisitorLog
    {

        /// Constructor of VisitorLog class
        #region Constructor

        public string PatientUn { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }

        public VisitorLog()
        {
            this.PatientUn = "";
            this.TimeIn = "";
            this.TimeOut = "";
        }

        public VisitorLog(string patientUn, string timeIn, string timeOut)
        {
            this.PatientUn = patientUn;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
        }

        #endregion

    }


    public class VisitorLogs
    {

        #region Methods

        /// <summary>
        /// Patient Visit Log
        /// </summary>
        /// <param name="patient_un">patient utent number</param>
        /// <returns>patient visitor log</returns>
        public List<VisitorLog> PatientVisitLog(string patient_un)
        {
            List<VisitorLog> list = new();
            try
            {
                MySqlConnection con;

                /// Connection String
                string data_source = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connect to database
                con = new MySqlConnection(data_source);

                /// Select query
                string q = "SELECT * FROM visitor WHERE patient_un = @patient_un";

                /// Creation of a command to execute
                MySqlCommand co = new(q, con);

                /// Instancia parâmetros
                co.Parameters.Add("@patient_un", MySqlDbType.VarChar);
                co.Parameters["@patient_un"].Value = patient_un;

                con.Open();

                using (MySqlDataReader read = co.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new VisitorLog(read["patient_un"].ToString(), read["time_in"].ToString(), read["time_out"].ToString()));
                    }
                    con.Close();
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
