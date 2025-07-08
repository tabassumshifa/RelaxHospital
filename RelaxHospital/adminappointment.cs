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
    public partial class adminappointment: Form
    {
        public adminappointment()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM  Appointmentpatient  ";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;


            dgvadminappointment.AutoGenerateColumns = true;
            dgvadminappointment.DataSource = data;
            dgvadminappointment.Refresh();
            dgvadminappointment.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            if (dgvadminappointment.SelectedRows.Count > 0)
            {
            
                var idValue = dgvadminappointment.SelectedRows[0].Cells["ApID"].Value;
                if (idValue == null)
                {
                    MessageBox.Show("Selected row does not have a valid ID.");
                    return;
                }

                int id = Convert.ToInt32(idValue);

                string query = $"DELETE FROM Appointmentpatient WHERE ApID = {id}";
                bool success = DataAccess.ExecuteQuery(query);

                if (success)
                {
                    MessageBox.Show("Record deleted successfully!");
                    button1_Click(null, null); 
                }
                else
                {
                    MessageBox.Show("Failed to delete the record.");
                }
            }
            
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void dgvadminappointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminappointment_Load(object sender, EventArgs e)
        {

        }
    }
}
