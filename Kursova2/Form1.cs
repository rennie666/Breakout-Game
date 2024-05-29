namespace Kursova2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.ShowDialog();

        }

        private void helpBttn_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}