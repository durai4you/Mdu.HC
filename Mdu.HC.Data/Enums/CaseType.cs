// -----------------------------------------------------------------------
// <copyright file="HealthStatus.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.Enum
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for Case Type
    /// </summary>
    public enum CaseType
    {
        /// <summary>
        /// HealthStatus - Excellent
        /// </summary>
        [Description("WA_WRIT_APPEAL")]
        WA_WRIT_APPEAL = 1,

        /// <summary>
        /// Case Type - WP_WRIT_PETITIN
        /// </summary>
        [Description("WP_WRIT_PETITIN")]
        WP_WRIT_PETITIN,

        /// <summary>
        /// Case Type - REVA_REVIEW_APPLICATION
        /// </summary>
        [Description("REVA_REVIEW_APPLICATION")]
        REVA_REVIEW_APPLICATION,

        /// <summary>
        /// Case Type - REVW_REVIEW_WRIT
        /// </summary>
        [Description("REVW_REVIEW_WRIT")]
        REVW_REVIEW_WRIT,

        /// <summary>
        /// Case Type - SA_SECOND_APPEAL
        /// </summary>
        [Description("SA_SECOND_APPEAL")]
        SA_SECOND_APPEAL,

        /// <summary>
        /// Case Type - AS_APPEAL_SUIT
        /// </summary>
        [Description("AS_APPEAL_SUIT")]
        AS_APPEAL_SUIT,

        /// <summary>
        /// HealthStatus - CMA_CIVIL_MISCELLANEOUS
        /// </summary>
        [Description("CMA_CIVIL_MISCELLANEOUS")]
        CMA_CIVIL_MISCELLANEOUS,

        /// <summary>
        /// Case Type - CRP_CIVIL_REVISION_PETITION
        /// </summary>
        [Description("CRP_CIVIL_REVISION_PETITION")]
        CRP_CIVIL_REVISION_PETITION,

        /// <summary>
        /// HealthStatus - CONT_AL_CONTEMPT_APPEAL
        /// </summary>
        [Description("CONT_AL_CONTEMPT_APPEAL")]
        CONT_AL_CONTEMPT_APPEAL,

        /// <summary>
        /// Case Type - CONT_APP_CONTEMPT_APPLICATION
        /// </summary>
        [Description("CONT_APP_CONTEMPT_APPLICATION")]
        CONT_APP_CONTEMPT_APPLICATION

    }
}
