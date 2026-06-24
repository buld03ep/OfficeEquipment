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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadEmployees()
        {
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.officeEquipmentDBDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.InstalledSoftware". При необходимости она может быть перемещена или удалена.
            this.installedSoftwareTableAdapter.Fill(this.officeEquipmentDBDataSet.InstalledSoftware);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.InstalledSoftware". При необходимости она может быть перемещена или удалена.
            this.installedSoftwareTableAdapter.Fill(this.officeEquipmentDBDataSet.InstalledSoftware);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.InstalledSoftware". При необходимости она может быть перемещена или удалена.
            this.installedSoftwareTableAdapter.Fill(this.officeEquipmentDBDataSet.InstalledSoftware);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Software". При необходимости она может быть перемещена или удалена.
            this.softwareTableAdapter.Fill(this.officeEquipmentDBDataSet.Software);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Computers". При необходимости она может быть перемещена или удалена.
            this.computersTableAdapter.Fill(this.officeEquipmentDBDataSet.Computers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officeEquipmentDBDataSet.Components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter.Fill(this.officeEquipmentDBDataSet.Components);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridView grid = null;
            string table = "";
            string idColumn = "";

            if (tabControl1.SelectedTab.Name == "tabPageEmployee")
            {
                grid = dataGridView1;
                table = "Employees";
                idColumn = "employee_id";
            }

            else if (tabControl1.SelectedTab.Name == "tabPageComputer")
            {
                grid = dataGridView2;
                table = "Computers";
                idColumn = "computer_id";
            }

            else if (tabControl1.SelectedTab.Name == "tabPageComponent")
            {
                grid = dataGridView3;
                table = "Components";
                idColumn = "component_id";
            }

            else if (tabControl1.SelectedTab.Name == "tabPagePO")
            {
                grid = dataGridView4;
                table = "Software";
                idColumn = "software_id";
            }

            else if (tabControl1.SelectedTab.Name == "tabPageInstallPO")
            {
                grid = dataGridView5;
                table = "InstalledSoftware";
                idColumn = "install_id";
            }

            // проверка

            if (grid == null || grid.CurrentRow == null)
            {
                MessageBox.Show("Выберите строку для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы точно хотите удалить запись?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value);
            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"DELETE FROM {table} WHERE {idColumn} = @id",conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Удалено!");

                if (table == "Employees")

                    this.employeesTableAdapter.Fill(this.officeEquipmentDBDataSet.Employees);

                else if (table == "Computers")

                    this.computersTableAdapter.Fill(this.officeEquipmentDBDataSet.Computers);

                else if (table == "Components")

                    this.componentsTableAdapter.Fill(this.officeEquipmentDBDataSet.Components);

                else if (table == "Software")

                    this.softwareTableAdapter.Fill(this.officeEquipmentDBDataSet.Software);

                else if (table == "InstalledSoftware")

                    this.installedSoftwareTableAdapter.Fill(this.officeEquipmentDBDataSet.InstalledSoftware);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPageEmployee")
            {
                FormAddEmployee form = new FormAddEmployee();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.employeesTableAdapter.Fill(this.officeEquipmentDBDataSet.Employees);
                }
            }

            else if (tabControl1.SelectedTab.Name == "tabPageComputer")
            {
                FormAddComputer form = new FormAddComputer();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.computersTableAdapter.Fill(this.officeEquipmentDBDataSet.Computers);
                }
            }

            else if (tabControl1.SelectedTab.Name == "tabPageComponent")
            {
                FormAddComponent form = new FormAddComponent();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.componentsTableAdapter.Fill(this.officeEquipmentDBDataSet.Components);
                }
            }

            else if (tabControl1.SelectedTab.Name == "tabPagePO")
            {
                FormAddPO form = new FormAddPO();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.softwareTableAdapter.Fill(this.officeEquipmentDBDataSet.Software);
                }
            }

            else if (tabControl1.SelectedTab.Name == "tabPageInstallPO")
            {
                FormAddInstallPO form = new FormAddInstallPO();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.installedSoftwareTableAdapter.Fill(this.officeEquipmentDBDataSet.InstalledSoftware);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPageEmployee")
            {
                FormEditEmployee form = new FormEditEmployee();
                form.ShowDialog();
            }

            else if (tabControl1.SelectedTab.Name == "tabPageComputer")
            {
                FormEditComputer form = new FormEditComputer();
                form.ShowDialog();
            }

            else if (tabControl1.SelectedTab.Name == "tabPageComponent")
            {
                FormEditComponent form = new FormEditComponent();
                form.ShowDialog();
            }

            else if (tabControl1.SelectedTab.Name == "tabPagePO")
            {
                FormEditPO form = new FormEditPO();
                form.ShowDialog();
            }

            else if (tabControl1.SelectedTab.Name == "tabPageInstallPO")
            {
                FormEditInstallPO form = new FormEditInstallPO();
                form.ShowDialog();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;

            string connectionString = @"Data Source=pc2a;Initial Catalog=OfficeEquipmentDB;Integrated Security=True;Encrypt=False";
            string query = "";

            DataGridView grid = null;

            if (tabControl1.SelectedTab.Name == "tabPageEmployee")
            {
                query = "SELECT * FROM Employees WHERE full_name LIKE @search OR position LIKE @search OR phone LIKE @search OR email LIKE @search";
                grid = dataGridView1;
            }

            else if (tabControl1.SelectedTab.Name == "tabPageComputer")
            {
                query = "SELECT * FROM Computers WHERE operating_system LIKE @search";
                grid = dataGridView2;
            }

            else if (tabControl1.SelectedTab.Name == "tabPageComponent")
            {
                query = @"SELECT * FROM Software WHERE software_name LIKE @search OR version LIKE @search OR software_type LIKE @search OR license_type LIKE @search";
                grid = dataGridView3;
            }

            else if (tabControl1.SelectedTab.Name == "tabPagePO")
            {
                query = @"SELECT * FROM Software WHERE software_name LIKE @search OR version LIKE @search OR software_type LIKE @search OR license_type LIKE @search";
                grid = dataGridView4;
            }

            else if (tabControl1.SelectedTab.Name == "tabPageInstallPO")
            {
                query = @"SELECT * FROM InstalledSoftware WHERE CAST(computer_id AS VARCHAR) LIKE @search OR CAST(software_id AS VARCHAR) LIKE @search";
                grid = dataGridView5;
            }

            if (query == "")
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + search + "%");

                DataTable table = new DataTable();
                adapter.Fill(table);
                grid.DataSource = table;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.officeEquipmentDBDataSet.Employees);
            this.computersTableAdapter.Fill(this.officeEquipmentDBDataSet.Computers);
            this.componentsTableAdapter.Fill(this.officeEquipmentDBDataSet.Components);
            this.softwareTableAdapter.Fill(this.officeEquipmentDBDataSet.Software);
            this.installedSoftwareTableAdapter.Fill(this.officeEquipmentDBDataSet.InstalledSoftware);

            textBoxSearch.Clear();
        }
    }
}
