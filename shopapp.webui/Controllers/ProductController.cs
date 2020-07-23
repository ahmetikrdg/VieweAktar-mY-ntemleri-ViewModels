using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        //localhost:5000/product/list
        public IActionResult Index()
        {
            //ViewData,viewbag , Model,  yoluyla bilgi gönderebiliriz

            var product = new Product { Name = "Iphone X", Price = 6000, Description = "İyi Telefon" };
            // ViewData["Product"]=product;
            //ViewData["Category"]="Telefonlar";
            //---
            ViewBag.Category = "Telefonlar";
            //ViewBag.Product=product;

            return View(product);//model
        }
        public IActionResult list()
        {
            var product = new List<Product>(){
           new Product{Name="Iphone 8", Price=3000,Description="İyi telefon"},
           new Product{Name="Iphone X", Price=6000,Description="Güzel telefon"}
            };


            var category = new Category { Name = "Telefon", Description = "Telefon kateogrisi" };
            //paketleyip göndereceğim
            var productsViewModel = new ProductViewModel//her ikisinide kullanmak için progda viewmodels klasörü açtım içine category ve list ekledim
            {
                Category = category, //burada oluşturduğum category ve productu productview modele gönderdim
                Products = product
            };

            return View(productsViewModel);//burdanda viewe gönderdim ve şimdi productsviewmodeli @model ..... olarak başa yazacağım
        }
        public IActionResult Details(int id)
        {

            var p = new Product();
            p.Name = "Samsung";
            p.Price = 3000;
            p.Description = "İyi telefon";

            return View(p);
        }


    }
}