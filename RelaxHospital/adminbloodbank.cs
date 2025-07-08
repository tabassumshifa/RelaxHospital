using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelaxHospital
{
    public partial class adminbloodbank: Form
    {
        public adminbloodbank()
        {
            InitializeComponent();
        }

        private void paneladminbloodbank_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvadminblood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM  pBlood";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;


            dgvadminblood.AutoGenerateColumns = false;
            dgvadminblood.DataSource = data;
            dgvadminblood.Refresh();
            dgvadminblood.ClearSelection();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvadminblood.SelectedRows.Count > 0)
            {

                var idValue = dgvadminblood.SelectedRows[0].Cells["dgvID"].Value;
                if (idValue == null)
                {
                    MessageBox.Show("Selected row does not have a valid ID.");
                    return;
                }

                int id = Convert.ToInt32(idValue);


                string query = $"DELETE FROM pBlood WHERE UserId = {id}";
                bool success = DataAccess.ExecuteQuery(query);

                if (success)
                {
                    MessageBox.Show("Record deleted successfully!");
                    btnload_Click(null, null); 
                }
                else
                {
                    MessageBox.Show("Failed to delete the record.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
         
            var query = "SELECT * FROM pBlood";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;

            dgvadminblood.AutoGenerateColumns = false;
            dgvadminblood.DataSource = data;
            dgvadminblood.Refresh();
            dgvadminblood.ClearSelection();

            decimal totalPrice = 0;
            foreach (DataRow row in data.Rows)
            {
                if (row["Price"] != DBNull.Value)
                    totalPrice += Convert.ToDecimal(row["Price"]);
            }
            txttotalprice.Text = totalPrice.ToString("0.##");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();

        }

        private void adminbloodbank_Load(object sender, EventArgs e)
        {

        }
    }
}

