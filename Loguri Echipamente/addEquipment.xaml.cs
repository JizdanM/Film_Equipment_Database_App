using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DatabaseTest
{
    /// <summary>
    /// The window for the user to insert the data for adding a new equipment to the database
    /// </summary>
    public partial class addEquipment : Window
    {
        private BaseDAO DAO = new BaseDAO();
        public string EquipmentName;
        public int EquipmentCategory;

        public addEquipment()
        {
            InitializeComponent();

            Dictionary<int, string> categories = new Dictionary<int, string>();
            try
            {
                foreach (DataRow row in DAO.LoadData("SELECT ID, CatName AS Categoria FROM Category").Rows)
                {
                    int id = Convert.ToInt32(row["ID"]);
                    string categoria = row["Categoria"].ToString();
                    categories.Add(id, categoria);
                }

                cmbCategory.ItemsSource = categories;
                cmbCategory.DisplayMemberPath = "Value";
                cmbCategory.SelectedValuePath = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele nu au putut fi extrase");
            }
        }

        private void btnAddEquipment_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEquipment.Text) && cmbCategory.SelectedItem != null)
            {
                EquipmentName = txtEquipment.Text;
                EquipmentCategory = (int)cmbCategory.SelectedValue;

                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Completați datele echipamentului!");
            }
        }

    }
}
