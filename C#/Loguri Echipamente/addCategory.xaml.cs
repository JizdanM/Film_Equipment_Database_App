using System;
using System.Collections.Generic;
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
    /// Interaction logic for addCategory.xaml
    /// </summary>
    public partial class addCategory : Window
    {
        public string CategoryName;

        public addCategory()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, RoutedEventArgs e)
        {
            if (!txtCategory.Text.Equals(""))
            {
                CategoryName = txtCategory.Text;
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Introduceti denumirea categoriei!");
            }
        }
    }
}
