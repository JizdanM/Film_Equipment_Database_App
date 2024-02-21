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
        private string lastOutput = "";
        private BaseDAO DAO = new BaseDAO();
        
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
            MessageBox.Show("Vor fi adăugate în viitor");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!lastOutput.Equals(""))
            {
                dataOutput.DataSource = null;
                dataOutput.DataSource = DAO.LoadData(lastOutput);
            }
        }

        private void echipamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastOutput = "SELECT EquipName AS Echipament, CatName AS Categoria FROM Equipment INNER JOIN Category ON Category.ID = Equipment.CategoryID";
            dataOutput.DataSource = null;
            dataOutput.DataSource = DAO.LoadData(lastOutput);
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastOutput = "SELECT CatName AS Categoria FROM Category";
            dataOutput.DataSource = null;
            dataOutput.DataSource = DAO.LoadData(lastOutput);
        }

        private void eleviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastOutput = "SELECT Name AS Nume, Surname AS Prenume, Class AS Grupa, Email, PhoneNumber AS NrTelefon FROM Students";
            dataOutput.DataSource = null;
            dataOutput.DataSource = DAO.LoadData(lastOutput);
        }

        private void loguriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastOutput = "SELECT EquipName AS Echipament, Name AS Nume, Surname AS Prenume, Class AS Grupa, LendDate AS Data_Imprumutarii, Returned AS Returnat FROM Logs INNER JOIN Equipment ON Logs.Equipment = Equipment.ID INNER JOIN Students ON Logs.Student = Students.ID";
            dataOutput.DataSource = null;
            dataOutput.DataSource = DAO.LoadData(lastOutput);
        }

        private void stripAddCategory_Click(object sender, EventArgs e)
        {
            formAddCategory addCategory = new formAddCategory();
            if (addCategory.ShowDialog() == DialogResult.OK)
            {
                string categoryName = addCategory.CategoryName;
                DAO.InsertData("INSERT INTO Category VALUES ('" + categoryName + "')");
            }
        }

        private void stripAddEquipment_Click(object sender, EventArgs e)
        {
            addEquipment addEquipment = new addEquipment();
            if (addEquipment.ShowDialog() == DialogResult.OK)
            {
                string equipmentName = addEquipment.EquipmentName;
                int equipmentCategory = addEquipment.EquipmentCategory;
                DAO.InsertData("INSERT INTO Equipment VALUES ('" + equipmentName + "','" + equipmentCategory + "')");
            }
        }

        private void stripAddStudent_Click(object sender, EventArgs e)
        {
            addStudent addStudent = new addStudent();
            if (addStudent.ShowDialog() == DialogResult.OK)
            {
                string studentName = addStudent.StudentName;
                string studentSurname = addStudent.StudentSurname;
                string studentClass = addStudent.StudentClass;
                string studentEmail = addStudent.StudentEmail;
                string studentPhone = addStudent.StudentPhone;
                DAO.InsertData("INSERT INTO Students VALUES ('" + studentName + "','" + studentSurname + "','" + studentClass + "','" + studentEmail + "','" + studentPhone + "')");
            }
        }

        private void stripAddLog_Click(object sender, EventArgs e)
        {
            addLog addLog = new addLog();
            if (addLog.ShowDialog() == DialogResult.OK)
            {
                int logEquipment = addLog.LogEquipment;
                int logStudent = addLog.LogStudent;
                DateTime logDate = addLog.LogDate;
                DAO.InsertData("INSERT INTO Logs VALUES ('" + logEquipment + "','" + logStudent + "','" + logDate + "', 0)");
            }
        }
    }
}
