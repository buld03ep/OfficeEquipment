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
    public partial class FormEditComponent : Form
    {
        public FormEditComponent()
        {
            InitializeComponent();
        }

        private void FormEditComponent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter.Fill(this.officeEquipmentDBDataSet.Components);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.componentsTableAdapter.Update(this.officeEquipmentDBDataSet.Components);
            MessageBox.Show(
                "Изменения успешно сохранены!",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
