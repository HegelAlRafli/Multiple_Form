namespace multipleform
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnhal2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}