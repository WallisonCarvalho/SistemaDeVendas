using ControleDeVendas.Data;
using ControleDeVendas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeVendas.Services
{
    public class VendaService
    {
        private readonly ControleDeVendasContext _context;

        public VendaService(ControleDeVendasContext context)
        {
            _context = context;
        }
        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.OrderBy(x => x.Name).ToList();
        }
       
    }
}
