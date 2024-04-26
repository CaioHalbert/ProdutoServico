using Microsoft.EntityFrameworkCore;
using ProdutoServico.Models;

namespace ProdutoServico.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options)
        {
        }

        public DbSet<Produto> produtos { get; set; }
        public DbSet<Categoria> categorias { get; set; }
    }
}
