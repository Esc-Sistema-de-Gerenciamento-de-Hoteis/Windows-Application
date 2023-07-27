namespace Esc_v1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Entrar
        {
            Home janela = new Home();
            janela.Show();
        }
    }
}