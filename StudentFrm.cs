using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class StudentFrm : Form
    {
        public StudentFrm()
        {
            InitializeComponent();
<<<<<<< HEAD
        }
        private void SaveBtn_Click(object sender, EventArgs e)
=======
            LoadStudents();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadStudents()
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
        {
            string con = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            using (SqlConnection conConn = new SqlConnection(con))
            {
                conConn.Open();
<<<<<<< HEAD
                SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT VALUES(@id,@name,@add,@dob)", conConn);
                cmd.Parameters.AddWithValue("@id",studentIDBox.Text.Trim());
                cmd.Parameters.AddWithValue("@name",fullNameBox.Text.Trim());
                cmd.Parameters.AddWithValue("@add",addressBox.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", dobPicker.Value);
                cmd.ExecuteNonQuery();
                conConn.Close();
                MessageBox.Show("Student created with Success");

            }

=======
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM STUDENT", conConn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                studentIDBox.Text = row.Cells["id"].Value.ToString();
                fullNameBox.Text = row.Cells["name"].Value.ToString();
                addressBox.Text = row.Cells["address"].Value.ToString();
                dobPicker.Value = Convert.ToDateTime(row.Cells["dob"].Value);
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentIDBox.Text) || string.IsNullOrWhiteSpace(fullNameBox.Text))
            {
                MessageBox.Show("Please fill Student ID and Full Name");
                return;
            }

            string con = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            using (SqlConnection conConn = new SqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT VALUES(@id,@name,@add,@dob)", conConn);
                    cmd.Parameters.AddWithValue("@id", studentIDBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", fullNameBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@add", addressBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", dobPicker.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student created with Success");
                    LoadStudents();
                    ClearFields();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Student ID already exists");
                    else
                        MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateBrn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentIDBox.Text) || string.IsNullOrWhiteSpace(fullNameBox.Text))
            {
                MessageBox.Show("Please fill Student ID and Full Name");
                return;
            }

            string con = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            using (SqlConnection conConn = new SqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE STUDENT SET name=@name, address=@add, dob=@dob WHERE id=@id", conConn);
                    cmd.Parameters.AddWithValue("@id", studentIDBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", fullNameBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@add", addressBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", dobPicker.Value);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Student updated successfully");
                        LoadStudents();
                        ClearFields();
                    }
                    else
                        MessageBox.Show("Student ID not found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentIDBox.Text))
            {
                MessageBox.Show("Please select a student to delete");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            string con = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            using (SqlConnection conConn = new SqlConnection(con))
            {
                try
                {
                    conConn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT WHERE id=@id", conConn);
                    cmd.Parameters.AddWithValue("@id", studentIDBox.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Student deleted successfully");
                        LoadStudents();
                        ClearFields();
                    }
                    else
                        MessageBox.Show("Student ID not found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            studentIDBox.Clear();
            fullNameBox.Clear();
            addressBox.Clear();
            dobPicker.Value = DateTime.Now;
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
        }
    }
}
