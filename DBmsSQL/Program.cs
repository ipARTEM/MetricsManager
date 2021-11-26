using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace DBmsSQL
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString3 = "Server=ARTEM;Database=DapperT;Trusted_Connection=True;";

            string connectionString2 = "Server=ARTEM\\ARTEM;Database=Test98;User Id=sa;password=sa;Trusted_Connection=True;MultipleActiveResultSets=true";

            string connectionString = "Server=ARTEM\\MSSQL;Database=DapperT;Trusted_Connection=True;";

            string connectionString5 = "Server=ARTEM\\MSSQL;Initial Catalog=DapperT;Integrated Security=True";

            // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                await connection.OpenAsync();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // если подключение открыто
                if (connection.State == ConnectionState.Open)
                {
                    // закрываем подключение
                    await connection.CloseAsync();
                    Console.WriteLine("Подключение закрыто...");
                }
            }
            Console.WriteLine("Программа завершила работу.");
            Console.Read();
        }
    }
}
