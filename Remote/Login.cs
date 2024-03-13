using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Remote
{
    public partial class Login : Form
    {
        private System.Windows.Forms.Timer timer; // Add System.Windows.Forms namespace
        private double opacityIncrement = 0.05;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Import necessary WinAPI functions
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte bAlpha, int dwFlags);

        // Constants for WinAPI functions
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x80000;
        private const int LWA_ALPHA = 0x2;

        private bool mousedown;


        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
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


                // Show the main form and pass the username

                // Start the main application message loop with Form1
                var myForm = new Form1(username);
                myForm.Show();



            }
            else
            {
                // If the credentials are invalid, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Opacity = 90;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
