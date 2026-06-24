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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                string query = @"INSERT INTO Employees (full_name, position, phone, email) VALUES (@full_name, @position, @phone, @email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@full_name", textBoxFullName.Text);
                command.Parameters.AddWithValue("@position", textBoxPosition.Text);
                command.Parameters.AddWithValue("@phone", maskedTextBoxPhone.Text);
                command.Parameters.AddWithValue("@email", textBoxMail.Text);

                try

                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник успешно добавлен!");
                    DialogResult = DialogResult.OK;
                    Close();
                    textBoxFullName.Clear();
                    textBoxPosition.Clear();
                    maskedTextBoxPhone.Clear();
                    textBoxMail.Clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
