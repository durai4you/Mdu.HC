// -----------------------------------------------------------------------
// <copyright file="CaseDetailAccess.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace Mdu.HC.Data.DataAccess
{
    using System;
    using System.Data;
    using System.Data.OleDb;
    using Mdu.HC.Data.DataModel;
    using Mdu.HC.Data.Enum;
    using Mdu.HC.Data.Sql;

    /// <summary>
    /// Data access class for CaseDetail table
    /// </summary>
    public class CaseDetailAccess : ConnectionAccess, ICaseDetailAccess
    {
        /// <summary>
        /// Method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAllCaseDetails()
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ConnectionString);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlGetAllCaseDetails;

                // Fill the datatable from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Method to get club member by Id
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>Data row</returns>
        public DataRow GetCaseDetailsById(int id)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(this.ConnectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = Scripts.sqlGetCaseDetailsbyCaseId;

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Id", id);

                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                // Get the datarow from the table
                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }

        /// <summary>
        /// Method to search club members by multiple parameters
        /// </summary>
        /// <param name="caseID">occupation value</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        public DataTable SearchCaseDetails(object caseID, string operand)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ConnectionString);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = string.Format(Scripts.SqlSearchCaseDetails, operand);

                // Add the input parameters to the parameter collection
                oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@CaseID", caseID == null ? DBNull.Value : caseID);
                //oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@CaseDocLocation", caseDocLocation == null ? DBNull.Value : caseDocLocation);

                // Fill the table from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Method to add new member
        /// </summary>
        /// <param name="CaseDetail">club member model</param>
        /// <returns>true or false</returns>
        public bool AddCaseDetails(CaseDetailsModel CaseDetail)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                // Set the command object properties
                oleDbCommand.Connection = new OleDbConnection(this.ConnectionString);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = Scripts.SqlInsertCaseDetails;

                // Add the input parameters to the parameter collection
                //oleDbCommand.Parameters.AddWithValue("@Name", CaseDetail.Name);
                //oleDbCommand.Parameters.AddWithValue("@DateOfBirth", CaseDetail.DateOfBirth.ToShortDateString());
                //oleDbCommand.Parameters.AddWithValue("@Occupation", (int)CaseDetail.Occupation);
                //oleDbCommand.Parameters.AddWithValue("@MaritalStatus", (int)CaseDetail.MaritalStatus);
                //oleDbCommand.Parameters.AddWithValue("@HealthStatus", (int)CaseDetail.HealthStatus);
                //oleDbCommand.Parameters.AddWithValue("@Salary", CaseDetail.Salary);
                //oleDbCommand.Parameters.AddWithValue("@NumberOfChildren", CaseDetail.NumberOfChildren);

                // Open the connection, execute the query and close the connection
                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        /// <summary>
        /// Method to update club member
        /// </summary>
        /// <param name="CaseDetail">club member</param>
        /// <returns>true / false</returns>
        public bool UpdateCaseDetails(CaseDetailsModel CaseDetail)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new OleDbConnection(this.ConnectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = Scripts.sqlUpdateCaseDetails;

                // Add the input parameters to the parameter collection
                //dbCommand.Parameters.AddWithValue("@Name", CaseDetail.Name);
                //dbCommand.Parameters.AddWithValue("@DateOfBirth", CaseDetail.DateOfBirth.ToShortDateString());
                //dbCommand.Parameters.AddWithValue("@Occupation", (int)CaseDetail.Occupation);
                //dbCommand.Parameters.AddWithValue("@MaritalStatus", (int)CaseDetail.MaritalStatus);
                //dbCommand.Parameters.AddWithValue("@HealthStatus", (int)CaseDetail.HealthStatus);
                //dbCommand.Parameters.AddWithValue("@Salary", CaseDetail.Salary);
                //dbCommand.Parameters.AddWithValue("@NumberOfChildren", CaseDetail.NumberOfChildren);
                //dbCommand.Parameters.AddWithValue("@Id", CaseDetail.Id);

                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        /// <summary>
        /// Method to delete a club member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        public bool DeleteCaseDetails(int caseId)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new OleDbConnection(this.ConnectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = Scripts.sqlDeleteCaseDetails;

                // Add the input parameter to the parameter collection
                dbCommand.Parameters.AddWithValue("@CaseID", caseId);

                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}
