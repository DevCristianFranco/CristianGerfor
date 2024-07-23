using System;
using Microsoft.Data.SqlClient; // Asegúrate de usar Microsoft.Data.SqlClient

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cadena de conexión a la base de datos SQL Server
            string connectionString = "Server=DESKTOP-G90UKSR\\SQLEXPRESS;Database=Products;User Id=sa;Password=123456789;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Realizar consulta para obtener productos con precio mayor a 10
                string selectQuery = "SELECT * FROM Products WHERE Price > 10;";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]}, Name: {reader["Name"]}, Description: {reader["Description"]}, Price: {reader["Price"]}");
                        }
                    }
                }
            }

            Console.WriteLine("Operación completada. Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}