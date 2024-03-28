using System;
using System.Collections.Generic;
using System.Formats.Asn1;
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
using System.Xml.Linq;

namespace DatabaseTest
{
    /// <summary>
    /// Interaction logic for addStudent.xaml
    /// </summary>
    public partial class addStudent : Window
    {
        public string StudentName;
        public string StudentSurname;
        public string StudentClass;
        public string StudentEmail;
        public string StudentPhone;
        public addStudent()
        {
            InitializeComponent();
        }
        private void btnAddElev_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) &&
                !string.IsNullOrEmpty(txtClass.Text) && !string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtPhone.Text))
            {
                StudentName = txtName.Text;
                StudentSurname = txtSurname.Text;
                StudentClass = txtClass.Text;
                StudentEmail = txtEmail.Text;
                StudentPhone = txtPhone.Text;

                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Completați datele elevului!");
            }
        }

    }
}
