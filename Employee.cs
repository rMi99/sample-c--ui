using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp2
{
    public partial class Employee : Form
    {

        //string ConnectionString = "Data Source=DESKTOP-8K4V0F1;Initial Catalog=EmployeeManagement;Integrated Security=True";
        string ConnectionString = "Server=localhost;Port=3306;Database=esoft;Uid=root;Pwd=;";
        public Employee()
        {
            InitializeComponent();
            LoadStudent();

        }

        private void dataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadStudent();
        }
        private void LoadStudent()
        {
            MessageBox.Show("Loading data from database...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query1 = "SELECT * FROM student"; // MySQL

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query1, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridEmployee.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();

        }

        private void clearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtNic.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = new DataGridView();

            using (
                MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    //mysql

                    string query = "INSERT INTO student (name, email) VALUES (@name, @email)";//Mysql
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            };


            //if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtContact.Text) || string.IsNullOrEmpty(txtNic.Text))
            //{
            //    MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridEmployee.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE student SET name = @name, email = @email WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(rowsAffected + " Student(s) updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    clearFields();
                    LoadStudent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using MySqlConnection conn = new MySqlConnection(ConnectionString);
            try {  conn.Open();

                string query = "DELETE FROM student WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show(rowsAffected + " Student(s) deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    LoadStudent();
                }
                else
                {
                    MessageBox.Show("No student found with the given ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
