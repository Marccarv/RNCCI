using System.ServiceModel;
using Trabalho_WFC.Models;

namespace Trabalho_WFC.Services
{
    [ServiceContract]
    public interface IPatients
    {

        #region Methods

        /// <summary>
        /// Method used to register a patient
        /// </summary>
        [OperationContract]
        void RegisterPatient(Patient patient);

        #endregion

    }
}
