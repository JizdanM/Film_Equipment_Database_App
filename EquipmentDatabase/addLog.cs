using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentDatabase
{
    public partial class addLog : Form
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

            categories.Add(-1, "");
            txtLogCategory.DataSource = new BindingSource(categories, null);
            txtLogCategory.DisplayMember = "Value";
            txtLogCategory.ValueMember = "Key";
            txtLogCategory.SelectedIndex = -1;

            // Display students in combobox
            Dictionary<int, string> students = new Dictionary<int, string>();

            foreach (DataRow row in DAO.LoadData("SELECT ID, Name AS Nume, Surname AS Prenume, Class AS Grupa FROM Students").Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string student = row["Nume"].ToString() + " " + row["Prenume"].ToString() + " " + row["Grupa"].ToString();
                students.Add(id, student);
            }

            students.Add(-1, "");
            txtLogStudent.DataSource = new BindingSource(students, null);
            txtLogStudent.DisplayMember = "Value";
            txtLogStudent.ValueMember = "Key";
            txtLogStudent.SelectedIndex = -1;
        }

        private void txtLogCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display equipments depending on category selected
            Dictionary<int, string> equipments = new Dictionary<int, string>();

            foreach (DataRow row in DAO.LoadData("SELECT ID, EquipName AS Echipament FROM Equipment WHERE CategoryID=(SELECT ID FROM Category WHERE Category.CatName='" + txtLogCategory.Text + "')").Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string equipment = row["Echipament"].ToString();
                equipments.Add(id, equipment);
            }

            equipments.Add(-1, "");
            txtLogEquipment.DataSource = new BindingSource(equipments, null);
            txtLogEquipment.DisplayMember = "Value";
            txtLogEquipment.ValueMember = "Key";
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            if (txtLogEquipment.SelectedIndex != -1 && txtLogStudent.SelectedIndex != -1)
            {
                LogEquipment = (int) txtLogEquipment.SelectedValue;
                LogStudent = (int) txtLogStudent.SelectedValue;
                LogDate = txtLogDate.Value;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Completați datele logului!");
            }
        }
    }
}
