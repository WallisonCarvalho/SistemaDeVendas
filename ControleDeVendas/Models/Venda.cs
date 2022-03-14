using ControleDeVendas.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ControleDeVendas.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Data da Venda")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataVenda { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Valor")]
        [Required(ErrorMessage = "{0} required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double ValorVenda { get; set; }

        [Display(Name = "Quantidade")]
        public int QtdeVenda { get; set; }
        [Display(Name = "Valor da Venda")]
        public VendasStatus Status { get; set; }

        public Vendedor Vendedor { get; set; }
        [Display(Name = "Vendedor")]
        public int VendedorId { get; set; }
        public Produto Produto { get; set; }
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        


        public Venda()
        {
        }
        public Venda(int id, DateTime dataVenda, double valorVenda, int qtdeVenda, VendasStatus status, Vendedor vendedor, Produto produto)
        {
            Id = id;
            DataVenda = dataVenda;
            ValorVenda = valorVenda;
            QtdeVenda = qtdeVenda;
            Status = status;
            Vendedor = vendedor;
            Produto = produto;
        }

        internal static Task<string> ToListAsync()
        {
            throw new NotImplementedException();
        }
        //public string ConvertendoVendedor()
        //{
        //    var ni = Vendedor.Name = VendedorId.ToString();
        //    return ni;
        //}
        //public string ConvertendoProduto()
        //{
        //    var ni = Produto.Nome = ProdutoId.ToString();
        //    return ni;
        //}
    }
}
