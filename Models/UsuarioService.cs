
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public List<Usuario> Listar()
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.ToList();
            }
            
        }

        public Usuario Listar(int id){
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Find(id);
            }
        }

        public void incluirUsuario(Usuario novoUser)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Add(novoUser);
                bc.SaveChanges();
            }
        }
        public void editarUsuario(Usuario userEditado)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                //Usuario u = bc.Usuarios.Find(userEditado.Id);
                Usuario u = bc.Usuarios.First( user => user.Id == userEditado.Id);

                u.Login = userEditado.Login;
                u.Nome = userEditado.Nome;
                u.Senha = userEditado.Senha;
                u.Tipo = userEditado.Tipo;

                bc.SaveChanges();
            }
        }

        public void ExcluirUsuario(int id){
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Remove(bc.Usuarios.Find(id));
                bc.SaveChanges();   
            }
        }
    }
}