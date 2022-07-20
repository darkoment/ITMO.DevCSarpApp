namespace WinFormsLab1Task5._2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpeningForm Romb = new OpeningForm();
            Romb.ShowDialog();
        }
    }
}