using Microsoft.EntityFrameworkCore;


namespace PDV.Data
{
    public class ProdutoService
    {

        private readonly ProdutoContext _context;
        public ProdutoService(ProdutoContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> GetProdutosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<List<Produto>> GetProdutoByNomeAsync(string nome)
        {
            //var produto = await _context.Produtos.Where(p => p.Nome.Contains(nome)).ToListAsync();

            //if (produto != null)
            //{
            //    return produto;
            //}
            //return (List<Produto>)produto.DefaultIfEmpty<Produto>();

            return await _context.Produtos.Where(p => p.Nome.Contains(nome)).ToListAsync();
        }

        public async Task<Produto> AddProdutoAsync(Produto produto)
        {
            if(produto.Quantidade == null) throw new ArgumentNullException(nameof(produto));
            try
            {
                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return produto;
        }

        public async Task<Produto> UpdateProdutoAsync(Produto produto)
        {
            try
            {
                var produtoSeek = await _context.Produtos.FirstOrDefaultAsync(opt => opt.Id == produto.Id);
                if (produtoSeek != null)
                {
                    _context.Produtos.Update(produtoSeek);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return produto;
        }

        public async Task DeleteProdutoAsync(Produto produto)
        {
            try
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
