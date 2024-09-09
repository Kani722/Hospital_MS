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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            admin.Text = " ";
            password.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (admin.Text == " " && password.Text == " ")
            {
                MessageBox.Show("Enter the Information");
            }
            else if (admin.Text == "User" && password.Text == "1234")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter the correct Username and Password");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
