namespace CSharpProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Heylo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Carregando form....");
        }
    }
}
