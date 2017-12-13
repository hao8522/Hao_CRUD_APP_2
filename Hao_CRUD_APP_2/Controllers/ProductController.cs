using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hao_CRUD_APP_2.Models;
using Hao_CRUD_APP_2.Service;


namespace Hao_CRUD_APP_2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProductList()
        {
            List<Product> productList = new ProductService().GetAllProduct();

            ViewBag.list = productList;

            return View("Products");
        }
    }
}