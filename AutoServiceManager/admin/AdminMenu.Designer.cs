namespace AutoServiceManager.admin
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.workerTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            this.adminNameLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // adminNameLabel
            // 
            this.adminNameLabel.AutoSize = true;
            this.adminNameLabel.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.adminNameLabel.Location = new System.Drawing.Point(11, 9);
            this.adminNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(56, 17);
            this.adminNameLabel.TabIndex = 4;
            this.adminNameLabel.Text = "Админ:";
            // 
            // createOrderButton
            // 
            this.createOrderButton.AutoSize = true;
            this.createOrderButton.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.createOrderButton.Location = new System.Drawing.Point(90, 128);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(170, 30);
            this.createOrderButton.TabIndex = 6;
            this.createOrderButton.Text = "Создать заявку";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.AutoSize = true;
            this.clientButton.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.clientButton.Location = new System.Drawing.Point(90, 56);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(170, 30);
            this.clientButton.TabIndex = 5;
            this.clientButton.Text = "Клиенты";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.AutoSize = true;
            this.addCarButton.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.addCarButton.Location = new System.Drawing.Point(90, 92);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(170, 30);
            this.addCarButton.TabIndex = 7;
            this.addCarButton.Text = "Машины";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 188);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.adminNameLabel);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Административное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMenu_FormClosing);
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private AutoserviceDataSetTableAdapters.workerTableAdapter workerTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label adminNameLabel;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button addCarButton;
    }
}