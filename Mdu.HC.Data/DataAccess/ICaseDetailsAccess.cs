// -----------------------------------------------------------------------
// <copyright file="ICaseAccess.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.DataAccess
{
    using System.Data;
    using Mdu.HC.Data.DataModel;

    /// <summary>
    /// Interface ICaseDetailsAccess
    /// </summary>
    public interface ICaseDetailAccess
    {

        /// <summary>
        /// Method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        DataRow GetCaseDetailsById(string caseId);

        /// <summary>
        /// Method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        DataTable GetAllCaseDetails();

        /// <summary>
        /// Method to search club members by multiple parameters
        /// </summary>
        /// <param name="caseID">Case ID</param>
        /// <param name="operand">AND OR</param>
        /// <returns>Data table</returns>
        DataTable SearchCaseDetails(object caseID, string operand);

        /// <summary>
        /// Method to create new member
        /// </summary>
        /// <param name="CaseDetails">club member model</param>
        /// <returns>true or false</returns>
        bool AddCaseDetails(CaseDetailsModel caseDetails);

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
        bool DeleteCaseDetails(int id);
    }
}
