using System;
using System.Runtime.Serialization;

namespace Trabalho_WFC.Models
{
    /// <summary>
    /// Class that creates a patient
    /// </summary>
    [DataContract]
    public class Patient
    {

        /// <summary>
        /// Constructor of Patient class
        /// </summary>
        #region Constructor

        [DataMember]
        public string PatientUn { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        [DataMember]
        public string UnitName { get; set; }
        [DataMember]
        public string Contact { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public DateTime RegisterDate { get; set; }


        public Patient()
        {
            this.PatientUn = "";
            this.Name = "";
            this.Birthday = DateTime.Now;
            this.UnitName = "";
            this.Contact = "";
            this.Address = "";
            this.RegisterDate = DateTime.Now;
        }


        public Patient(string patientUn, string name, DateTime birthday, string unitName, string contact, string address, DateTime registerDate)
        {
            this.PatientUn = patientUn;
            this.Name = name;
            this.Birthday = birthday;
            this.UnitName = unitName;
            this.Contact = contact;
            this.Address = address;
            this.RegisterDate = registerDate;
        }

        #endregion

    }
}