namespace AutoServiceManager.master
{
    partial class CurrentOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentOrder));
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.order_workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_workerTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.order_workerTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            this.carTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.carTableAdapter();
            this.orderTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.orderTableAdapter();
            this.spares_orderTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.spares_orderTableAdapter();
            this.spareTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.spareTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spares_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carLabel = new System.Windows.Forms.Label();
            this.repairTypeLabel = new System.Windows.Forms.Label();
            this.dateStartLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.addDetailButton = new System.Windows.Forms.Button();
            this.removeDetailButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.finishOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spares_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autoserviceDataSet
            // 
            this.autoserviceDataSet.DataSetName = "AutoserviceDataSet";
            this.autoserviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.order_workerTableAdapter = this.order_workerTableAdapter;
            this.tableAdapterManager.orderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.spares_orderTableAdapter = this.spares_orderTableAdapter;
            this.tableAdapterManager.spareTableAdapter = this.spareTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workerTableAdapter = null;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // spares_orderTableAdapter
            // 
            this.spares_orderTableAdapter.ClearBeforeFill = true;
            // 
            // spareTableAdapter
            // 
            this.spareTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // spareBindingSource
            // 
            this.spareBindingSource.DataMember = "spare";
            this.spareBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // spares_orderBindingSource
            // 
            this.spares_orderBindingSource.DataMember = "spares_order";
            this.spares_orderBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(12, 9);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(83, 20);
            this.carLabel.TabIndex = 0;
            this.carLabel.Text = "Машина:";
            // 
            // repairTypeLabel
            // 
            this.repairTypeLabel.AutoSize = true;
            this.repairTypeLabel.Location = new System.Drawing.Point(12, 40);
            this.repairTypeLabel.Name = "repairTypeLabel";
            this.repairTypeLabel.Size = new System.Drawing.Size(116, 20);
            this.repairTypeLabel.TabIndex = 1;
            this.repairTypeLabel.Text = "Тип ремонта:";
            // 
            // dateStartLabel
            // 
            this.dateStartLabel.AutoSize = true;
            this.dateStartLabel.Location = new System.Drawing.Point(12, 74);
            this.dateStartLabel.Name = "dateStartLabel";
            this.dateStartLabel.Size = new System.Drawing.Size(114, 20);
            this.dateStartLabel.TabIndex = 2;
            this.dateStartLabel.Text = "Дата начала:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 107);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 20);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Статус:";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(12, 140);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(72, 20);
            this.detailsLabel.TabIndex = 4;
            this.detailsLabel.Text = "Детали:";
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Location = new System.Drawing.Point(12, 172);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.Size = new System.Drawing.Size(338, 177);
            this.detailsDataGridView.TabIndex = 5;
            this.detailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailsDataGridView_CellContentClick);
            // 
            // addDetailButton
            // 
            this.addDetailButton.AutoSize = true;
            this.addDetailButton.BackColor = System.Drawing.Color.Lime;
            this.addDetailButton.ForeColor = System.Drawing.Color.Black;
            this.addDetailButton.Location = new System.Drawing.Point(12, 355);
            this.addDetailButton.Name = "addDetailButton";
            this.addDetailButton.Size = new System.Drawing.Size(161, 30);
            this.addDetailButton.TabIndex = 6;
            this.addDetailButton.Text = "Добавить деталь";
            this.addDetailButton.UseVisualStyleBackColor = false;
            this.addDetailButton.Click += new System.EventHandler(this.addDetailButton_Click);
            // 
            // removeDetailButton
            // 
            this.removeDetailButton.AutoSize = true;
            this.removeDetailButton.BackColor = System.Drawing.Color.Red;
            this.removeDetailButton.ForeColor = System.Drawing.Color.Black;
            this.removeDetailButton.Location = new System.Drawing.Point(189, 355);
            this.removeDetailButton.Name = "removeDetailButton";
            this.removeDetailButton.Size = new System.Drawing.Size(161, 30);
            this.removeDetailButton.TabIndex = 7;
            this.removeDetailButton.Text = "Удалить деталь";
            this.removeDetailButton.UseVisualStyleBackColor = false;
            this.removeDetailButton.Click += new System.EventHandler(this.removeDetailButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.AutoSize = true;
            this.cancelOrderButton.BackColor = System.Drawing.Color.Red;
            this.cancelOrderButton.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.cancelOrderButton.ForeColor = System.Drawing.Color.Black;
            this.cancelOrderButton.Location = new System.Drawing.Point(270, 12);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(80, 25);
            this.cancelOrderButton.TabIndex = 8;
            this.cancelOrderButton.Text = "Отменить";
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.AutoSize = true;
            this.finishOrderButton.BackColor = System.Drawing.Color.Lime;
            this.finishOrderButton.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.finishOrderButton.ForeColor = System.Drawing.Color.Black;
            this.finishOrderButton.Location = new System.Drawing.Point(270, 43);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(81, 25);
            this.finishOrderButton.TabIndex = 9;
            this.finishOrderButton.Text = "Завершить";
            this.finishOrderButton.UseVisualStyleBackColor = false;
            this.finishOrderButton.Click += new System.EventHandler(this.finishOrderButton_Click);
            // 
            // CurrentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 391);
            this.Controls.Add(this.finishOrderButton);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.removeDetailButton);
            this.Controls.Add(this.addDetailButton);
            this.Controls.Add(this.detailsDataGridView);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dateStartLabel);
            this.Controls.Add(this.repairTypeLabel);
            this.Controls.Add(this.carLabel);
            this.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текущая заявка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrentOrder_FormClosing);
            this.Load += new System.EventHandler(this.CurrentOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spares_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource order_workerBindingSource;
        private AutoserviceDataSetTableAdapters.order_workerTableAdapter order_workerTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutoserviceDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private AutoserviceDataSetTableAdapters.spareTableAdapter spareTableAdapter;
        private System.Windows.Forms.BindingSource spareBindingSource;
        private AutoserviceDataSetTableAdapters.spares_orderTableAdapter spares_orderTableAdapter;
        private System.Windows.Forms.BindingSource spares_orderBindingSource;
        private AutoserviceDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label repairTypeLabel;
        private System.Windows.Forms.Label dateStartLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.DataGridView detailsDataGridView;
        private System.Windows.Forms.Button addDetailButton;
        private System.Windows.Forms.Button removeDetailButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button finishOrderButton;
    }
}