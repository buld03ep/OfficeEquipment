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
    public partial class FormAddComponent : Form
    {
        public FormAddComponent()
        {
            InitializeComponent();
        }

        private void FormAddComponent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Computers". При необходимости она может быть перемещена или удалена.
            this.computersTableAdapter.Fill(this.officeEquipmentDBDataSet.Computers);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                string query = @"INSERT INTO Components 

        (component_type, model, manufacturer, specifications, computer_id) 

        VALUES (@type, @model, @manufacturer, @specs, @computer_id)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@type", comboBoxType.Text);

                cmd.Parameters.AddWithValue("@model", textBoxModel.Text);

                cmd.Parameters.AddWithValue("@manufacturer", textBoxManufactor.Text);

                cmd.Parameters.AddWithValue("@specs", textBoxSpec.Text);

                cmd.Parameters.AddWithValue("@computer_id", comboBoxComp.Text);

                try

                {

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Компонент успешно добавлен!");

                }

                catch (Exception ex)

                {

                    MessageBox.Show("Ошибка: " + ex.Message);

                }

            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
