namespace AutoServiceManager.admin
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.carTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.clientTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.addCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
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
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.spares_orderTableAdapter = null;
            this.tableAdapterManager.spareTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workerTableAdapter = null;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.Size = new System.Drawing.Size(394, 155);
            this.carsDataGridView.TabIndex = 0;
            // 
            // addCarButton
            // 
            this.addCarButton.AutoSize = true;
            this.addCarButton.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.addCarButton.Location = new System.Drawing.Point(134, 173);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(137, 27);
            this.addCarButton.TabIndex = 1;
            this.addCarButton.Text = "Добавить машину";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 224);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.carsDataGridView);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Машины";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cars_FormClosing);
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private AutoserviceDataSetTableAdapters.carTableAdapter carTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutoserviceDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.Button addCarButton;
    }
}