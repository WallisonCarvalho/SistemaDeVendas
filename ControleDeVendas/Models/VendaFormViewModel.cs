using System.Collections.Generic;

namespace ControleDeVendas.Models
{
    public class VendaFormViewModel
    {
        private readonly Venda _context;

        public VendaFormViewModel(Venda context)
        {
            _context = context;
        }
        public Venda Venda { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        

        public VendaFormViewModel()
        {
        }

        //public VendaFormViewModel(Venda venda)
        //{
        //    Venda = venda;
        //}

    }
}
