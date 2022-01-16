using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Trabalho_WEBAPI.Models;


namespace Trabalho_WEBAPI.Controllers
{
    [Route("order")]
    [ApiController]
    public class MaterialController : ControllerBase
    {

        #region Attributes

        static Materials materials = new Materials();
        static MRequests materialRequest = new MRequests();
        static MRequestShowLists requestList = new MRequestShowLists();

        #endregion

        #region Methods

        /// <summary>
        /// Material list
        /// </summary>
        /// <returns>materials list</returns>
        [HttpGet]
        [Route("material")]
        ///order/material
        public IEnumerable<Material> Material_List()
        {
            return materials.MaterialList();
        }


        /// <summary>
        /// Request material
        /// </summary>
        /// <param name="mRequest">mrequest parameter</param>
        [HttpPost]
        [Route("request")]
        ///order/request
        public void Request_Material(MRequest mRequest)
        {
            materialRequest.MaterialRequest(mRequest);
        }


        /// <summary>
        /// Edit material stock
        /// </summary>
        /// <param name="material">material parameter</param>
        [HttpPut]
        [Route("edit")]
        ///order/edit
        public void Edit_Material(Material material)
        {
            materials.EditMaterial(material);
        }


        /// <summary>
        /// Request history
        /// </summary>
        /// <returns>material request history list</returns>
        [HttpGet]
        [Route("requestlist")]
        ///order/requestlist
        public IEnumerable<MRequestShowList> Material_RequestList()
        {
            return requestList.MaterialRequestList();
        }

        #endregion

    }
}