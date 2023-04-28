using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Data.Common;

namespace CIS_560_Project_Team_16.Models
{
    /// <summary>
    /// This class is just a test for getting SQL procedures to work from C#
    /// </summary>
    public class TestSql
    {
        public string test()
        {
            // String to connect to sql database
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=CIS560Project;Integrated Security=True";
            // Creating the actual connection
            SqlConnection connection = new SqlConnection(connectionString);
            // Set the command for the connection
            // First parameters is the name of the procedure that's on the first line of the procedure
            SqlCommand command = new SqlCommand("MovieDatabase.TestProc", connection);
            // Say that the command is a procedure
            command.CommandType = CommandType.StoredProcedure;

            // Put fullName into the @FullName variable in the SQL procedure
            string fullName = "Donkey Kong";
            command.Parameters.AddWithValue("@FullName", fullName);

            // Add the output parameter and set its size
            var p = command.Parameters.Add("@AlphabetName", SqlDbType.NVarChar, 128);
            p.Direction = ParameterDirection.Output;

            // Open the connection and execute the procedure
            connection.Open();
            command.ExecuteNonQuery();
            // Get the output parameter value
            string alphabetName = (string)p.Value;
            // Close the connection
            connection.Close();

            return alphabetName;
        }
    }
}
