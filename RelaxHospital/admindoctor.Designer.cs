namespace RelaxHospital
{
    partial class admindoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.dgvDoctorInfo = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLoad.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnLoad.Location = new System.Drawing.Point(164, 92);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 47);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.BackColor = System.Drawing.Color.PeachPuff;
            this.bntDelete.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDelete.ForeColor = System.Drawing.Color.DarkOrchid;
            this.bntDelete.Location = new System.Drawing.Point(164, 199);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(119, 47);
            this.bntDelete.TabIndex = 1;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = false;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // dgvDoctorInfo
            // 
            this.dgvDoctorInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctorInfo.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvDoctorInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorInfo.Location = new System.Drawing.Point(326, 54);
            this.dgvDoctorInfo.Name = "dgvDoctorInfo";
            this.dgvDoctorInfo.RowHeadersWidth = 51;
            this.dgvDoctorInfo.RowTemplate.Height = 24;
            this.dgvDoctorInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctorInfo.Size = new System.Drawing.Size(657, 426);
            this.dgvDoctorInfo.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBack.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.Location = new System.Drawing.Point(31, 487);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // admindoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(995, 539);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvDoctorInfo);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.btnLoad);
            this.Name = "admindoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admindoctor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.DataGridView dgvDoctorInfo;
        private System.Windows.Forms.Button btnBack;
    }
}