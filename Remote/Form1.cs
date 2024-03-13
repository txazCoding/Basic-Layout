using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Remote
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; // Add System.Windows.Forms namespace
        private double opacityIncrement = 0.05;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private bool mousedown;

        public Form1()
        {
            InitializeComponent();
            AnimateForm();
        }

        public Form1(string username) : this()
        {
            // Set the username label text
            lblUsername.Text = "Welcome, " + username + "!";
        }

        private void AnimateForm()
        {
            // Set the initial opacity to 0
            this.Opacity = 0;

            // Create a timer for the animation
            timer = new System.Windows.Forms.Timer(); // Use System.Windows.Forms.Timer
            timer.Interval = 25;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Increase opacity gradually until it reaches 1
            if (this.Opacity < 1)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                // Stop the timer when opacity reaches 1
                timer.Stop();
            }
        }

        private void loadForm(Form form)
        {
            // Clear existing controls from the panel
            mainpanel.Controls.Clear();

            // Set form properties
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            // Add form to the panel
            mainpanel.Controls.Add(form);

            // Show the form
            form.Show();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenForm1_Click(object sender, EventArgs e)
        {
            loadForm(new Form2());
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            loadForm(new Form3());
        }

        private void btnOpenForm3_Click(object sender, EventArgs e)
        {
            loadForm(new Form4());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
