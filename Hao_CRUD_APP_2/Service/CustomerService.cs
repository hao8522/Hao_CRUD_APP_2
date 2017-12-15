using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Hao_CRUD_APP_2.Models;

namespace Hao_CRUD_APP_2.Service
{
    public class CustomerService
    {

        public int AddCustomer(Customer customer)
        {
            using (HAO_Entities db = new HAO_Entities())
            {
                db.Customers.Add(customer);

                return db.SaveChanges();
            }
        }
        public int ModifyCustomer(Customer customer)
        {
            using (HAO_Entities db = new HAO_Entities())
            {
                db.Customers.Attach(customer);
                db.Entry<Customer>(customer).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }

        public int DeleteCustomer(int customerId)
        {
            using (HAO_Entities db = new HAO_Entities())
            {
                Customer c = new Customer()
                {
                    Id = customerId
                };

                db.Customers.Attach(c);
                db.Customers.Remove(c);
                return db.SaveChanges();
            }
        }

        public List<Customer> GetAllCustomer()
        {
            using(HAO_Entities db = new HAO_Entities())
            {
                return (from c in db.Customers select c).ToList();
            }
           
        }

        public Customer GetCustomerById(int productId)
        {
            using(HAO_Entities db = new HAO_Entities())
            {
                return ( from c in db.Customers where c.Id == productId select c ).FirstOrDefault();
            }
        }
    }
}
