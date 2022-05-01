namespace AutoServiceManager.admin
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.carTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.clientTableAdapter();
            this.orderTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.orderTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repairTypeTextBox = new System.Windows.Forms.TextBox();
            this.clientsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoserviceDataSet
            // 
            this.autoserviceDataSet.DataSetName = "AutoserviceDataSet";
            this.autoserviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.workerTableAdapter = null;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // carsComboBox
            // 
            this.carsComboBox.Enabled = false;
            this.carsComboBox.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.carsComboBox.FormattingEnabled = true;
            this.carsComboBox.Location = new System.Drawing.Point(165, 92);
            this.carsComboBox.Name = "carsComboBox";
            this.carsComboBox.Size = new System.Drawing.Size(220, 25);
            this.carsComboBox.TabIndex = 0;
            this.carsComboBox.SelectedIndexChanged += new System.EventHandler(this.carsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label1.Location = new System.Drawing.Point(101, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клиент";
            // 
            // repairTypeTextBox
            // 
            this.repairTypeTextBox.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.repairTypeTextBox.Location = new System.Drawing.Point(165, 148);
            this.repairTypeTextBox.Name = "repairTypeTextBox";
            this.repairTypeTextBox.Size = new System.Drawing.Size(220, 23);
            this.repairTypeTextBox.TabIndex = 2;
            // 
            // clientsComboBox
            // 
            this.clientsComboBox.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.clientsComboBox.FormattingEnabled = true;
            this.clientsComboBox.Location = new System.Drawing.Point(165, 36);
            this.clientsComboBox.Name = "clientsComboBox";
            this.clientsComboBox.Size = new System.Drawing.Size(220, 25);
            this.clientsComboBox.TabIndex = 3;
            this.clientsComboBox.SelectedIndexChanged += new System.EventHandler(this.clientsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Машины клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label3.Location = new System.Drawing.Point(66, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип ремонта";
            // 
            // createOrderButton
            // 
            this.createOrderButton.AutoSize = true;
            this.createOrderButton.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.createOrderButton.Location = new System.Drawing.Point(130, 212);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(181, 27);
            this.createOrderButton.TabIndex = 6;
            this.createOrderButton.Text = "Создать";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 251);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientsComboBox);
            this.Controls.Add(this.repairTypeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carsComboBox);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Orders_FormClosing);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private AutoserviceDataSetTableAdapters.carTableAdapter carTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutoserviceDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.ComboBox carsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repairTypeTextBox;
        private System.Windows.Forms.ComboBox clientsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createOrderButton;
        private AutoserviceDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
    }
}