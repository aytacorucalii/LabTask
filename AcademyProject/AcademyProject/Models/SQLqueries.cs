using AcademyProject.Helpers;
using System.Data.SqlClient;
using System.Data;

namespace AcademyProject.Models
{
    public static class SQLqueries
    {
        public static void GetInsertData(string command)
        {
            using (SqlConnection connection = new SqlConnection(ExtensionSql.connectionString))
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(command, connection);
                int result = insertCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Data inserted");
                }
                else
                {
                    Console.WriteLine("Problem occurred");
                }
            }
        }

        public static void GetSelectData(string command)
        {
            using (SqlConnection connection = new SqlConnection(ExtensionSql.connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    Console.WriteLine($"{item[0]} {item[2]}");
                }
            }
        }
        public static void GetDeleteData(string command)
        {
            using (SqlConnection connection = new SqlConnection(ExtensionSql.connectionString))
            {
                connection.Open();
                SqlCommand deleteCommand = new SqlCommand(command, connection);
                int result = deleteCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Data deleted");
                }
                else
                {
                    Console.WriteLine("Problem occurred");
                }
            }
        }
    }
}
