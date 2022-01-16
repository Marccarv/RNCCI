using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Trabalho_WEBAPI.Models;


namespace Trabalho_WEBAPI.Controllers
{
    [Route("dashboard")]
    [ApiController]
    public class DashboardController : ControllerBase
    {

        #region Attributes

        static DPatients dashboardPatient = new DPatients();
        static DVisits dashboardVisits = new DVisits();
        static DVehicles dashboardVehicle = new DVehicles();

        #endregion

        #region Methods

        /// <summary>
        /// Method used to list patients number in each unit
        /// </summary>
        /// <returns>patient list</returns>
        [HttpGet]
        [Route("patients")]
        ///dashboard/patients
        public IEnumerable<DPatient> Dashboard_Patients()
        {
            return dashboardPatient.DashboardPatients();
        }


        /// <summary>
        /// Method used to list visits
        /// </summary>
        /// <returns>visits list</returns>
        [HttpGet]
        [Route("visits")]
        ///dashboard/visits
        public IEnumerable<DVisit> Dashboard_Visits()
        {
            return dashboardVisits.DashboardVisits();
        }


        /// <summary>
        /// Method used to list vehicles
        /// </summary>
        /// <returns>vehicle list</returns>
        [HttpGet]
        [Route("vehicles")]
        ///dashboard/visits
        public IEnumerable<DVehicle> Dashboard_Vehicles()
        {
            return dashboardVehicle.DashboardVehicles();
        }

        #endregion

    }
}
