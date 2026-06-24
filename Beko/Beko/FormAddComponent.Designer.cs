namespace Beko
{
    partial class FormAddComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddComponent));
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxManufactor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSpec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxComp = new System.Windows.Forms.ComboBox();
            this.computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officeEquipmentDBDataSet = new Beko.OfficeEquipmentDBDataSet();
            this.computersTableAdapter = new Beko.OfficeEquipmentDBDataSetTableAdapters.ComputersTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeEquipmentDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.DisplayMember = "full_name";
            this.comboBoxType.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Процессор",
            "Видеокарта",
            "Оперативная память",
            "Накопитель",
            "Блок питания"});
            this.comboBoxType.Location = new System.Drawing.Point(337, 125);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(390, 36);
            this.comboBoxType.TabIndex = 20;
            this.comboBoxType.ValueMember = "employee_id";
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Выберите тип компонента:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(369, 172);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(358, 37);
            this.textBoxModel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введите модель компонента:";
            // 
            // textBoxManufactor
            // 
            this.textBoxManufactor.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxManufactor.Location = new System.Drawing.Point(453, 219);
            this.textBoxManufactor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxManufactor.Name = "textBoxManufactor";
            this.textBoxManufactor.Size = new System.Drawing.Size(274, 37);
            this.textBoxManufactor.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Введите производителя компонента:";
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpec.Location = new System.Drawing.Point(460, 265);
            this.textBoxSpec.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.Size = new System.Drawing.Size(267, 37);
            this.textBoxSpec.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Введите характеристику компонента:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(43, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Выберите номер компьютера:";
            // 
            // comboBoxComp
            // 
            this.comboBoxComp.DataSource = this.computersBindingSource;
            this.comboBoxComp.DisplayMember = "computer_id";
            this.comboBoxComp.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxComp.FormattingEnabled = true;
            this.comboBoxComp.Location = new System.Drawing.Point(380, 312);
            this.comboBoxComp.Name = "comboBoxComp";
            this.comboBoxComp.Size = new System.Drawing.Size(347, 36);
            this.comboBoxComp.TabIndex = 30;
            this.comboBoxComp.ValueMember = "computer_id";
            // 
            // computersBindingSource
            // 
            this.computersBindingSource.DataMember = "Computers";
            this.computersBindingSource.DataSource = this.officeEquipmentDBDataSet;
            // 
            // officeEquipmentDBDataSet
            // 
            this.officeEquipmentDBDataSet.DataSetName = "OfficeEquipmentDBDataSet";
            this.officeEquipmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computersTableAdapter
            // 
            this.computersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Candara Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(48, 401);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(230, 39);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "Добавить сотрудника";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Beko.Properties.Resources.ad57c0b555aba0663a9c79242996c55171768a4088edce4c9befbf19cfba13ef;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 453);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxComp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSpec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxManufactor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddComponent";
            this.Text = "Добавление компонента";
            this.Load += new System.EventHandler(this.FormAddComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeEquipmentDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxManufactor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSpec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxComp;
        private OfficeEquipmentDBDataSet officeEquipmentDBDataSet;
        private System.Windows.Forms.BindingSource computersBindingSource;
        private OfficeEquipmentDBDataSetTableAdapters.ComputersTableAdapter computersTableAdapter;
        private System.Windows.Forms.Button buttonAdd;
    }
}