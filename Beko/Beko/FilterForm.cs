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
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void LoadTypes()
        {
            cmbType.Items.Add("Программа");
            cmbType.Items.Add("Сотрудник");
            cmbType.Items.Add("Компьютер");
            cmbType.Items.Add("Комплектующее");

            cmbType.SelectedIndex = 0;
        }
        private void FilterForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbValue.Items.Clear();
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                conn.Open();

                SqlCommand cmd = null;

                if (cmbType.Text == "Программа")

                    cmd = new SqlCommand("SELECT software_name FROM Software", conn);

                else if (cmbType.Text == "Сотрудник")

                    cmd = new SqlCommand("SELECT full_name FROM Employees", conn);

                else if (cmbType.Text == "Компьютер")

                    cmd = new SqlCommand("SELECT computer_id FROM Computers", conn);

                else if (cmbType.Text == "Комплектующее")

                    cmd = new SqlCommand("SELECT model FROM Components", conn);

                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())

                    cmbValue.Items.Add(r[0].ToString());

            }

            if (cmbValue.Items.Count > 0)

                cmbValue.SelectedIndex = 0;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            string type = cmbType.Text;

            string value = cmbValue.Text;

            string query = "";



            if (type == "Программа")

            {

                query = @"

        SELECT c.computer_id, c.operating_system, e.full_name

        FROM Computers c

        JOIN InstalledSoftware i ON c.computer_id = i.computer_id

        JOIN Software s ON s.software_id = i.software_id

        JOIN Employees e ON e.employee_id = c.employee_id

        WHERE s.software_name = @value";

            }

            else if (type == "Сотрудник")

            {

                query = @"

        SELECT c.computer_id, c.operating_system

        FROM Computers c

        JOIN Employees e ON e.employee_id = c.employee_id

        WHERE e.full_name = @value";

            }

            else if (type == "Компьютер")

            {

                query = @"

        SELECT s.software_name, s.software_type

        FROM Software s

        JOIN InstalledSoftware i ON i.software_id = s.software_id

        WHERE i.computer_id = @value";

            }

            else if (type == "Комплектующее")

            {

                query = @"

        SELECT c.computer_id, c.operating_system

        FROM Computers c

        JOIN Components comp ON comp.computer_id = c.computer_id

        WHERE comp.model = @value";

            }
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@value", value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvResult.DataSource = dt;
                SetHeaders();

            }

        
        }

        private void SetHeaders()
        {
            if (dgvResult.Columns.Contains("computer_id"))
                dgvResult.Columns["computer_id"].HeaderText = "ID компьютера";

            if (dgvResult.Columns.Contains("operating_system"))
                dgvResult.Columns["operating_system"].HeaderText = "Операционная система";

            if (dgvResult.Columns.Contains("full_name"))
                dgvResult.Columns["full_name"].HeaderText = "ФИО сотрудника";

            if (dgvResult.Columns.Contains("software_name"))
                dgvResult.Columns["software_name"].HeaderText = "Программа";

            if (dgvResult.Columns.Contains("software_type"))
                dgvResult.Columns["software_type"].HeaderText = "Тип программы";

            if (dgvResult.Columns.Contains("model"))
                dgvResult.Columns["model"].HeaderText = "Модель";

            if (dgvResult.Columns.Contains("employee_id"))
                dgvResult.Columns["employee_id"].HeaderText = "ID сотрудника";
        }
    }
}
