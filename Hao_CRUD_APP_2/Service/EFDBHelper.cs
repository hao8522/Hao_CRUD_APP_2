using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace Hao_CRUD_APP_2.Service
{
   public  class EFDBHelper
    {
        private DbContext dbContext = null;

        public EFDBHelper(DbContext context)
        {
            this.dbContext = context;
        }


        public int Add<T>(T entity) where T : class
        {

            dbContext.Entry<T>(entity).State = EntityState.Added;

            return dbContext.SaveChanges();

        }


        public int Modify<T>(T entity) where T : class
        {
            dbContext.Entry<T>(entity).State = EntityState.Modified;
            return dbContext.SaveChanges();
        }


        public int Delete<T>(T entity) where T : class
        {
            dbContext.Entry<T>(entity).State = EntityState.Deleted;
            return dbContext.SaveChanges();
        }
    }
}
