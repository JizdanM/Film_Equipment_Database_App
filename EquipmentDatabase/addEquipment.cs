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
    public partial class addEquipment : Form
    {
        private BaseDAO DAO = new BaseDAO();
        public string EquipmentName;
        public int EquipmentCategory;

        public addEquipment()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            Dictionary<int, string> categories = new Dictionary<int, string>();

            foreach (DataRow row in DAO.LoadData("SELECT ID, CatName AS Categoria FROM Category").Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string categoria = row["Categoria"].ToString();
                categories.Add(id, categoria);
            }

            txtCategory.DataSource = new BindingSource(categories, null);
            txtCategory.DisplayMember = "Value";
            txtCategory.ValueMember = "Key";
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            if (!txtEquipName.Text.Equals("") && !txtCategory.Text.Equals(""))
            {
                EquipmentName = txtEquipName.Text;
                EquipmentCategory = (int)txtCategory.SelectedValue;
                DialogResult = DialogResult.OK;
                MessageBox.Show("Datele au fost introduse cu secces.");
                Close();
            }
            else
            {
                MessageBox.Show("Completați datele echipamentului!");
            }
        }
    }
}
