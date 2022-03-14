using ControleDeVendas.Data;
using ControleDeVendas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeVendas.Services
{
    public class ProdutoService
    {

        private readonly ControleDeVendasContext _context;

        public ProdutoService(ControleDeVendasContext context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.OrderBy(x => x.Nome).ToList();
        }
    }
}
