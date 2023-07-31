﻿using Microsoft.EntityFrameworkCore;

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

        public async Task<Produto> AddProdutoAsync(Produto produto)
        {
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
                var produtoSeek = _context.Produtos.FirstOrDefaultAsync(opt => opt.Id == produto.Id);
                if (produtoSeek != null)
                {
                    _context.Update(produtoSeek);
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
