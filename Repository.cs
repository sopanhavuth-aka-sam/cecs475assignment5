using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer {
   public class Repository<T> : IRepository<T> where T : class {

      protected DbContext context;
      protected DbSet<T> dbSet;

      public Repository (DbContext datacontext) { //T will be the table name of the set we are connecting too
         dbSet = datacontext.Set<T>();
      }

      public void Insert (T entity) { 
         
      }

      public void Delete (T entity) {

      }

      public void Update (T entity) {

      }
      public T GetById (int id) {

         return null;
      }

      public IQueryable<T> SearchFor (Expression<Func<T, bool>> predicate) {//annonyous method Lamda expression =>
         //SearchFor(s => s.StandardID ==);
         return context.Where(predicate);
      }

      public IEnumerable<T> GetAll () {

      }


      public void Dispose () {
         throw new NotImplementedException();
      }
   }

}