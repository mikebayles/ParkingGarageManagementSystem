namespace ParkingGarageManagementSystem.Models
{
    partial class VehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleForm));
            this.parkingGarageDataSet = new ParkingGarageManagementSystem.ParkingGarageDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new ParkingGarageManagementSystem.ParkingGarageDataSetTableAdapters.VehicleTableAdapter();
            this.tableAdapterManager = new ParkingGarageManagementSystem.ParkingGarageDataSetTableAdapters.TableAdapterManager();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LICENSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vehicleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vehicleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingNavigator)).BeginInit();
            this.vehicleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkingGarageDataSet
            // 
            this.parkingGarageDataSet.DataSetName = "ParkingGarageDataSet";
            this.parkingGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.parkingGarageDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Parking_SpotTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ParkingGarageManagementSystem.ParkingGarageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_ID,
            this.MAKE,
            this.MODEL,
            this.YEAR,
            this.COLOR,
            this.LICENSE});
            this.vehicleDataGridView.DataSource = this.vehicleBindingSource;
            this.vehicleDataGridView.Location = new System.Drawing.Point(0, 28);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.Size = new System.Drawing.Size(746, 220);
            this.vehicleDataGridView.TabIndex = 1;
            this.vehicleDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.vehicleDataGridView_DefaultValuesNeeded);
            // 
            // USER_ID
            // 
            this.USER_ID.DataPropertyName = "USER_ID";
            this.USER_ID.HeaderText = "USER_ID";
            this.USER_ID.Name = "USER_ID";
            // 
            // MAKE
            // 
            this.MAKE.DataPropertyName = "MAKE";
            this.MAKE.HeaderText = "MAKE";
            this.MAKE.Name = "MAKE";
            // 
            // MODEL
            // 
            this.MODEL.DataPropertyName = "MODEL";
            this.MODEL.HeaderText = "MODEL";
            this.MODEL.Name = "MODEL";
            // 
            // YEAR
            // 
            this.YEAR.DataPropertyName = "YEAR";
            this.YEAR.HeaderText = "YEAR";
            this.YEAR.Name = "YEAR";
            // 
            // COLOR
            // 
            this.COLOR.DataPropertyName = "COLOR";
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.Name = "COLOR";
            // 
            // LICENSE
            // 
            this.LICENSE.DataPropertyName = "LICENSE";
            this.LICENSE.HeaderText = "LICENSE";
            this.LICENSE.Name = "LICENSE";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // vehicleBindingNavigatorSaveItem
            // 
            this.vehicleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vehicleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vehicleBindingNavigatorSaveItem.Image")));
            this.vehicleBindingNavigatorSaveItem.Name = "vehicleBindingNavigatorSaveItem";
            this.vehicleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vehicleBindingNavigatorSaveItem.Text = "Save Data";
            this.vehicleBindingNavigatorSaveItem.Click += new System.EventHandler(this.vehicleBindingNavigatorSaveItem_Click);
            // 
            // vehicleBindingNavigator
            // 
            this.vehicleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vehicleBindingNavigator.BindingSource = this.vehicleBindingSource;
            this.vehicleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vehicleBindingNavigator.DeleteItem = null;
            this.vehicleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.vehicleBindingNavigatorSaveItem});
            this.vehicleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vehicleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vehicleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vehicleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vehicleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vehicleBindingNavigator.Name = "vehicleBindingNavigator";
            this.vehicleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vehicleBindingNavigator.Size = new System.Drawing.Size(774, 25);
            this.vehicleBindingNavigator.TabIndex = 0;
            this.vehicleBindingNavigator.Text = "bindingNavigator1";
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 262);
            this.Controls.Add(this.vehicleDataGridView);
            this.Controls.Add(this.vehicleBindingNavigator);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingNavigator)).EndInit();
            this.vehicleBindingNavigator.ResumeLayout(false);
            this.vehicleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ParkingGarageDataSet parkingGarageDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private ParkingGarageDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private ParkingGarageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn LICENSE;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton vehicleBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator vehicleBindingNavigator;
    }
}