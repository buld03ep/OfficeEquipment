namespace Beko
{
    partial class FormAddInstallPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddInstallPO));
            this.comboBoxComp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSoft = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerSoft = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.officeEquipmentDBDataSet = new Beko.OfficeEquipmentDBDataSet();
            this.computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computersTableAdapter = new Beko.OfficeEquipmentDBDataSetTableAdapters.ComputersTableAdapter();
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareTableAdapter = new Beko.OfficeEquipmentDBDataSetTableAdapters.SoftwareTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.officeEquipmentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxComp
            // 
            this.comboBoxComp.DataSource = this.computersBindingSource;
            this.comboBoxComp.DisplayMember = "computer_id";
            this.comboBoxComp.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxComp.FormattingEnabled = true;
            this.comboBoxComp.Location = new System.Drawing.Point(370, 124);
            this.comboBoxComp.Name = "comboBoxComp";
            this.comboBoxComp.Size = new System.Drawing.Size(376, 36);
            this.comboBoxComp.TabIndex = 32;
            this.comboBoxComp.ValueMember = "computer_id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Выберите номер компьютера:";
            // 
            // comboBoxSoft
            // 
            this.comboBoxSoft.DataSource = this.softwareBindingSource;
            this.comboBoxSoft.DisplayMember = "software_name";
            this.comboBoxSoft.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSoft.FormattingEnabled = true;
            this.comboBoxSoft.Location = new System.Drawing.Point(301, 178);
            this.comboBoxSoft.Name = "comboBoxSoft";
            this.comboBoxSoft.Size = new System.Drawing.Size(445, 36);
            this.comboBoxSoft.TabIndex = 34;
            this.comboBoxSoft.ValueMember = "software_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Выберите название ПО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Введите дату установки установленного ПО:";
            // 
            // dateTimePickerSoft
            // 
            this.dateTimePickerSoft.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerSoft.Location = new System.Drawing.Point(523, 230);
            this.dateTimePickerSoft.Name = "dateTimePickerSoft";
            this.dateTimePickerSoft.Size = new System.Drawing.Size(223, 37);
            this.dateTimePickerSoft.TabIndex = 36;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Candara Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(38, 341);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(230, 39);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Добавить сотрудника";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // officeEquipmentDBDataSet
            // 
            this.officeEquipmentDBDataSet.DataSetName = "OfficeEquipmentDBDataSet";
            this.officeEquipmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computersBindingSource
            // 
            this.computersBindingSource.DataMember = "Computers";
            this.computersBindingSource.DataSource = this.officeEquipmentDBDataSet;
            // 
            // computersTableAdapter
            // 
            this.computersTableAdapter.ClearBeforeFill = true;
            // 
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataMember = "Software";
            this.softwareBindingSource.DataSource = this.officeEquipmentDBDataSet;
            // 
            // softwareTableAdapter
            // 
            this.softwareTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddInstallPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Beko.Properties.Resources.ad57c0b555aba0663a9c79242996c55171768a4088edce4c9befbf19cfba13ef;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 426);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerSoft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSoft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxComp);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddInstallPO";
            this.Text = "Добавление установленного ПО";
            this.Load += new System.EventHandler(this.FormAddInstallPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeEquipmentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSoft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSoft;
        private System.Windows.Forms.Button buttonAdd;
        private OfficeEquipmentDBDataSet officeEquipmentDBDataSet;
        private System.Windows.Forms.BindingSource computersBindingSource;
        private OfficeEquipmentDBDataSetTableAdapters.ComputersTableAdapter computersTableAdapter;
        private System.Windows.Forms.BindingSource softwareBindingSource;
        private OfficeEquipmentDBDataSetTableAdapters.SoftwareTableAdapter softwareTableAdapter;
    }
}