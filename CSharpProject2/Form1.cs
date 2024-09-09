namespace CSharpProject2
{
    public partial class FRM2 : Form
    {
        public FRM2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM2_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu nome é: " + txtNome.Text);
        }
    }
}
