namespace ParkingGarageManagementSystem.Main
{
    partial class NewReservationForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingGarageDataSet = new ParkingGarageManagementSystem.ParkingGarageDataSet();
            this.vehicleTableAdapter = new ParkingGarageManagementSystem.ParkingGarageDataSetTableAdapters.VehicleTableAdapter();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSpots = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpots)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrival Date/Time:";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(164, 17);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(253, 23);
            this.dtpStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departure Date/Time:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(164, 57);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(253, 23);
            this.dtpEnd.TabIndex = 3;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(12, 333);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(51, 16);
            this.lblVehicle.TabIndex = 4;
            this.lblVehicle.Text = "Vehicle: ";
            this.lblVehicle.Visible = false;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.parkingGarageDataSet;
            // 
            // parkingGarageDataSet
            // 
            this.parkingGarageDataSet.DataSetName = "ParkingGarageDataSet";
            this.parkingGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // cboVehicle
            // 
            this.cboVehicle.DisplayMember = "VEHICLE_ID";
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(164, 330);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(253, 24);
            this.cboVehicle.TabIndex = 5;
            this.cboVehicle.ValueMember = "VEHICLE_ID";
            this.cboVehicle.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSpots
            // 
            this.dgvSpots.AllowUserToAddRows = false;
            this.dgvSpots.AllowUserToDeleteRows = false;
            this.dgvSpots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpots.Location = new System.Drawing.Point(15, 121);
            this.dgvSpots.Name = "dgvSpots";
            this.dgvSpots.Size = new System.Drawing.Size(402, 193);
            this.dgvSpots.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 367);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(402, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Create Reservation For Selected Spot and Vehicle";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblStatus.Location = new System.Drawing.Point(107, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 9;
            // 
            // NewReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 407);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvSpots);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboVehicle);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewReservationForm";
            this.Text = "Create New Reservation";
            this.Load += new System.EventHandler(this.NewReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblVehicle;
        private ParkingGarageDataSet parkingGarageDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private ParkingGarageDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSpots;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStatus;

    }
}