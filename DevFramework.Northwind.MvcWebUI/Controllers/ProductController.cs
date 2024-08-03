using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Product
            {
                CategoryId = 1, ProductId = 1, ProductName = "Telefon", QuantityPerUnit = "1000",
                UnitPrice = 1000, UnitsInStock = 5
            });
            return "Added!";
        }

        public string AddUpdate()
        {
            _productService.TransactionalOperation(new Product
            {
                CategoryId = 1,
                ProductName = "Bilgisayar",
                QuantityPerUnit = "1000",
                UnitPrice = 21,
            }, new Product
            {
                CategoryId = 1,
                ProductId = 2,
                ProductName = "Bilgisayar2",
                QuantityPerUnit = "1000",
                UnitPrice = 2000,
            });
            return "Done!";
        }


    }
}