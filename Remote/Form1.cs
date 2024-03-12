using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Remote
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        bool mousedown;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadform(new Form2());

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            loadform(new Form3());

        }


        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            loadform(new Form4());

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            loadform(new Form4());

        }
    }
}
