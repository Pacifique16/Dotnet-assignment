using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "admin" && textBox2.Text == "admin")
            {
                StudentFrm studentFrm = new StudentFrm();
                studentFrm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Usernam and or Password");
            }
        }
    }
}
