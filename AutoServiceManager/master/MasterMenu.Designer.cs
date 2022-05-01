namespace AutoServiceManager.master
{
    partial class MasterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterMenu));
            this.openedOrdersButton = new System.Windows.Forms.Button();
            this.masterNameLabel = new System.Windows.Forms.Label();
            this.currentOrderButton = new System.Windows.Forms.Button();
            this.closedOrdersButton = new System.Windows.Forms.Button();
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.workerTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.orderTableAdapter();
            this.order_workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_workerTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.order_workerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openedOrdersButton
            // 
            this.openedOrdersButton.AutoSize = true;
            this.openedOrdersButton.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.openedOrdersButton.Location = new System.Drawing.Point(71, 46);
            this.openedOrdersButton.Name = "openedOrdersButton";
            this.openedOrdersButton.Size = new System.Drawing.Size(170, 30);
            this.openedOrdersButton.TabIndex = 0;
            this.openedOrdersButton.Text = "Открытые заявки";
            this.openedOrdersButton.UseVisualStyleBackColor = true;
            this.openedOrdersButton.Click += new System.EventHandler(this.openedOrdersButton_Click);
            // 
            // masterNameLabel
            // 
            this.masterNameLabel.AutoSize = true;
            this.masterNameLabel.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.masterNameLabel.Location = new System.Drawing.Point(12, 9);
            this.masterNameLabel.Name = "masterNameLabel";
            this.masterNameLabel.Size = new System.Drawing.Size(62, 17);
            this.masterNameLabel.TabIndex = 2;
            this.masterNameLabel.Text = "Мастер:";
            // 
            // currentOrderButton
            // 
            this.currentOrderButton.AutoSize = true;
            this.currentOrderButton.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.currentOrderButton.Location = new System.Drawing.Point(56, 82);
            this.currentOrderButton.Name = "currentOrderButton";
            this.currentOrderButton.Size = new System.Drawing.Size(200, 30);
            this.currentOrderButton.TabIndex = 3;
            this.currentOrderButton.Text = "Моя текущая заявка";
            this.currentOrderButton.UseVisualStyleBackColor = true;
            this.currentOrderButton.Click += new System.EventHandler(this.currentOrderButton_Click);
            // 
            // closedOrdersButton
            // 
            this.closedOrdersButton.AutoSize = true;
            this.closedOrdersButton.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.closedOrdersButton.Location = new System.Drawing.Point(41, 118);
            this.closedOrdersButton.Name = "closedOrdersButton";
            this.closedOrdersButton.Size = new System.Drawing.Size(230, 30);
            this.closedOrdersButton.TabIndex = 4;
            this.closedOrdersButton.Text = "Мои выполненные заявки";
            this.closedOrdersButton.UseVisualStyleBackColor = true;
            this.closedOrdersButton.Click += new System.EventHandler(this.closedOrdersButton_Click);
            // 
            // autoserviceDataSet
            // 
            this.autoserviceDataSet.DataSetName = "AutoserviceDataSet";
            this.autoserviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "worker";
            this.workerBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.order_workerTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.spares_orderTableAdapter = null;
            this.tableAdapterManager.spareTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workerTableAdapter = this.workerTableAdapter;
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
            // order_workerBindingSource
            // 
            this.order_workerBindingSource.DataMember = "order_worker";
            this.order_workerBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // order_workerTableAdapter
            // 
            this.order_workerTableAdapter.ClearBeforeFill = true;
            // 
            // MasterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 177);
            this.Controls.Add(this.closedOrdersButton);
            this.Controls.Add(this.currentOrderButton);
            this.Controls.Add(this.masterNameLabel);
            this.Controls.Add(this.openedOrdersButton);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню мастера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterMenu_FormClosing);
            this.Load += new System.EventHandler(this.MasterMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_workerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openedOrdersButton;
        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private AutoserviceDataSetTableAdapters.workerTableAdapter workerTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label masterNameLabel;
        private System.Windows.Forms.Button currentOrderButton;
        private System.Windows.Forms.Button closedOrdersButton;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private AutoserviceDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource order_workerBindingSource;
        private AutoserviceDataSetTableAdapters.order_workerTableAdapter order_workerTableAdapter;
    }
}