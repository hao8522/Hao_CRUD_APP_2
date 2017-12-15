using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hao_CRUD_APP_2.Models;
using Hao_CRUD_APP_2.Service;

namespace Hao_CRUD_APP_2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomersList()
        {

            List<Customer> customerList = new CustomerService().GetAllCustomer();

            ViewBag.list = customerList;

            return View("Customers");
        }


        public ActionResult LoadingModifyCustomer(int productId)
        {
            Customer customer = new CustomerService().GetCustomerById(productId);

            return View("ModifyCustomer", customer);
        }

        [HttpPost]
        public ActionResult ModifyCustomer(Customer customer)
        {
            int result = new CustomerService().ModifyCustomer(customer);

            if (result > 0)
            {
                return Content("success");
            }
            else
            {
                return Content("error");
            }
        }

        public ActionResult DeleteCustomer(int customerId)
        {
            int result = new CustomerService().DeleteCustomer(customerId);

            if (result > 0)
            {
                return Content("success");
            }
            else
            {
                return Content("error");
            }
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            int result = new CustomerService().AddCustomer(customer);

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