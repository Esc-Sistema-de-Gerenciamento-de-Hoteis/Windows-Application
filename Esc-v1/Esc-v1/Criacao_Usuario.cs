using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;





namespace Esc_v1
{
    public partial class Criacao_Usuario : Form
    {
        public Criacao_Usuario()
        {
            InitializeComponent();

        }


        #region Salvar
        private async void button1_Click(object sender, EventArgs e) //Salvar
        {
            //Validando se todos os campos foram preenchidos
            if (EmailTxt.Text == "" || NomeTxt.Text == "" || PerfilTxt.Text == "" || PasswordTxt.Text == "" || ConfirmaPasswordTxt.Text == "")
            {
                MessageBox.Show("Favor preencher todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (PasswordTxt.Text == ConfirmaPasswordTxt.Text)
                {

                    Usuarios usuario = new Usuarios();
                    usuario.SetEmail(EmailTxt.Text);
                    usuario.SetNome(NomeTxt.Text);
                    usuario.SetPassword(PasswordTxt.Text);

                    // The API URL you want to send data to
                    string apiUrl = "http://127.0.0.1:3333/v1/criacao_usuario";

                    // Your data in JSON format
                    string jsonData = "{\"email\":\"" + EmailTxt.Text + "\", \"nome\":\"" + NomeTxt.Text + "\",\"password\":\"" + PasswordTxt.Text + "\"}";

                    // Call the method to send the data to the API
                    API post = new API();

                    string response = await post.SendDataToApiAsync(apiUrl, jsonData);


                    // Do something with the API response, e.g., display it in a label
                    MessageBox.Show(response);
                    Limpar();
                }
                else
                {
                    PasswordTxt.Text = "";
                    ConfirmaPasswordTxt.Text = "";
                    MessageBox.Show("Favor preencher a senha e a confirmação da senha corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        #endregion

        #region Limpar
        private void button2_Click(object sender, EventArgs e) //Limpar
        {
            Limpar();
        }

        public void Limpar()
        {
            EmailTxt.Text = "";
            NomeTxt.Text = "";
            PerfilTxt.Text = "";
            PasswordTxt.Text = "";
            ConfirmaPasswordTxt.Text = "";
        }

        #endregion

        private void Criacao_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
