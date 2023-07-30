using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esc_v1
{
    internal class Usuarios
    {
        private string email = "";
        private string nome = "";
        private string perfil = "";
        private string password = "";
        private string sub = "";
        private string picture = "";
        private int status = 1;

        //Adicionando os Getters e Setters

        #region E-mail
        public string GetEmail()
        {
            return email;
        }
        public string SetEmail(string email)
        {
            return this.email = email;
        }
        #endregion

        #region Nome
        public string GetNome()
        {
            return nome;
        }
        public string SetNome(string nome)
        {
            return this.nome = nome;
        }
        #endregion

        #region Perfil
        public string GetPerfil()
        {
            return perfil;
        }
        public string SetPerfil(string perfil)
        {
            return this.perfil = perfil;
        }
        #endregion

        #region Password
        public string SetPassword(string password)
        {
            return this.password = password;
        }
        #endregion

        #region Sub
        public string GetSub()
        {
            return sub;
        }
        public string SetSub(string sub)
        {
            return this.sub = sub;
        }
        #endregion

        #region Picture
        public string GetPicture()
        {
            return picture;
        }
        public string SetPicture(string picture)
        {
            return this.picture = picture;
        }
        #endregion

        #region Status
        public int GetStatus()
        {
            return status;
        }
        public int SetStatus(int status)
        {
            return this.status = status;
        }
        #endregion

    }
}
