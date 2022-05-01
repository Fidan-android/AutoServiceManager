namespace AutoServiceManager.master
{
    partial class OpenedOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenedOrders));
            this.openedOrdersGridView = new System.Windows.Forms.DataGridView();
            this.setMeButton = new System.Windows.Forms.Button();
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.orderTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            this.carTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.carTableAdapter();
            this.clientTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.clientTableAdapter();
            this.workerTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.workerTableAdapter();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_workerTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.order_workerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.openedOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openedOrdersGridView
            // 
            this.openedOrdersGridView.AllowUserToAddRows = false;
            this.openedOrdersGridView.AllowUserToDeleteRows = false;
            this.openedOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openedOrdersGridView.Location = new System.Drawing.Point(12, 12);
            this.openedOrdersGridView.Name = "openedOrdersGridView";
            this.openedOrdersGridView.ReadOnly = true;
            this.openedOrdersGridView.Size = new System.Drawing.Size(506, 198);
            this.openedOrdersGridView.TabIndex = 0;
            this.openedOrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.openedOrdersGridView_CellContentClick);
            // 
            // setMeButton
            // 
            this.setMeButton.AutoSize = true;
            this.setMeButton.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.setMeButton.Location = new System.Drawing.Point(12, 216);
            this.setMeButton.Name = "setMeButton";
            this.setMeButton.Size = new System.Drawing.Size(135, 30);
            this.setMeButton.TabIndex = 1;
            this.setMeButton.Text = "Взять в работу";
            this.setMeButton.UseVisualStyleBackColor = true;
            this.setMeButton.Click += new System.EventHandler(this.setMeButton_Click);
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
            this.tableAdapterManager.carTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.order_workerTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.spares_orderTableAdapter = null;
            this.tableAdapterManager.spareTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workerTableAdapter = this.workerTableAdapter;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "worker";
            this.workerBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // order_workerBindingSource
            // 
            this.order_workerBindingSource.DataMember = "order_worker";
            this.order_workerBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // order_workerTableAdapter
            // 
            this.order_workerTableAdapter.ClearBeforeFill = true;
            // 
            // OpenedOrders
            // 
            this.ClientSize = new System.Drawing.Size(530, 292);
            this.Controls.Add(this.setMeButton);
            this.Controls.Add(this.openedOrdersGridView);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenedOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Открытые заявки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenedOrders_FormClosing);
            this.Load += new System.EventHandler(this.OpenedOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openedOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_workerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private AutoserviceDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView openedOrdersGridView;
        private AutoserviceDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource;
        private AutoserviceDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AutoserviceDataSetTableAdapters.workerTableAdapter workerTableAdapter;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.Button setMeButton;
        private System.Windows.Forms.BindingSource order_workerBindingSource;
        private AutoserviceDataSetTableAdapters.order_workerTableAdapter order_workerTableAdapter;
    }
}