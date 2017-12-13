using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hao_CRUD_APP_2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomersList()
        {
            return View("Customers");
        }
    }
}