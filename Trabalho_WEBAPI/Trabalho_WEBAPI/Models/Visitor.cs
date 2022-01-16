using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    public class Visitor
    {
        /// <summary>
        /// Visitor constructor
        /// </summary>
        #region Constructor

        public string PatientUn { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }

        public Visitor()
        {
            this.PatientUn = "";
            this.TimeIn = DateTime.Now;
            this.TimeOut = DateTime.Now;
        }

        public Visitor(string patientUn, DateTime timeIn, DateTime timeOut)
        {
            this.PatientUn = patientUn;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
        }

        #endregion

    }


    public class Visits
    {

        #region Methods

        /// <summary>
        /// Create a new visit
        /// </summary>
        /// <param name="visitor">Visitor model</param>
        public void CreateVisitor(Visitor visitor)
        {
            try
            {
                /// ConnectionString
                string cs = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connect to database
                MySqlConnection con = new(cs);

                /// Insert Query
                string q = "insert into visitor (patient_un, time_in, time_out) values(@patient_un, @time_in, @time_out);";

                /// Creation of a command to execute
                MySqlCommand co = new(q, con);

                /// Instantiate parameters
                co.Parameters.Add("@patient_un", MySqlDbType.VarChar);
                co.Parameters["@patient_un"].Value = visitor.PatientUn;

                /// DATETIME MYSQL -> VARCHAR
                co.Parameters.Add("@time_in", MySqlDbType.VarChar);
                co.Parameters["@time_in"].Value = visitor.TimeIn;

                co.Parameters.Add("@time_out", MySqlDbType.VarChar);
                co.Parameters["@time_out"].Value = visitor.TimeOut;

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


        /// <summary>
        /// Update the new visit with out time
        /// </summary>
        /// <param name="visitor">Visitor model</param>
        public void EditVisitor(Visitor visitor)
        {
            try
            {
                /// ConnectionString
                string cs = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connect to database
                MySqlConnection con = new(cs);

                /// Update query
                string q = "UPDATE visitor SET time_out='" + visitor.TimeOut + "' WHERE patient_un='" + visitor.PatientUn + "' ORDER BY visitor_id DESC LIMIT 1";

                /// Creation of a command to execute
                MySqlCommand co = new(q, con);

                /// Instantiate parameters
                co.Parameters.Add("@patient_un", MySqlDbType.VarChar);
                co.Parameters["@patient_un"].Value = visitor.PatientUn;

                co.Parameters.Add("@time_in", MySqlDbType.VarChar);
                co.Parameters["@time_in"].Value = visitor.TimeIn;

                co.Parameters.Add("@time_out", MySqlDbType.VarChar);
                co.Parameters["@time_out"].Value = visitor.TimeOut;

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
