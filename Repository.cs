using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using _475_Lab_4_Part_3;

namespace DataAccessLayer {
   public class Repository<T> : IRepository<T> where T : class {

      protected DbContext context;
      protected DbSet<T> dbSet;

<<<<<<< HEAD
=======
      //constructor
>>>>>>> samcopy
      public Repository (DbContext datacontext) {
         context = datacontext;
         dbSet = datacontext.Set<T>();
      }

<<<<<<< HEAD
=======
      //insert new entity into the db
>>>>>>> samcopy
      public void Insert (T entity) {
         context.Entry(entity).State = System.Data.Entity.EntityState.Added;
         context.SaveChanges();
      }

      //delete entity from the db
      public void Delete (T entity) {
         context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
         context.SaveChanges();
      }

      //find and update information of the entity
      public void Update (T entity) {
         context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
         context.SaveChanges();
      }
<<<<<<< HEAD
=======

      //find and entity by id
>>>>>>> samcopy
      public T GetById (int id) {
         return dbSet.Find(id);
      }

      public IQueryable<T> SearchFor (Expression<Func<T, bool>> predicate) {//annonyous method Lamda expression =>
         //SearchFor(s => s.StandardID ==);
         return context.Set<T>().Where(predicate);
      }

<<<<<<< HEAD
      //add body code from example
      public IList<T> GetAll (params Expression<Func<T, object>>[] navigationProperties) { //add param from example code

         //context.Database.Connection.Open();
         List<T> list;
         //using (var context = new SchoolDBEntities())
         //{
            IQueryable<T> dbQuery = context.Set<T>();

            //Apply eager loading
            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
               dbQuery = dbQuery.Include<T, object>(navigationProperty);
=======
      //Get all entity from a db
      public IList<T> GetAll (params Expression<Func<T, object>>[] navigationProperties) { //add param from example code

         List<T> list;
         IQueryable<T> dbQuery = context.Set<T>();

         //Apply eager loading
         foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
            dbQuery = dbQuery.Include<T, object>(navigationProperty);

         list = dbQuery
               .AsNoTracking()
               .ToList<T>();

         return list;
      }
>>>>>>> samcopy

            list = dbQuery
                  .AsNoTracking()
                  .ToList<T>();
         //}
         return list;
      }

      public void Dispose () {
<<<<<<< HEAD
         //how to implement this??
      }

      //add body code from example
=======
         //Empty
      }

      //Get a single entity
>>>>>>> samcopy
      public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
      {
         T item = null;

         IQueryable<T> dbQuery = context.Set<T>();

         //Apply eager loading
         foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
            dbQuery = dbQuery.Include<T, object>(navigationProperty);

         item = dbQuery
               .AsNoTracking() //Don't track any changes for the selected item
               .FirstOrDefault(where); //Apply where clause

         return item;
      }
   }

}