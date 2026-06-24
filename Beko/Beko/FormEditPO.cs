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
    public partial class FormEditPO : Form
    {
        public FormEditPO()
        {
            InitializeComponent();
        }

        private void FormEditPO_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Software". При необходимости она может быть перемещена или удалена.
            this.softwareTableAdapter.Fill(this.officeEquipmentDBDataSet.Software);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.softwareTableAdapter.Update(this.officeEquipmentDBDataSet.Software);
            MessageBox.Show(
                "Изменения успешно сохранены!",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
