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
    public partial class FormAddComputer : Form
    {
        public FormAddComputer()
        {
            InitializeComponent();
        }

        private void FormAddComputer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.officeEquipmentDBDataSet.Employees);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                string query = @"INSERT INTO Computers (operating_system, employee_id) VALUES (@operating_system, @employee_id)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@operating_system", textBoxOS.Text);
                cmd.Parameters.AddWithValue("@employee_id", comboBoxEmployee.SelectedValue);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Компьютер успешно добавлен!");
                    textBoxOS.Clear();
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

            }
        }
    }
}
