using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class EmprestimoService 
    {
        public void Inserir(Emprestimo e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Emprestimos.Add(e);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Emprestimo e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Emprestimo emprestimo = bc.Emprestimos.Find(e.Id);
                emprestimo.NomeUsuario = e.NomeUsuario;
                emprestimo.Telefone = e.Telefone;
                emprestimo.Id = e.Id;
                emprestimo.DataEmprestimo = e.DataEmprestimo;
                emprestimo.DataDevolucao = e.DataDevolucao;
                emprestimo.Devolvido = e.Devolvido;

                bc.SaveChanges();
            }
        }

        public ICollection<Emprestimo> ListarTodos(FiltrosEmprestimos filtro)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Emprestimo> consulta;

                if (filtro == null)
                {
                }
                else
                {
                    //definindo dinamicamente a filtragem
                    switch (filtro.TipoFiltro)
                    {
                        case "Usuario":
                            consulta = bc.Emprestimos.Where(l => l.NomeUsuario.Contains(filtro.Filtro));
                            break;

                        case "Livro":
                            List<Livro> LivrosFiltrados = bc.Livros.Where(l => l.Titulo.Contains(filtro.Filtro)).ToList();

                            List<int> LivrosIds = new List<int>();
                            for (int i = 0; i < LivrosFiltrados.Count; i++)
                            {
                                LivrosIds.Add(LivrosFiltrados[i].Id);
                            }
                            break;

                        default:
                            consulta = bc.Emprestimos;
                            break;
                    }
                }
                consulta = bc.Emprestimos;

                List<Emprestimo> ListaConsulta = consulta.OrderBy(e => e.DataEmprestimo).ToList();
                for(int i = 0; i < ListaConsulta.Count; i++)
                {
                    ListaConsulta[i].Livro = bc.Livros.Find(ListaConsulta[i].LivroId);
                }
                //ordenação padrão
                return ListaConsulta;
            }
        }

        public Emprestimo ObterPorId(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Emprestimos.Find(id);
            }
        }
    }
}