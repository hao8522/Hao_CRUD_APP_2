using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.Entity;
namespace DAL
{
    public class ProductService
    {

        public int AddProduct(Product product)
        {
            using (HAOEntities db = new HAOEntities())
            {
                db.Products.Add(product);
                return db.SaveChanges();
            }
        }

        public int ModidyProduct(Product product)
        {
            using (HAOEntities db = new HAOEntities())
            {
                db.Products.Attach(product);
                db.Entry<Product>(product).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }

        public int DeleteProduct(int productId)
        {
            using (HAOEntities db = new HAOEntities())
            {
                Product p = new Product()
                {
                    Id = productId
                };

                db.Products.Attach(p);
                db.Products.Remove(p);

                return db.SaveChanges();
            }
        }

        public List<Product> GetAllProduct()
        {
            using (HAOEntities db = new HAOEntities())
            {

                return (from p in db.Products select p).ToList();
            }
        }

        public Product GetProductById(int productId)
        {
            using (HAOEntities db = new HAOEntities())
            {
                return (from p in db.Products where p.Id == productId select p).FirstOrDefault();
            }
        }
    }
}
