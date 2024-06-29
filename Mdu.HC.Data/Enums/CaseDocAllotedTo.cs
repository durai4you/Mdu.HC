// -----------------------------------------------------------------------
// <copyright file="HealthStatus.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.Enum
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for CaseDoc Allotted To
    /// </summary>
    public enum CaseDocAllottedTo
    {
        /// <summary>
        /// CaseDocAllottedTo - Government Pleader
        /// </summary>
        [Description("Government Pleader")]
        GovernmentPleader = 1,

        /// <summary>
        /// CaseDocAllottedTo - Special Government Pleader
        /// </summary>
        [Description("Special Government Pleader")]
        SpecialGovernmentPleader,

        /// <summary>
        /// CaseDocAllottedTo - Government Advocate
        /// </summary>
        [Description("Government Advocate")]
        GovernmentAdvocate,

        /// <summary>
        /// CaseDocAllottedTo - Additional Advocate General
        /// </summary>
        [Description("Additional Advocate General")]
        AdditionalAdvocateGeneral

    }
}
