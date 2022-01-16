using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using Trabalho_WFC.Models;

namespace Trabalho_WFC.Services
{
    public class Patients : IPatients
    {

        /// <summary>
        /// Method used to regist a patient in databse
        /// </summary>
        /// <param name="patient">patient parameter with patient credentials</param>
        #region Register

        public void RegisterPatient(Patient patient)
        {
            try
            {
                /// ConnectionString
                string cs = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connect to database
                MySqlConnection con = new MySqlConnection(cs);

                /// Query commands
                string q = "INSERT INTO patient(patient_un, name, birthday, unit_name, contact, address, register_date)" +
                    " values(@patient_un, @name, @birthday, @unit_name, @contact, @address, @register_date);";

                /// Command to execute
                MySqlCommand co = new MySqlCommand(q, con);

                /// Parameters needed
                co.Parameters.Add("@patient_un", MySqlDbType.VarChar);
                co.Parameters["@patient_un"].Value = patient.PatientUn;

                co.Parameters.Add("@name", MySqlDbType.VarChar);
                co.Parameters["@name"].Value = patient.Name;

                co.Parameters.Add("@birthday", MySqlDbType.VarChar);
                co.Parameters["@birthday"].Value = patient.Birthday;

                co.Parameters.Add("@unit_name", MySqlDbType.VarChar);
                co.Parameters["@unit_name"].Value = patient.UnitName;

                co.Parameters.Add("@contact", MySqlDbType.VarChar);
                co.Parameters["@contact"].Value = patient.Contact;

                co.Parameters.Add("@address", MySqlDbType.VarChar);
                co.Parameters["@address"].Value = patient.Address;

                co.Parameters.Add("@register_date", MySqlDbType.VarChar);
                co.Parameters["@register_date"].Value = patient.RegisterDate;

                con.Open();

                /// Insert data
                if (co.ExecuteNonQuery() != 1)
                {
                    throw new InvalidProgramException();
                }

                con.Close();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        #endregion

    }
}