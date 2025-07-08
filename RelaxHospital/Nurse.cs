using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace RelaxHospital
{
    public partial class Nurse: Form
    {
        private string Email;
        public Nurse()
        {
            InitializeComponent();
           // string sql = "select * from PatientInfo;";
           //this.PopulateGridView(sql);
        }
        private void PopulateGridView(string sql = "select * from PatientInfo;")
        {
            try
            {
                var dt = DataAccess.GetData(sql);
               this.dgvLogInfo.AutoGenerateColumns = false;
                this.dgvLogInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void bntPatient_Click(object sender, EventArgs e)
        {
            string id = this.txtp_id.Text.Trim(); 

            if (id == "") 
            {
                MessageBox.Show("Please enter a Patient ID.");
                txtp_id.Focus();
                return;
            }

            string sql = $"SELECT * FROM Admit WHERE ID = '{id}'";

            DataTable dt = DataAccess.GetData(sql);

            dgvLogInfo.AutoGenerateColumns = false;
            dgvLogInfo.DataSource = dt;
            dgvLogInfo.Refresh();
            dgvLogInfo.ClearSelection();

        }
               
      
private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nurse_Load(object sender, EventArgs e)
        {

        }

        private void dgvLogInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLogInfo.SelectedRows.Count > 0)
            {
                if (dgvLogInfo.SelectedRows.Count > 0)
                {
                    var row = dgvLogInfo.SelectedRows[0];
                    var Id = row.Cells["AdminID"].Value?.ToString();
                    
                    rtxtDescription.Text = row.Cells["Description"].Value?.ToString();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var query =" Select * from Admit";

            var data = DataAccess.GetData(query);
            if (data == null)
                return;


            dgvLogInfo.AutoGenerateColumns = true;
            dgvLogInfo.DataSource = data;
            dgvLogInfo.Refresh();
            dgvLogInfo.ClearSelection();

        }
        private void LoadData()
        {
            
            
        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nurse_Load_1(object sender, EventArgs e)
        {

        }
    }
}
