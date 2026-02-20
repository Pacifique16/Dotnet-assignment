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
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            using (SqlConnection conConn = new SqlConnection(con))
            {
                conConn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT VALUES(@id,@name,@add,@dob)", conConn);
                cmd.Parameters.AddWithValue("@id",studentIDBox.Text.Trim());
                cmd.Parameters.AddWithValue("@name",fullNameBox.Text.Trim());
                cmd.Parameters.AddWithValue("@add",addressBox.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", dobPicker.Value);
                cmd.ExecuteNonQuery();
                conConn.Close();
                MessageBox.Show("Student created with Success");

            }

        }
    }
}
