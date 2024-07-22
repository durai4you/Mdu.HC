// -----------------------------------------------------------------------
// <copyright file="ClubMemberModel.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.DataModel
{
    using System;
    using Mdu.HC.Data.Enum;

    /// <summary>
    /// Member model
    /// </summary>
    public class CaseDetailsModel
    {
        /// <summary>
        /// Gets or sets member CaseID
        /// </summary>
        public string CaseID { get; set; }

        /// <summary>
        /// Gets or sets member CaseType
        /// </summary>
        public CaseType CaseType { get; set; }

        /// <summary>
        /// Gets or sets member CaseCatogory
        /// </summary>
        public int CaseCatogory { get; set; }

        /// <summary
        /// Gets or sets member RackID
        /// </summary>
        public int RackID { get; set; }

        /// <summary
        /// Gets or sets member CaseStatus
        /// </summary>
        public CaseDocLocation CaseStatus { get; set; }

        /// <summary
        /// Gets or sets member CounterFiled
        /// </summary>
        public Boolean CounterFiled { get; set; }

        /// <summary
        /// Gets or sets member CaseDocLocation
        /// </summary>
        public CaseDocLocation CaseDocLocation { get; set; }

        /// <summary
        /// Gets or sets member CaseDocAllottedTo
        /// </summary>
        public CaseDocAllottedTo CaseDocAllottedTo { get; set; }

        /// <summary
        /// Gets or sets member CaseDocAllottedBy
        /// </summary>
        public CaseDocAllottedBy CaseDocAllottedBy { get; set; }

        /// <summary
        /// Gets or sets member CaseDocAllottedToName
        /// </summary>
        public string CaseDocAllottedToName { get; set; }

        /// <summary
        /// Gets or sets member CaseDocAllottedByName
        /// </summary>
        public string CaseDocAllottedByName { get; set; }

        /// <summary>
        /// Gets or sets date of DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets date of DateCreated
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary
        /// Gets or sets member CreatedUser
        /// </summary>
        public string CreatedUser { get; set; }

        /// <summary
        /// Gets or sets member LastModifiedUser
        /// </summary>
        public string LastModifiedUser { get; set; }

        /// <summary
        /// Gets or sets member DisposedRacKNum
        /// </summary>
        public int DisposedRacKNum { get; set; }

        /// <summary
        /// Gets or sets member DisposedBundleNum
        /// </summary>
        public int DisposedBundleNum { get; set; }


    }
}
