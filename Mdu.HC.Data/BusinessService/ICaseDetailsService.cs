// -----------------------------------------------------------------------
// <copyright file="ICaseDetailsService.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.BusinessService
{
    using System.Data;
    using Mdu.HC.Data.DataModel;

    /// <summary>
    /// Interface ICaseDetailsService
    /// </summary>
    public interface ICaseDetailsService
    {
        /// <summary>
        /// Method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        DataRow GetCaseDetailsById(string Id);

        /// <summary>
        /// Service method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        DataTable GetAllCaseDetails();

        /// <summary>
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="caseID">Case ID</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        DataTable SearchCaseDetails(object caseID, string operand);       

        /// <summary>
        /// Service method to create new member
        /// </summary>
        /// <param name="CaseDetails">club member model</param>
        /// <returns>true or false</returns>
        bool RegisterCaseDetails(CaseDetailsModel caseDetails);

        /// <summary>
        /// Method to update club member details
        /// </summary>
        /// <param name="CaseDetails">club member</param>
        /// <returns></returns>
        bool UpdateCaseDetails(CaseDetailsModel caseDetails);

        /// <summary>
        /// Method to delete a club member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        bool DeleteCaseDetails(string caseId);
    }
}
