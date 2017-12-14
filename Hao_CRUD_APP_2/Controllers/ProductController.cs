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

        [HttpPost]
        public ActionResult AddProduct(Product addProduct)
        {
            int result = new ProductService().AddProduct(addProduct);

            if(result > 0)
            {

                return Content("success");
            }
            else
            {
                return Content("error");
            }
        }

        public ActionResult DeleteProduct(int productId)
        {
            int result = new ProductService().DeleteProduct(productId);

            if (result > 0)
            {
                return Content("deleteProduct");
            }
            else
            {
                return Content("delError");
            }
        }

        public ActionResult LoadingModifyProduct(int productId)
        {
            Product product = new ProductService().GetProductById(productId);

            return View("ModifyProduct", product);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ModifyProduct(Product product)
        {
            int result = new ProductService().ModidyProduct(product);

            if (result > 0)
            {
                return Content("success");
            }
            else
            {
                return Content("error");
            }
        }
    }
}