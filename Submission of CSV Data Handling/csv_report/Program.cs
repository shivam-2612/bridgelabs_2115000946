using System;
using System.Data.SqlClient;
using System.IO;

class GenerateCSVFromDB
{
    static void Main()
    {
        string connectionString = "your_connection_string_here";
        string filePath = "employee_report.csv";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("EmployeeID,Name,Department,Salary");
                while (reader.Read())
                {
                    string line = $"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
