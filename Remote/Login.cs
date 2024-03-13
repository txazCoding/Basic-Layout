using System;
using System.Windows.Forms;

namespace Remote
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve username and password entered by the user
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate the credentials (for demonstration, use a hardcoded username and password)
            string validUsername = "admin";
            string validPassword = "password";

            if (username == validUsername && password == validPassword)
            {
                // If the credentials are valid, show a success message and close the login form
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide the login form

                // Start the main application message loop with Form1
                var myForm = new Form1();
                myForm.Show();
            }
            else
            {
                // If the credentials are invalid, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
