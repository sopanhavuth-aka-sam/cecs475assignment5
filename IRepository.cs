﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer {
   public interface IRepository<T> : IDisposable {
      void Insert (T entity);

      void Delete (T entity);

      void Update (T entity);

      T GetById (int id);

      //Should I change IQueryable and IEnumerable to IList??
      //IList make the system do LINQ inside of the repo object
      IQueryable<T> SearchFor (Expression<Func<T, bool>> predicate);

      IList<T> GetAll (params Expression<Func<T, object>>[] navigationPropertie);

      //new code added by Prof
      //What does it do?
      T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

   }
}