using System;
using System.Collections.Generic;
using Model;
using DAO;

namespace BL
{
    public class UsuarioBL
    {
        UsuarioDAO objDao;
        public int InserirUsuario(Usuario u)
        {
            objDao = new UsuarioDAO();
            return objDao.InserirUsuario(u);
        }

        public int AtualizarUsuario(Usuario u)
        {
            objDao = new UsuarioDAO();
            return objDao.AtualizarUsuario(u);
        }

        public int ExcluirUsuario(int id)
        {
            objDao = new UsuarioDAO();
            return objDao.ExcluirUsuario(id);
        }

        public List<Usuario> getUsuarios()
        {
            objDao = new UsuarioDAO();
            return objDao.getUsuarios();
        }

        public bool ValidaLogin(Usuario u)
        {
            objDao = new UsuarioDAO();
            return objDao.ValidaLogin(u);
        }

        public bool ValidarLoginSenha(Usuario u)
        {
            objDao = new UsuarioDAO();
            return objDao.validarLoginSenha(u);
        }


    }
}
