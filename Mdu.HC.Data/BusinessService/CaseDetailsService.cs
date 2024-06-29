// -----------------------------------------------------------------------
// <copyright file="CaseDetailsService.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.BusinessService
{
    using System.Data;
    using Mdu.HC.Data.DataAccess;
    using Mdu.HC.Data.DataModel;

    /// <summary>
    /// class to query the DataAccess, implements ICaseDetailsService interface
    /// </summary>
    public class CaseDetailsService : ICaseDetailsService
    {
        /// <summary>
        /// interface of CaseDetailsAccess
        /// </summary>
        private ICaseDetailAccess memberAccess;

        /// <summary>
        /// Initializes a new instance of the CaseDetailsService class
        /// </summary>
        public CaseDetailsService()
        {
            this.memberAccess = new CaseDetailAccess();
        }

        /// <summary>
        /// Service method to get club member by Id
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>Data row</returns>
        public DataRow GetCaseDetailsById(int id)
        {
            return this.memberAccess.GetCaseDetailsById(id);
        }

        /// <summary>
        /// Service method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAllCaseDetails()
        {            
            return this.memberAccess.GetAllCaseDetails();
        }

        /// <summary>
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="caseId">Case ID</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        public DataTable SearchCaseDetails(object caseID, string operand)
        {
            return this.memberAccess.SearchCaseDetails(caseID, operand);
        }        

        /// <summary>
        /// Service method to create new member
        /// </summary>
        /// <param name="CaseDetails">club member model</param>
        /// <returns>true or false</returns>
        public bool RegisterCaseDetails(CaseDetailsModel caseDetails)
        {
            return this.memberAccess.AddCaseDetails(caseDetails);
        }

        /// <summary>
        /// Service method to update club member
        /// </summary>
        /// <param name="CaseDetails">club member</param>
        /// <returns>true / false</returns>
        public bool UpdateCaseDetails(CaseDetailsModel caseDetails)
        {
            return this.memberAccess.UpdateCaseDetails(caseDetails);
        }

        /// <summary>
        /// Method to delete a club member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        public bool DeleteCaseDetails(int id)
        {
            return this.memberAccess.DeleteCaseDetails(id);
        }
    }
}
