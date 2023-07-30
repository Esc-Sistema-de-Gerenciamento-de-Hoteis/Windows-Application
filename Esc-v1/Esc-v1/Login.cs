namespace Esc_v1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region Autenticacao
        private void button1_Click(object sender, EventArgs e) //Entrar
        {
            Autenticacao();
        }

        public async void Autenticacao()
        {
            API post = new API();
            string jsonData = "{\"email\":\"" + EmailTxt.Text + "\", \"password\":\"" + PasswordTxt.Text + "\"}";

            string response = await post.SendDataToApiAsync("http://127.0.0.1:3333/v1/autenticacao", jsonData);
            
            if(response == "Usuario autenticado")
            {
                MessageBox.Show("Seja bem vindo!","Welcome",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home janela = new Home();
                janela.Show();

            }
            else
            {
                MessageBox.Show("Erro! \\ Login ou senha incorretos, favor verificar e tentar novamente!", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTxt.Text = "";
            }

        }

        #endregion


    }

}