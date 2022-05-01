namespace AutoServiceManager.master
{
    partial class AddSpare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSpare));
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.spareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spareTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.spareTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            this.spares_orderTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.spares_orderTableAdapter();
            this.spareDataGridView = new System.Windows.Forms.DataGridView();
            this.fKsparesorderspareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsparesorderspareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoserviceDataSet
            // 
            this.autoserviceDataSet.DataSetName = "AutoserviceDataSet";
            this.autoserviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spareBindingSource
            // 
            this.spareBindingSource.DataMember = "spare";
            this.spareBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // spareTableAdapter
            // 
            this.spareTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.order_workerTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.spares_orderTableAdapter = this.spares_orderTableAdapter;
            this.tableAdapterManager.spareTableAdapter = this.spareTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workerTableAdapter = null;
            // 
            // spares_orderTableAdapter
            // 
            this.spares_orderTableAdapter.ClearBeforeFill = true;
            // 
            // spareDataGridView
            // 
            this.spareDataGridView.AllowUserToAddRows = false;
            this.spareDataGridView.AllowUserToDeleteRows = false;
            this.spareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spareDataGridView.Location = new System.Drawing.Point(12, 12);
            this.spareDataGridView.Name = "spareDataGridView";
            this.spareDataGridView.ReadOnly = true;
            this.spareDataGridView.Size = new System.Drawing.Size(355, 211);
            this.spareDataGridView.TabIndex = 1;
            this.spareDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spareDataGridView_CellContentClick);
            // 
            // fKsparesorderspareBindingSource
            // 
            this.fKsparesorderspareBindingSource.DataMember = "FK_spares_order_spare";
            this.fKsparesorderspareBindingSource.DataSource = this.spareBindingSource;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSpare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spareDataGridView);
            this.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSpare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление зап частей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSpare_FormClosing);
            this.Load += new System.EventHandler(this.AddSpare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsparesorderspareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource spareBindingSource;
        private AutoserviceDataSetTableAdapters.spareTableAdapter spareTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutoserviceDataSetTableAdapters.spares_orderTableAdapter spares_orderTableAdapter;
        private System.Windows.Forms.DataGridView spareDataGridView;
        private System.Windows.Forms.BindingSource fKsparesorderspareBindingSource;
        private System.Windows.Forms.Button button1;
    }
}