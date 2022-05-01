namespace AutoServiceManager.master
{
    partial class ClosedOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClosedOrders));
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.orderTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            this.order_workerTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.order_workerTableAdapter();
            this.spares_orderTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.spares_orderTableAdapter();
            this.spareTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.spareTableAdapter();
            this.order_workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spares_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.carTableAdapter();
            this.myOrdersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spares_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myOrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autoserviceDataSet
            // 
            this.autoserviceDataSet.DataSetName = "AutoserviceDataSet";
            this.autoserviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.order_workerTableAdapter = this.order_workerTableAdapter;
            this.tableAdapterManager.orderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.spares_orderTableAdapter = this.spares_orderTableAdapter;
            this.tableAdapterManager.spareTableAdapter = this.spareTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workerTableAdapter = null;
            // 
            // order_workerTableAdapter
            // 
            this.order_workerTableAdapter.ClearBeforeFill = true;
            // 
            // spares_orderTableAdapter
            // 
            this.spares_orderTableAdapter.ClearBeforeFill = true;
            // 
            // spareTableAdapter
            // 
            this.spareTableAdapter.ClearBeforeFill = true;
            // 
            // order_workerBindingSource
            // 
            this.order_workerBindingSource.DataMember = "order_worker";
            this.order_workerBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // spares_orderBindingSource
            // 
            this.spares_orderBindingSource.DataMember = "spares_order";
            this.spares_orderBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // spareBindingSource
            // 
            this.spareBindingSource.DataMember = "spare";
            this.spareBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // myOrdersDataGridView
            // 
            this.myOrdersDataGridView.AllowUserToAddRows = false;
            this.myOrdersDataGridView.AllowUserToDeleteRows = false;
            this.myOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myOrdersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.myOrdersDataGridView.Name = "myOrdersDataGridView";
            this.myOrdersDataGridView.ReadOnly = true;
            this.myOrdersDataGridView.Size = new System.Drawing.Size(534, 270);
            this.myOrdersDataGridView.TabIndex = 0;
            // 
            // ClosedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 290);
            this.Controls.Add(this.myOrdersDataGridView);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClosedOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закрытые заявки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosedOrders_FormClosing);
            this.Load += new System.EventHandler(this.ClosedOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spares_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myOrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private AutoserviceDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutoserviceDataSetTableAdapters.order_workerTableAdapter order_workerTableAdapter;
        private System.Windows.Forms.BindingSource order_workerBindingSource;
        private AutoserviceDataSetTableAdapters.spares_orderTableAdapter spares_orderTableAdapter;
        private System.Windows.Forms.BindingSource spares_orderBindingSource;
        private AutoserviceDataSetTableAdapters.spareTableAdapter spareTableAdapter;
        private System.Windows.Forms.BindingSource spareBindingSource;
        private System.Windows.Forms.BindingSource carBindingSource;
        private AutoserviceDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridView myOrdersDataGridView;
    }
}