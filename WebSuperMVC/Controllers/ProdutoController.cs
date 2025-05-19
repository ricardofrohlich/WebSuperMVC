using Microsoft.AspNetCore.Mvc;
using WebSuperMVC.Models;

namespace WebSuperMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = GetProducts();
            return View(produtos); //returnando para a view Index
        }

        private List<Produto> GetProducts()
        {
            return new List<Produto>
            {
                new Produto { Id = 1, Descricao = "Coca cola", Preco = 10.00m },
                new Produto { Id = 2, Descricao = "Pepsi", Preco = 20.00m },
                new Produto { Id = 3, Descricao = "Guaraná", Preco = 30.00m }
            };
        }
    }
}
