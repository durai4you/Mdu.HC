// -----------------------------------------------------------------------
// <copyright file="HealthStatus.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.Enum
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for Case Doc Allotted By
    /// </summary>
    public enum CaseDocAllottedBy
    {
        /// <summary>
        /// CaseDocAllottedBy - None
        /// </summary>
        [Description("None")]
        None = 0,
        /// <summary>
        /// CaseDocAllottedBy - Recorded Incharge
        /// </summary>
        [Description("Recorded Incharge")]
        RecordedIncharge = 1,

        /// <summary>
        /// CaseDocAllottedBy - Recorded Clerk
        /// </summary>
        [Description("Recorded Clerk")]
        RecordedClerk,

        /// <summary>
        /// CaseDocAllottedBy - Office Assistant
        /// </summary>
        [Description("Office Assistant")]
        OfficeAssistant
    }
}
