﻿using BibliotecaGames.BLL.Exceptions;
using BibliotecaGames.DAL;
using BibliotecaGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL.Autenticacao
{
    class LoginBO
    {
        private UsuarioDAO _usuarioDAO;
        public Usuario ObterUsuarioParaLogar(string nomeUsuario, string senha)
        {
            var usuario = _usuarioDAO.ObterUsuarioPorUsuarioSenha(nomeUsuario, senha);
            if(usuario == null)
            {
                throw new UsuarioNaoCadastradoException();
            }
            else
            {
                return usuario;
            }
        }
    }
}
