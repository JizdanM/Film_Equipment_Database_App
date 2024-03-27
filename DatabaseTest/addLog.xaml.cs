using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace DatabaseTest
{
    /// <summary>
    /// Interaction logic for addLog.xaml
    /// </summary>
    public partial class addLog : Window
    {
        private BaseDAO DAO = new BaseDAO();
        public int LogEquipment;
        public int LogStudent;
        public DateTime LogDate;


        public addLog()
        {
            InitializeComponent();

            // Display Categories in combobox
            Dictionary<int, string> categories = new Dictionary<int, string>();

            foreach (DataRow row in DAO.LoadData("SELECT ID, CatName AS Categoria FROM Category").Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string categoria = row["Categoria"].ToString();
                categories.Add(id, categoria);
            }

            cmbCategory.ItemsSource = categories;
            cmbCategory.DisplayMemberPath = "Value";
            cmbCategory.SelectedValuePath = "Key";

            // Display students in combobox
            Dictionary<int, string> students = new Dictionary<int, string>();

            foreach (DataRow row in DAO.LoadData("SELECT ID, Name AS Nume, Surname AS Prenume, Class AS Grupa FROM Students").Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string student = row["Nume"].ToString() + " " + row["Prenume"].ToString() + " " + row["Grupa"].ToString();
                students.Add(id, student);
            }

            cmbStudent.ItemsSource = students;
            cmbStudent.DisplayMemberPath = "Value";
            cmbStudent.SelectedValuePath = "Key";
        }

        private void txtLogCategory_DropDownClosed(object sender, EventArgs e)
        {
            // Display equipments depending on category selected
            Dictionary<int, string> equipments = new Dictionary<int, string>();

            foreach (DataRow row in DAO.LoadData("SELECT ID, EquipName AS Echipament FROM Equipment WHERE CategoryID=(SELECT ID FROM Category WHERE Category.CatName='" + cmbCategory.Text + "')").Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string equipment = row["Echipament"].ToString();
                equipments.Add(id, equipment);
            }

            cmbEquipment.ItemsSource = equipments;
            cmbEquipment.DisplayMemberPath = "Value";
            cmbEquipment.SelectedValuePath = "Key";
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            if (cmbEquipment.SelectedIndex != -1 && cmbEquipment.SelectedIndex != -1 && cmbStudent.SelectedIndex != -1 && selectDate.SelectedDate != null)
            {
                LogEquipment = (int)cmbEquipment.SelectedValue;
                LogStudent = (int)cmbStudent.SelectedValue;
                LogDate = selectDate.SelectedDate.Value.Date;
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Completați datele logului!");
            }
        }
    }
}
