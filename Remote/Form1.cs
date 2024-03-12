using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Remote
{
    public partial class Form1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Form3());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Form4());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
