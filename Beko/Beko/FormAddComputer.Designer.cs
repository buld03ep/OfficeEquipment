namespace Beko
{
    partial class FormAddComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddComputer));
            this.textBoxOS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officeEquipmentDBDataSet = new Beko.OfficeEquipmentDBDataSet();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new Beko.OfficeEquipmentDBDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeEquipmentDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOS
            // 
            this.textBoxOS.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOS.Location = new System.Drawing.Point(504, 176);
            this.textBoxOS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOS.Name = "textBoxOS";
            this.textBoxOS.Size = new System.Drawing.Size(293, 36);
            this.textBoxOS.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите ОС установленной на компьютере:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(42, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Выберите владельца компьютера:";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DataSource = this.employeesBindingSource;
            this.comboBoxEmployee.DisplayMember = "full_name";
            this.comboBoxEmployee.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(413, 225);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(384, 36);
            this.comboBoxEmployee.TabIndex = 18;
            this.comboBoxEmployee.ValueMember = "employee_id";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.officeEquipmentDBDataSet;
            // 
            // officeEquipmentDBDataSet
            // 
            this.officeEquipmentDBDataSet.DataSetName = "OfficeEquipmentDBDataSet";
            this.officeEquipmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Candara Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(46, 411);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(230, 39);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавить сотрудника";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Beko.Properties.Resources.ad57c0b555aba0663a9c79242996c55171768a4088edce4c9befbf19cfba13ef;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 469);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOS);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddComputer";
            this.Text = "Добавление компьютера";
            this.Load += new System.EventHandler(this.FormAddComputer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeEquipmentDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button buttonAdd;
        private OfficeEquipmentDBDataSet officeEquipmentDBDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private OfficeEquipmentDBDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}