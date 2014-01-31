namespace ParkingGarageManagementSystem.Main
{
    partial class ManageReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReservation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.parkingGarageDataSet = new ParkingGarageManagementSystem.ParkingGarageDataSet();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new ParkingGarageManagementSystem.ParkingGarageDataSetTableAdapters.ReservationTableAdapter();
            this.tableAdapterManager = new ParkingGarageManagementSystem.ParkingGarageDataSetTableAdapters.TableAdapterManager();
            this.reservationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reservationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.RESERVATION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTURE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPOT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnArrive = new System.Windows.Forms.Button();
            this.btnDepart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingNavigator)).BeginInit();
            this.reservationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkingGarageDataSet
            // 
            this.parkingGarageDataSet.DataSetName = "ParkingGarageDataSet";
            this.parkingGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.parkingGarageDataSet;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Parking_SpotTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = this.reservationTableAdapter;
            this.tableAdapterManager.UpdateOrder = ParkingGarageManagementSystem.ParkingGarageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // reservationBindingNavigator
            // 
            this.reservationBindingNavigator.AddNewItem = null;
            this.reservationBindingNavigator.BindingSource = this.reservationBindingSource;
            this.reservationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservationBindingNavigator.DeleteItem = null;
            this.reservationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.reservationBindingNavigatorSaveItem});
            this.reservationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reservationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reservationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reservationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reservationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reservationBindingNavigator.Name = "reservationBindingNavigator";
            this.reservationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservationBindingNavigator.Size = new System.Drawing.Size(692, 25);
            this.reservationBindingNavigator.TabIndex = 0;
            this.reservationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // reservationBindingNavigatorSaveItem
            // 
            this.reservationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reservationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reservationBindingNavigatorSaveItem.Image")));
            this.reservationBindingNavigatorSaveItem.Name = "reservationBindingNavigatorSaveItem";
            this.reservationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reservationBindingNavigatorSaveItem.Text = "Save Data";
            this.reservationBindingNavigatorSaveItem.Click += new System.EventHandler(this.reservationBindingNavigatorSaveItem_Click_1);
            // 
            // dgvReservation
            // 
            this.dgvReservation.AutoGenerateColumns = false;
            this.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RESERVATION_ID,
            this.ARRIVAL,
            this.DEPARTURE,
            this.STATUS,
            this.START_TIME,
            this.END_TIME,
            this.SPOT_ID});
            this.dgvReservation.DataSource = this.reservationBindingSource;
            this.dgvReservation.Location = new System.Drawing.Point(0, 28);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.Size = new System.Drawing.Size(523, 283);
            this.dgvReservation.TabIndex = 1;
            this.dgvReservation.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.reservationDataGridView_CellValidating);
            this.dgvReservation.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvReservation_RowPrePaint);
            // 
            // RESERVATION_ID
            // 
            this.RESERVATION_ID.DataPropertyName = "RESERVATION_ID";
            this.RESERVATION_ID.HeaderText = "RESERVATION_ID";
            this.RESERVATION_ID.Name = "RESERVATION_ID";
            this.RESERVATION_ID.ReadOnly = true;
            // 
            // ARRIVAL
            // 
            this.ARRIVAL.DataPropertyName = "ARRIVAL";
            this.ARRIVAL.HeaderText = "ARRIVAL";
            this.ARRIVAL.Name = "ARRIVAL";
            this.ARRIVAL.Visible = false;
            // 
            // DEPARTURE
            // 
            this.DEPARTURE.DataPropertyName = "DEPARTURE";
            this.DEPARTURE.HeaderText = "DEPARTURE";
            this.DEPARTURE.Name = "DEPARTURE";
            this.DEPARTURE.Visible = false;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.Visible = false;
            // 
            // START_TIME
            // 
            this.START_TIME.DataPropertyName = "START_TIME";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.START_TIME.DefaultCellStyle = dataGridViewCellStyle3;
            this.START_TIME.HeaderText = "START_TIME";
            this.START_TIME.Name = "START_TIME";
            // 
            // END_TIME
            // 
            this.END_TIME.DataPropertyName = "END_TIME";
            dataGridViewCellStyle4.Format = "g";
            this.END_TIME.DefaultCellStyle = dataGridViewCellStyle4;
            this.END_TIME.HeaderText = "END_TIME";
            this.END_TIME.Name = "END_TIME";
            // 
            // SPOT_ID
            // 
            this.SPOT_ID.DataPropertyName = "SPOT_ID";
            this.SPOT_ID.HeaderText = "SPOT_ID";
            this.SPOT_ID.Name = "SPOT_ID";
            this.SPOT_ID.ReadOnly = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 314);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 23);
            this.lblStatus.TabIndex = 2;
            // 
            // btnArrive
            // 
            this.btnArrive.AutoSize = true;
            this.btnArrive.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrive.Location = new System.Drawing.Point(63, 346);
            this.btnArrive.Name = "btnArrive";
            this.btnArrive.Size = new System.Drawing.Size(135, 43);
            this.btnArrive.TabIndex = 3;
            this.btnArrive.Text = "Check In For Selected";
            this.btnArrive.UseVisualStyleBackColor = true;
            this.btnArrive.Click += new System.EventHandler(this.btnArrive_Click);
            // 
            // btnDepart
            // 
            this.btnDepart.AutoSize = true;
            this.btnDepart.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepart.Location = new System.Drawing.Point(204, 346);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(140, 43);
            this.btnDepart.TabIndex = 4;
            this.btnDepart.Text = "Check Out For Selected";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(345, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel For Selected";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(529, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 220);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Future";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Complete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cancel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Active";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(486, 346);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 43);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 401);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDepart);
            this.Controls.Add(this.btnArrive);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.reservationBindingNavigator);
            this.Font = new System.Drawing.Font("Goudy Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageReservation";
            this.Text = "ManageReservation";
            this.Load += new System.EventHandler(this.ManageReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingNavigator)).EndInit();
            this.reservationBindingNavigator.ResumeLayout(false);
            this.reservationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ParkingGarageDataSet parkingGarageDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private ParkingGarageDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private ParkingGarageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reservationBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton reservationBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnArrive;
        private System.Windows.Forms.Button btnDepart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVATION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTURE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPOT_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;

    }
}