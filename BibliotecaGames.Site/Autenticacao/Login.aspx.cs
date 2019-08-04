using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaGames.BLL.Autenticacao;
using BibliotecaGames.BLL.Exceptions;

namespace BibliotecaGames.Site.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBO _loginBO;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            _loginBO = new LoginBO();

            var nomeUsuario = TxtUsuario.Text;
            var senha = TxtSenha.Text;

            try
            {
                var usuario = _loginBO.ObterUsuarioParaLogar(nomeUsuario, senha);
            }
            catch (UsuarioNaoCadastradoException)
            {
                LblStatus.Text = "Usuário não cadastrado";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}