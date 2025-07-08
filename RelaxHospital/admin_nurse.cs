
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
    public partial class admin_nurse : Form
    {
        public admin_nurse()
        {
            InitializeComponent();
        }

        private void admin_nurse_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            {
                var query = "SELECT * FROM LogSign Where UserType = 'Nurse'";
                var data = DataAccess.GetData(query);
                if (data == null)
                    return;


                dgvnurse.AutoGenerateColumns = true;
                dgvnurse.DataSource = data;
                dgvnurse.Refresh();
                dgvnurse.ClearSelection();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)

        {

            if (dgvnurse.SelectedRows.Count > 0)

            {

                var idValue = dgvnurse.SelectedRows[0].Cells["ID"].Value;

                if (idValue == null)

                {

                    MessageBox.Show("Selected row does not have a valid ID.");

                    return;

                }

                int id = Convert.ToInt32(idValue);

                string query = $"DELETE FROM LogSign WHERE ID = {id}";

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


        private void btnback_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
    }
}    