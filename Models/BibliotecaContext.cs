using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Biblioteca.Models
{
    
    public class BibliotecaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {         
            optionsBuilder.UseMySql("Server=localhost;DataBase=Biblioteca;Uid=root;", new MariaDbServerVersion(new System.Version(3,0,1)));
        }

        public DbSet<Livro> Livros {get; set;}
        public DbSet<Emprestimo> Emprestimos {get; set;}
        
    }
    
    
}

