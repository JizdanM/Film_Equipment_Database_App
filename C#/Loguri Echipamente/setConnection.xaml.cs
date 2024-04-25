using System.IO;
using System.Windows;
using System.Xml;
using Newtonsoft.Json;

namespace Loguri_Echipamente
{
    public partial class setConnection : Window
    {
        public setConnection()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (!txtServer.Equals("") && !txtLogin.Equals("") && !txtPass.Equals("") && !txtDatabase.Equals(""))
            {
                string connectionString = $"Host={txtServer.Text};Username={txtLogin.Text};Password={txtPass.Text};Database={txtDatabase.Text}";

                string json = File.ReadAllText("database.json");
                AppConfig appConfig = JsonConvert.DeserializeObject<AppConfig>(json);

                appConfig.ConnectionString = connectionString;

                string updatedJson = JsonConvert.SerializeObject(appConfig, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);
                File.WriteAllText("database.json", updatedJson);

                MessageBox.Show("Datele de conexiune au fost salvate!");
                Close();
            }
            else
            {
                MessageBox.Show("Introduceti toate datele!");
            }
        }
    }
}
