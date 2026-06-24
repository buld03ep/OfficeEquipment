using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beko
{
    public partial class FormAddInstallPO : Form
    {
        public FormAddInstallPO()
        {
            InitializeComponent();
        }

        private void FormAddInstallPO_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Software". При необходимости она может быть перемещена или удалена.
            this.softwareTableAdapter.Fill(this.officeEquipmentDBDataSet.Software);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Computers". При необходимости она может быть перемещена или удалена.
            this.computersTableAdapter.Fill(this.officeEquipmentDBDataSet.Computers);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                string query = @"INSERT INTO InstalledSoftware (computer_id, software_id, install_date) VALUES (@computer_id, @software_id, @install_date)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@computer_id", comboBoxComp.SelectedValue);
                cmd.Parameters.AddWithValue("@software_id", comboBoxSoft.SelectedValue);
                cmd.Parameters.AddWithValue("@install_date", dateTimePickerSoft.Value.Date);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ПО успешно установлено!");
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

            }
        }
    }
}
