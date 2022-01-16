using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Trabalho_WEBAPI.Models;


namespace Trabalho_WEBAPI.Controllers
{
    [Route("vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        #region Attributes

        static Vehicles vehicle = new Vehicles();
        static VRequests vehicleRequest = new VRequests();
        static VRequestShowLists requestList = new VRequestShowLists();

        #endregion

        #region Methods

        /// <summary>
        /// Method used to search for vehicle
        /// </summary>
        /// <param name="zone">zone parameter</param>
        /// <returns>vehicle list of a zone</returns>
        [HttpGet]
        [Route("search/{zone}")]
        ///vehicle/search
        public IEnumerable<Vehicle> Vehicle_Search(string zone)
        {
            return vehicle.VehicleSearch(zone);
        }


        /// <summary>
        /// Methos used to request vehicle
        /// </summary>
        /// <param name="vRequest">vrequest parameter</param>
        [HttpPost]
        [Route("request")]
        ///vehicle/request
        public void Request_Vehicle(VRequest vRequest)
        {
            vehicleRequest.Vehicle_Request(vRequest);
        }


        /// <summary>
        /// Request history
        /// </summary>
        /// <returns>vehicle request history list</returns>
        [HttpGet]
        [Route("requestlist")]
        ///vehicle/requestlist
        public IEnumerable<VRequestShowList> Vehicle_RequestList()
        {
            return requestList.VehicleRequestList();
        }

        #endregion

    }
}