using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleDeVendas.Data;
using ControleDeVendas.Models;
using ControleDeVendas.Services;

namespace ControleDeVendas.Controllers
{
    public class VendasController : Controller
    {
        
        private readonly ProdutoService _produtoService;
        private readonly VendaService _vendaService;

        private readonly ControleDeVendasContext _context;

        public VendasController(ControleDeVendasContext context, VendaService vendaService, ProdutoService produtoService)
        {
            _context = context;
            _vendaService = vendaService;
            _produtoService = produtoService;
           

        }

        // GET: Vendas
        public IActionResult Index()
        {
            var resul = _context.Venda
       .Include(c => c.Vendedor)
       .Include(c => c.Produto)
       .AsNoTracking();
            return View(resul);
        }


        // GET: Vendas/Create
        public IActionResult Create()
        {
            var vendedor = _vendaService.FindAll();
            var produto = _produtoService.FindAll();

            var viewModel = new VendaFormViewModel { Vendedores = vendedor, Produtos = produto };
            return View(viewModel);
        }



        // POST: Vendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataVenda,ValorVenda,QtdeVenda,ProdutoId,VendedorId")] Venda venda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(venda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }
    }
}
