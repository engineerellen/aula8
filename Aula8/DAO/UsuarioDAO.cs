using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;


namespace DAO
{
    public class UsuarioDAO
    {
        string connectionString = @"Data Source=LAPTOP-B54P23KG;Initial Catalog=INFONEW;Integrated Security=True;";
        public int InserirUsuario(Usuario u)
        {
            int retorno = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Insert into Login (login,senha,cod_cli) Values(@login, @senha, @cod_cli)";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@login", u.Login);
                cmd.Parameters.AddWithValue("@senha", u.Senha);
                cmd.Parameters.AddWithValue("@cod_cli", u.Cod_Cli);

                try
                {
                    con.Open();
                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return retorno;
        }

        public int AtualizarUsuario(Usuario u)
        {
            int resultado = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Update Login set login = @login, senha = @senha, cod_cli = @cod_cli where ID = @Id";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", u.ID);
                cmd.Parameters.AddWithValue("@login", u.Login);
                cmd.Parameters.AddWithValue("@senha", u.Senha);
                cmd.Parameters.AddWithValue("@cod_cli", u.Cod_Cli);

                try
                {
                    con.Open();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return resultado;
        }

        public int ExcluirUsuario(int id)
        {
            int retorno = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Delete from Login where id = @ID";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    con.Open();
                   retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return retorno;
        }

        public bool validarLoginSenha(Usuario u)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT login,senha from Login", con);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.Login = rdr["login"].ToString();
                        usuario.Senha = rdr["senha"].ToString();

                        lstUsuario.Add(usuario);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }

            foreach (var usu in lstUsuario)
            {
                if (usu.Login == u.Login && usu.Senha == u.Senha)
                {
                    return true;
                }

            }
            return false;
        }

        public List<Usuario> getUsuarios()
        {
            List<Usuario> lstUsuario = new List<Usuario>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT id, login,cod_cli from Login", con);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.ID = Convert.ToInt32(rdr["id"]);
                        usuario.Login = rdr["login"].ToString();
                        usuario.Cod_Cli = Convert.ToInt32(rdr["cod_cli"].ToString());


                        lstUsuario.Add(usuario);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return lstUsuario;
        }

        public bool ValidaLogin(Usuario u)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT login from Login", con);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.Login = rdr["login"].ToString();

                        lstUsuario.Add(usuario);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }

            foreach (var usu in lstUsuario)
            {
                if( usu.Login == u.Login)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
