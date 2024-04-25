using Loguri_Echipamente;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace DatabaseTest
{
    public partial class MainWindow : Window
    {
        private BaseDAO dao = new BaseDAO();
        private string lastOutput = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        //.. Options settings
        private void exitToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void connectionToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            setConnection connect = new setConnection();
            connect.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vor fi adaugate in viitor.");
            MessageBox.Show("Backup-uri vor fi in urmatoarea versiune.");
            //dao.BackupDatabase(AppDomain.CurrentDomain.BaseDirectory + "Backups\\dbbackup");
        }

        //.. Data output
        private void echipamenteToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            btnReturn.Visibility = Visibility.Hidden;
            lastOutput = "SELECT EquipName AS Echipament, CatName AS Categoria FROM Equipment INNER JOIN Category ON Category.ID = Equipment.CategoryID";
            dataOutput.ItemsSource = null;
            try
            {
                dataOutput.ItemsSource = dao.LoadData(lastOutput).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele nu au putut fi extrase");
            }
        }
        
        private void categoriiToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
           btnReturn.Visibility = Visibility.Hidden;
           lastOutput = "SELECT CatName AS Categoria FROM Category";
           dataOutput.ItemsSource = null;
           try
           {
               dataOutput.ItemsSource = dao.LoadData(lastOutput).DefaultView;
           } catch (Exception ex)
           {
               MessageBox.Show("Datele nu au putut fi extrase");
           }
        }

        private void eleviToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
           btnReturn.Visibility = Visibility.Hidden;
           lastOutput = "SELECT Name AS Nume, Surname AS Prenume, Class AS Grupa, Email, PhoneNumber AS NrTelefon FROM Students";
           dataOutput.ItemsSource = null;
            try
            {
                dataOutput.ItemsSource = dao.LoadData(lastOutput).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele nu au putut fi extrase");
            }
        }

        private void loguriToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
           btnReturn.Visibility = Visibility.Visible;
           lastOutput = "SELECT Logs.id, EquipName AS Echipament, Name AS Nume, Surname AS Prenume, Class AS Grupa, DATE(LendDate) AS Data_Imprumutarii, Returned AS Returnat FROM Logs INNER JOIN Equipment ON Logs.Equipment = Equipment.ID INNER JOIN Students ON Logs.Student = Students.ID";
           dataOutput.ItemsSource = null;
            try
            {
                dataOutput.ItemsSource = dao.LoadData(lastOutput).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele nu au putut fi extrase");
            }
        }

        //.. Data insertion
        private void stripAddCategory_Click(object sender, RoutedEventArgs e)
        {
           addCategory addCategory = new addCategory();
           if (addCategory.ShowDialog() == true)
           {
               string categoryName = addCategory.CategoryName;
               dao.InsertData("INSERT INTO Category (catname) VALUES ('" + categoryName + "')");
           }
        }

        private void stripAddEquipment_Click(object sender, RoutedEventArgs e)
        {
           addEquipment addEquipment = new addEquipment();
           if (addEquipment.ShowDialog() == true)
           {
               string equipmentName = addEquipment.EquipmentName;
               int equipmentCategory = addEquipment.EquipmentCategory;
               dao.InsertData("INSERT INTO Equipment (equipname, categoryid) VALUES ('" + equipmentName + "','" + equipmentCategory + "')");
           }
        }

        private void stripAddStudent_Click(object sender, RoutedEventArgs e)
        {
            addStudent addStudent = new addStudent();
            if (addStudent.ShowDialog() == true)
            {
                string studentName = addStudent.StudentName;
                string studentSurname = addStudent.StudentSurname;
                string studentClass = addStudent.StudentClass;
                string studentEmail = addStudent.StudentEmail;
                string studentPhone = addStudent.StudentPhone;

                dao.InsertData("INSERT INTO Students (name, surname, class, email, phonenumber) VALUES ('" + studentName + "','" + studentSurname + "','" + studentClass + "','" + studentEmail + "','" + studentPhone + "')");
            }
        }
        
        private void stripAddLog_Click(object sender, RoutedEventArgs e)
        {
           addLog addLog = new addLog();
           if (addLog.ShowDialog() == true)
           {
               int logEquipment = addLog.LogEquipment;
               int logStudent = addLog.LogStudent;
               DateTime logDate = addLog.LogDate;
               dao.InsertData("INSERT INTO Logs (equipment, student, lenddate, returned) VALUES ('" + logEquipment + "','" + logStudent + "','" + logDate + "', false)");
           }
        }

        //.. Interactive buttons listeners
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            if (!lastOutput.Equals(""))
            {
                dataOutput.ItemsSource = null;
                dataOutput.ItemsSource = dao.LoadData(lastOutput).DefaultView;
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = (DataRowView)dataOutput.SelectedItem;

            if (selectedRow != null)
            {
                dao.UpdateReturned(Convert.ToInt32(selectedRow[0]));
                if (!lastOutput.Equals(""))
                {
                    dataOutput.ItemsSource = null;
                    dataOutput.ItemsSource = dao.LoadData(lastOutput).DefaultView;
                }
            }
            else
            {
                MessageBox.Show("Selectati echipamentul ce a fost returnat.");
            }
        }


        //.. Data grid column generation
        private void dataOutput_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType == typeof(DateTime))
            {
                (e.Column as DataGridTextColumn).Binding.StringFormat = "dd-MM-yyyy";
            }
            if (e.PropertyName.Equals("id", StringComparison.OrdinalIgnoreCase))
            {
                e.Column.Visibility = Visibility.Collapsed;
            }
        }
    }
}
