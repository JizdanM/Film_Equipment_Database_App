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
    public partial class formAddCategory : Form
    {
        public string CategoryName;

        public formAddCategory()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!txtCategory.Text.Equals(""))
            {
                CategoryName = txtCategory.Text;
                DialogResult = DialogResult.OK;
                MessageBox.Show("Datele au fost introduse cu secces.");
                Close();
            } else
            {
                MessageBox.Show("Introduceti denumirea categoriei!");
            }
        }
    }
}
