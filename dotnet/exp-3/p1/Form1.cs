using System;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Username or password is empty!");
            }
            else
            {
                if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
                {
                    MessageBox.Show("Login successful!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
        }
    }
}
