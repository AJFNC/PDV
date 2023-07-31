using Microsoft.EntityFrameworkCore;

namespace PDV.Data
{
    public class ProdutoContext : DbContext
    {

        //public ProdutoContext() { }

        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options) { 
        
        }
        public DbSet<Produto> Produtos { get; set; }

    }
}
