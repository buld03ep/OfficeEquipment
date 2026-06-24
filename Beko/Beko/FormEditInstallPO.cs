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
    public partial class FormEditInstallPO : Form
    {
        public FormEditInstallPO()
        {
            InitializeComponent();
        }

        private void FormEditInstallPO_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.InstalledSoftware". При необходимости она может быть перемещена или удалена.
            this.installedSoftwareTableAdapter.Fill(this.officeEquipmentDBDataSet.InstalledSoftware);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.installedSoftwareTableAdapter.Update(this.officeEquipmentDBDataSet.InstalledSoftware);
            MessageBox.Show(
                "Изменения успешно сохранены!",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
