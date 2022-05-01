namespace AutoServiceManager.admin
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.maleTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.tinTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addClientButton = new System.Windows.Forms.Button();
            this.autoserviceDataSet = new AutoServiceManager.AutoserviceDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new AutoServiceManager.AutoserviceDataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maleTextBox
            // 
            this.maleTextBox.Location = new System.Drawing.Point(138, 191);
            this.maleTextBox.Name = "maleTextBox";
            this.maleTextBox.Size = new System.Drawing.Size(100, 20);
            this.maleTextBox.TabIndex = 14;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(138, 35);
            this.firstnameTextBox.MaxLength = 50;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 12;
            // 
            // passportTextBox
            // 
            this.passportTextBox.Location = new System.Drawing.Point(138, 113);
            this.passportTextBox.MaxLength = 10;
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 61);
            this.nameTextBox.MaxLength = 25;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(138, 87);
            this.lastnameTextBox.MaxLength = 50;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 9;
            // 
            // tinTextBox
            // 
            this.tinTextBox.Location = new System.Drawing.Point(138, 139);
            this.tinTextBox.MaxLength = 12;
            this.tinTextBox.Name = "tinTextBox";
            this.tinTextBox.Size = new System.Drawing.Size(100, 20);
            this.tinTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label2.Location = new System.Drawing.Point(96, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label4.Location = new System.Drawing.Point(91, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "ИНН";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label5.Location = new System.Drawing.Point(67, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Паспорт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label6.Location = new System.Drawing.Point(61, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label7.Location = new System.Drawing.Point(95, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Имя";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(138, 165);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 22;
            // 
            // addClientButton
            // 
            this.addClientButton.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.addClientButton.Location = new System.Drawing.Point(83, 244);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(178, 38);
            this.addClientButton.TabIndex = 23;
            this.addClientButton.Text = "Добавить";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // autoserviceDataSet
            // 
            this.autoserviceDataSet.DataSetName = "AutoserviceDataSet";
            this.autoserviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.autoserviceDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.order_workerTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.spares_orderTableAdapter = null;
            this.tableAdapterManager.spareTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutoServiceManager.AutoserviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workerTableAdapter = null;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 312);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maleTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.tinTextBox);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddClient_FormClosing);
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoserviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maleTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox tinTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.Button addClientButton;
        private AutoserviceDataSet autoserviceDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AutoserviceDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private AutoserviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}