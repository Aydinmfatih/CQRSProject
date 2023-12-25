using CQRSProject.CQRSPattern.Commands;
using CQRSProject.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommand;

        public ProductController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommand)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommand = createProductCommand;
        }




        public IActionResult Index()
        {
            var value = _getProductQueryHandler.Handle();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
   
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductCommand command)
        {
            _createProductCommand.Handle(command);
            return View();
        }

    }
}
