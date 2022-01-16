using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    public class Patient
    {

        /// <summary>
        /// Cosntructor of Patient class
        /// </summary>
        #region Constructor

        public string PatientUn { get; set; }
        public string Name { get; set; }

        public Patient()
        {
            this.PatientUn = "";
            this.Name = "";
        }

        public Patient(string patientUn, string name)
        {
            this.PatientUn = patientUn;
            this.Name = name;
        }

        #endregion

    }


    public class Patients
    {

        #region Methods

        /// <summary>
        /// Method used to return patient information
        /// </summary>
        /// <param name="patient_un"></param>
        /// <returns>patient information</returns>
        public List<Patient> PatientInformation(string patient_un)
        {
            List<Patient> list = new();
            try
            {

                /// Connection String
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connect to database
                MySqlConnection connection = new MySqlConnection(connectionString);

                /// Select query
                string query = "SELECT * FROM patient WHERE patient_un = @patient_un";

                /// Creation of a command to execute
                MySqlCommand command = new(query, connection);

                /// Instanciate parâmetros
                command.Parameters.Add("@patient_un", MySqlDbType.VarChar);
                command.Parameters["@patient_un"].Value = patient_un;

                connection.Open();

                using (MySqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new Patient(read["patient_un"].ToString(), read["name"].ToString()));
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
