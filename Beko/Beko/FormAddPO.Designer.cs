namespace Beko
{
    partial class FormAddPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPO));
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNamePO = new System.Windows.Forms.TextBox();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxLicen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(50, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Введите название ПО:";
            // 
            // textBoxNamePO
            // 
            this.textBoxNamePO.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNamePO.Location = new System.Drawing.Point(300, 127);
            this.textBoxNamePO.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamePO.Name = "textBoxNamePO";
            this.textBoxNamePO.Size = new System.Drawing.Size(350, 36);
            this.textBoxNamePO.TabIndex = 32;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVersion.Location = new System.Drawing.Point(281, 170);
            this.textBoxVersion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(369, 36);
            this.textBoxVersion.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Введите версию ПО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Выберите тип ПО:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DisplayMember = "full_name";
            this.comboBoxType.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Офисное ПО",
            "Среда разработки",
            "Браузер",
            "Антивирус",
            "Просмотр PDF",
            "Архиватор",
            "Мессенджер",
            "СУБД"});
            this.comboBoxType.Location = new System.Drawing.Point(257, 215);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(390, 36);
            this.comboBoxType.TabIndex = 36;
            this.comboBoxType.ValueMember = "employee_id";
            // 
            // comboBoxLicen
            // 
            this.comboBoxLicen.DisplayMember = "full_name";
            this.comboBoxLicen.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLicen.FormattingEnabled = true;
            this.comboBoxLicen.Items.AddRange(new object[] {
            "Коммерческая",
            "Пользовательская",
            "Корпоративная",
            "Бесплатная"});
            this.comboBoxLicen.Location = new System.Drawing.Point(362, 258);
            this.comboBoxLicen.Name = "comboBoxLicen";
            this.comboBoxLicen.Size = new System.Drawing.Size(285, 36);
            this.comboBoxLicen.TabIndex = 38;
            this.comboBoxLicen.ValueMember = "employee_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Выберите тип лицензии ПО:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Candara Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(47, 356);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(230, 39);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Добавить сотрудника";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Beko.Properties.Resources.ad57c0b555aba0663a9c79242996c55171768a4088edce4c9befbf19cfba13ef;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 418);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxLicen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNamePO);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddPO";
            this.Text = "Добавление ПО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNamePO;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxLicen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
    }
}