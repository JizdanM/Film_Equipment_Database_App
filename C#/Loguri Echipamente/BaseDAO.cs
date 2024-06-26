﻿using Loguri_Echipamente;
using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace DatabaseTest
{
    internal class BaseDAO
    {
        private static string GetConnectionString()
        {
            try
            {
                string json = File.ReadAllText("database.json");
                AppConfig config = JsonSerializer.Deserialize<AppConfig>(json);

                return config.ConnectionString;
            }
            catch (Exception e)
            {
                MessageBox.Show("A aparut o eroare:\n" + e.Message);
                return null;
            }
        }

        public DataTable LoadData(string query)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    connection.Close();
                    return (dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
                return (null);
            }
        }

        public void InsertData(string query)
        {
            string connectionString = GetConnectionString();
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
            catch (NpgsqlException ex)
            {
                if (ex.ErrorCode == 23505)
                {
                    MessageBox.Show("Eroare, echipamentul nu a fost returnat.");
                }
                else
                {
                    MessageBox.Show($"Eraore a bazei de date: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        public void UpdateReturned(int id)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    NpgsqlCommand command = new NpgsqlCommand("UPDATE Logs SET returned=true WHERE id=" + id, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Echipamentul a fost returnat.");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        public void BackupDatabase(string outputPath)
        {
            try
            {
                string pgDumpPath = @"C:\Program Files\PostgreSQL\15\bin\pg_dump.exe";

                string databaseName = "Echipamente";

                string command1 = $"-U postgres -F p -b -v -f \"{outputPath}\\.sql\" {databaseName}";
                string command2 = $"-U postgres -F c -b -v -f \"{outputPath}\\.backup\" {databaseName}";

                using (Process process1 = new Process())
                {
                    process1.StartInfo.FileName = pgDumpPath;
                    process1.StartInfo.Arguments = command1;
                    process1.StartInfo.UseShellExecute = false;
                    process1.StartInfo.RedirectStandardOutput = true;
                    process1.StartInfo.CreateNoWindow = true;
                    process1.Start();
                    process1.WaitForExit();
                }

                using (Process process2 = new Process())
                {
                    process2.StartInfo.FileName = pgDumpPath;
                    process2.StartInfo.Arguments = command2;
                    process2.StartInfo.UseShellExecute = false;
                    process2.StartInfo.RedirectStandardOutput = true;
                    process2.StartInfo.CreateNoWindow = true;
                    process2.Start();
                    process2.WaitForExit();
                }

                MessageBox.Show($"Backup-ul a fost creat cu success. \n\nBackup-ul se afla aici - {outputPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la crearea backup-ului: " + ex.Message);
            }
        }
    }
}
