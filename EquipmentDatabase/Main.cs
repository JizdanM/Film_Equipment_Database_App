using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentDatabase
{
    public partial class formMain : Form
    {
        private static string basePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();

        private static IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("databaseConfig.json")
                .Build();
        
        private string connectionString = configuration.GetConnectionString("MyConnectionString");
        
        public formMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void echipamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM Equipment");
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM Category");
        }

        private void eleviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM Students");
        }

        private void loguriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM Logs");
        }

        private void stripAddCategory_Click(object sender, EventArgs e)
        {
            formAddCategory addCategory = new formAddCategory();
            addCategory.Show();
        }

        private void LoadData(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataOutput.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
