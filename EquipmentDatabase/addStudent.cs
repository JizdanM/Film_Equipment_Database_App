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
    public partial class addStudent : Form
    {
        public string StudentName;
        public string StudentSurname;
        public string StudentClass;
        public string StudentEmail;
        public string StudentPhone;

        public addStudent()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btnAddElev_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals("") && !txtSurname.Text.Equals("") && !txtClass.Text.Equals("") && !txtEmail.Text.Equals("") && !txtPhone.Text.Equals(""))
            {
                StudentName = txtName.Text;
                StudentSurname = txtSurname.Text;
                StudentClass = txtClass.Text;
                StudentEmail = txtEmail.Text;
                StudentPhone = txtPhone.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Completați datele elevului!");
            }
        }
    }
}
