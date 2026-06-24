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
    public partial class FormAddPO : Form
    {
        public FormAddPO()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                string query = @"INSERT INTO Software (software_name, version, software_type, license_type) VALUES (@name, @version, @type, @license)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", textBoxNamePO.Text);
                cmd.Parameters.AddWithValue("@version", textBoxVersion.Text);
                cmd.Parameters.AddWithValue("@type", comboBoxType.SelectedValue);
                cmd.Parameters.AddWithValue("@license", comboBoxLicen.SelectedValue);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Программное обеспечение успешно добавлено!");
                    textBoxNamePO.Clear();
                    textBoxVersion.Clear();                  
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

            }
        }
    }
}
