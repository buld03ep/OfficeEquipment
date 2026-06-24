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
    public partial class FormEditComputer : Form
    {
        public FormEditComputer()
        {
            InitializeComponent();
        }

        private void FormEditComputer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Computers". При необходимости она может быть перемещена или удалена.
            this.computersTableAdapter.Fill(this.officeEquipmentDBDataSet.Computers);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.computersTableAdapter.Update(this.officeEquipmentDBDataSet.Computers);
            MessageBox.Show(
                "Изменения успешно сохранены!",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
