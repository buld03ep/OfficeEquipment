using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beko
{
    public partial class FormEditEmployee : Form
    {
        public FormEditEmployee()
        {
            InitializeComponent();
        }

        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.officeEquipmentDBDataSet.Employees);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Update(this.officeEquipmentDBDataSet.Employees);
            MessageBox.Show(
                "Изменения успешно сохранены!",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
