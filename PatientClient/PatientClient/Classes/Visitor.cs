using System;
using System.Collections.Generic;

namespace PatientClient.Classes
{
    /// <summary>
    /// Class that creates a visitor
    /// </summary>
    public class Visitor
    {

        /// Constructor of Visitor class
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

    public static class Visitors
    {

        /// Attributes of Visitors class
        #region Atributos

        static List<Visitor> visitor;

        #endregion

        /// Constructor of Visitors class
        #region Construtor

        static Visitors()
        {
            visitor = new List<Visitor>();
        }

        #endregion

        /// Methods of Visitors class
        #region Metodos

        /// Method used to add a new visitor or regist a visitor out to a list
        public static int Add_Visitor(Visitor t)
        {
            try
            {
                /// Add this visitor to a list
                visitor.Add(t);

                return 1;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        #endregion

    }
}
