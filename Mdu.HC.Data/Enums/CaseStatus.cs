// -----------------------------------------------------------------------
// <copyright file="HealthStatus.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.Enum
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for CaseDocLocation
    /// </summary>
    public enum CaseDocLocation
    {
        /// <summary>
        /// CaseDocLocation - RecordSection
        /// </summary>
        [Description("RecordSection")]
        RecordSection = 1,

        /// <summary>
        /// CaseDocLocation - LawOfficer
        /// </summary>
        [Description("LawOfficer")]
        LawOfficer,

        /// <summary>
        /// CaseDocLocation - DisposedRoom
        /// </summary>
        [Description("DisposedRoom")]
        DisposedRoom

    }
}
