// -----------------------------------------------------------------------
// <copyright file="Scripts.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.Sql
{
    /// <summary>
    /// DBConstants static class contains sql string constants
    /// </summary>
    public static class Scripts
    {

        /// <summary>
        /// sql to insert a Case details
        /// </summary>
        public static readonly string SqlInsertCaseDetails = "Insert Into" +
            " DocManager(CaseID,CaseType,RackID,CaseDocLocation,DateCreated,  CreatedUser)" +
            " Values(@CaseID, @CaseType, @RackID, @CaseDocLocation, @DateCreated,  @CreatedUser)";

            //" DocManager(CaseID,CaseType,CaseCatogory,RackID,CaseStatus,CounterFiled,CaseDocLocation,CaseDocAllottedTo,CaseDocAllottedBy,CaseDocAllottedToName,CaseDocAllottedByName,DateCreated,DateUpdated,CreatedUser,LastModifiedUser,DisposedRacKNum,DisposedBundleNum)" +
            //" Values(@CaseID, @CaseType, @CaseCatogory, @RackID, @CaseStatus, @CounterFiled, @CaseDocLocation, @CaseDocAllottedTo, @CaseDocAllottedBy, @CaseDocAllottedToName, @CaseDocAllottedByName, @DateCreated, @DateUpdated, @CreatedUser, @LastModifiedUser, @DisposedRacKNum, @DisposedBundleNum)";

        /// <summary>
        /// Sql to get a case details by Id
        /// </summary>
        public static readonly string sqlGetCaseDetailsbyCaseId = "Select" +
            " CaseID,CaseType,CaseCatogory,RackID,CaseStatus,CounterFiled,CaseDocLocation,CaseDocAllottedTo,CaseDocAllottedBy,CaseDocAllottedToName,CaseDocAllottedByName,DateCreated,DateUpdated,CreatedUser,LastModifiedUser,DisposedRacKNum,DisposedBundleNum" +
            " From DocManager Where CaseID = @CaseID";

        /// <summary>
        /// sql to update case details
        /// </summary>
        public static readonly string sqlUpdateCaseDetails = "Update DocManager " +
            " Set [CaseType] = @CaseType, [CaseCatogory] = @CaseCatogory, [RackID] = @RackID, [CaseStatus] = @CaseStatus, " +
            " [CounterFiled] = @CounterFiled, [CaseDocLocation] = @CaseDocLocation, [CaseDocAllottedTo] = @CaseDocAllottedTo, " +
            " [CaseDocAllottedBy] = @CaseDocAllottedBy, [CaseDocAllottedToName] = @CaseDocAllottedToName, [CaseDocAllottedByName] = @CaseDocAllottedByName, " +
            " [DateCreated] = @DateCreated, [DateUpdated] = @DateUpdated, [CreatedUser] = @CreatedUser, " +
            " [LastModifiedUser] = @LastModifiedUser, [DisposedRacKNum] = @DisposedRacKNum, [DisposedBundleNum] = @DisposedBundleNum, " +
            " Where ([Id] = @Id)";


        /// <summary>
        /// Sql to get all all case details
        /// </summary>
        public static readonly string SqlGetAllCaseDetails = "Select" +
            " CaseID,CaseType,CaseCatogory,RackID,CaseStatus,CounterFiled,CaseDocLocation,CaseDocAllottedTo,CaseDocAllottedBy,CaseDocAllottedToName,CaseDocAllottedByName,DateCreated,DateUpdated,CreatedUser,LastModifiedUser,DisposedRacKNum,DisposedBundleNum" +
            " From DocManager";


        /// <summary>
        /// sql to search for Case details
        /// </summary>
        public static readonly string SqlSearchCaseDetails = "Select " +
            " CaseID,CaseType,CaseCatogory,RackID,CaseStatus,CounterFiled,CaseDocLocation,CaseDocAllottedTo,CaseDocAllottedBy,CaseDocAllottedToName,CaseDocAllottedByName,DateCreated,DateUpdated,CreatedUser,LastModifiedUser,DisposedRacKNum,DisposedBundleNum" +
            " From DocManager Where (@CaseType Is NULL OR @CaseType = CaseType) {0}" +
            " (@CaseDocLocation Is NULL OR @CaseDocLocation = CaseDocLocation)";


        /// <summary>
        /// sql to delete a Case detail record
        /// </summary>
        public static readonly string sqlDeleteCaseDetails = "Delete From DocManager Where (CaseID = @CaseID)";

        /// <summary>
        /// Sql to get a club member details by Id
        /// </summary>
        public static readonly string sqlGetClubMemberById = "Select" +
            " Id, Name, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember Where Id = @Id";

        /// <summary>
        /// Sql to get all club members
        /// </summary>
        public static readonly string SqlGetAllClubMembers = "Select" +
            " Id, Name, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember";

        /// <summary>
        /// sql to insert a club member details
        /// </summary>
        public static readonly string SqlInsertClubMember = "Insert Into" +
            " ClubMember(Name, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren)" +
            " Values(@Name, @DateOfBirth, @Occupation, @MaritalStatus, @HealthStatus, @Salary, @NumberOfChildren)";

        /// <summary>
        /// sql to search for club members
        /// </summary>
        public static readonly string SqlSearchClubMembers = "Select " +
            " Id, Name, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember Where (@Occupation Is NULL OR @Occupation = Occupation) {0}" +
            " (@MaritalStatus Is NULL OR @MaritalStatus = MaritalStatus)";

        /// <summary>
        /// sql to update club member details
        /// </summary>
        public static readonly string sqlUpdateClubMember = "Update ClubMember " +
            " Set [Name] = @Name, [DateOfBirth] = @DateOfBirth, [Occupation] = @Occupation, [MaritalStatus] = @MaritalStatus, " +
            " [HealthStatus] = @HealthStatus, [Salary] = @Salary, [NumberOfChildren] = @NumberOfChildren Where ([Id] = @Id)";

        /// <summary>
        /// sql to delete a club member record
        /// </summary>
        public static readonly string sqlDeleteClubMember = "Delete From ClubMember Where (Id = @Id)";
    }
}
