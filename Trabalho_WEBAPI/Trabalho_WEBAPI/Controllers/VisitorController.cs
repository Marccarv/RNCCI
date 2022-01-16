using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Trabalho_WEBAPI.Models;


namespace Trabalho_WEBAPI.Controllers
{
    [Route("visits")]
    [ApiController]
    public class VisitorController : ControllerBase
    {

        #region Attributes

        static Visits visits = new Visits();
        static VisitorLogs visitsLog = new VisitorLogs();
        static Patients patient = new Patients();

        #endregion

        #region Methods

        /// <summary>
        /// Register visitor in
        /// </summary>
        /// <param name="visit">visit parameter</param>
        [HttpPost]
        [Route("create")]
        ///visits/create
        public void Create_Visitor(Visitor visit)
        {
            visits.CreateVisitor(visit);
        }


        /// <summary>
        /// Register visitor out
        /// </summary>
        /// <param name="visit">visit parameter</param>
        [HttpPut]
        [Route("edit")]
        ///visits/edit
        public void Edit_Visitor(Visitor visit)
        {
            visits.EditVisitor(visit);
        }


        /// <summary>
        /// Patient visit log
        /// </summary>
        /// <param name="patient_un">patient un parameter</param>
        /// <returns>patient visits log</returns>
        [HttpGet]
        [Route("log/{patient_un}")]
        ///visits/log
        public IEnumerable<VisitorLog> Patient_VisitLog(string patient_un)
        {
            return visitsLog.PatientVisitLog(patient_un);
        }


        /// <summary>
        /// Patient information
        /// </summary>
        /// <param name="patient_un">patient un parameter</param>
        /// <returns>patient information</returns>
        [HttpGet]
        [Route("patientinfo/{patient_un}")]
        ///visits/patientinfo
        public IEnumerable<Patient> Patient_Information(string patient_un)
        {
            return patient.PatientInformation(patient_un);
        }

        #endregion

    }
}
