using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.IO;
using Npgsql;

namespace EquipmentDatabase
{
    internal class BaseDAO
    {
        private static string basePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();

        private static IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("databaseConfig.json")
                .Build();

        private string connectionString = configuration.GetConnectionString("MyConnectionString");

        public DataTable LoadData(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    return (dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return(null);
            }
        }

        public void InsertData(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Datele au fost adaugate cu succes");
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 23505)
                {
                    MessageBox.Show("Eroare, echipamentul nu a fost returnat.");
                }
                else
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
