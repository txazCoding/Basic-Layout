using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Remote
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private bool mousedown;

        public Form1()
        {
            InitializeComponent();
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
            label1.BackColor = Color.Transparent;

        }
    }

    // Custom label with glow effect
    // Custom label with glow effect
    public class CustomLabelWithGlow : Label
    {
        public CustomLabelWithGlow()
        {
            // Set label properties
            AutoSize = false;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font(Font.FontFamily, 12f, FontStyle.Bold);
        }

    }

}
