namespace ParkingGarageManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMyReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateBillsForMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingGarageDataSet = new ParkingGarageManagementSystem.ParkingGarageDataSet();
            this.garageGrid1 = new ParkingGarageManagementSystem.Main.GarageGrid();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Close";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehiclesToolStripMenuItem});
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            this.manageVehiclesToolStripMenuItem.Click += new System.EventHandler(this.manageVehiclesToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReservationsToolStripMenuItem,
            this.manageMyReservationsToolStripMenuItem});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // createReservationsToolStripMenuItem
            // 
            this.createReservationsToolStripMenuItem.Name = "createReservationsToolStripMenuItem";
            this.createReservationsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.createReservationsToolStripMenuItem.Text = "Create Reservations";
            this.createReservationsToolStripMenuItem.Click += new System.EventHandler(this.manageReservationsToolStripMenuItem_Click);
            // 
            // manageMyReservationsToolStripMenuItem
            // 
            this.manageMyReservationsToolStripMenuItem.Name = "manageMyReservationsToolStripMenuItem";
            this.manageMyReservationsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.manageMyReservationsToolStripMenuItem.Text = "Manage My Reservations";
            this.manageMyReservationsToolStripMenuItem.Click += new System.EventHandler(this.manageMyReservationsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStatisticsToolStripMenuItem,
            this.generateBillsForMonthToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // viewStatisticsToolStripMenuItem
            // 
            this.viewStatisticsToolStripMenuItem.Name = "viewStatisticsToolStripMenuItem";
            this.viewStatisticsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.viewStatisticsToolStripMenuItem.Text = "View Statistics";
            this.viewStatisticsToolStripMenuItem.Click += new System.EventHandler(this.viewStatisticsToolStripMenuItem_Click);
            // 
            // generateBillsForMonthToolStripMenuItem
            // 
            this.generateBillsForMonthToolStripMenuItem.Name = "generateBillsForMonthToolStripMenuItem";
            this.generateBillsForMonthToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.generateBillsForMonthToolStripMenuItem.Text = "Generate Bills For Month";
            this.generateBillsForMonthToolStripMenuItem.Click += new System.EventHandler(this.generateBillsForMonthToolStripMenuItem_Click);
            // 
            // parkingGarageDataSet
            // 
            this.parkingGarageDataSet.DataSetName = "ParkingGarageDataSet";
            this.parkingGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // garageGrid1
            // 
            this.garageGrid1.Floor = 1;
            this.garageGrid1.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garageGrid1.Location = new System.Drawing.Point(8, 28);
            this.garageGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.garageGrid1.Name = "garageGrid1";
            this.garageGrid1.Size = new System.Drawing.Size(800, 450);
            this.garageGrid1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 477);
            this.Controls.Add(this.garageGrid1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private ParkingGarageDataSet parkingGarageDataSet;
        private Main.GarageGrid garageGrid1;
        private System.Windows.Forms.ToolStripMenuItem createReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMyReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateBillsForMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}