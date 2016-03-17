using _475_Lab_4_Part_3;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer {
   public class StandardRepository : Repository<Standard>, IStandardRepository {
      //constructor
      public StandardRepository () : base(new SchoolDBEntities()) {

      }

      //public void Delete (Standard entity) {
      //   throw new NotImplementedException();
      //}

      //public void Insert (Standard entity) {
      //   throw new NotImplementedException();
      //}

      //public IQueryable<Standard> SearchFor (System.Linq.Expressions.Expression<Func<Standard, bool>> predicate) {
      //   throw new NotImplementedException();
      //}

      //public void Update (Standard entity) {
      //   throw new NotImplementedException();
      //}

      //IEnumerable<Standard> IRepository<Standard>.GetAll () {
      //   throw new NotImplementedException();
      //}

      //Standard IRepository<Standard>.GetById (int id) {
      //   throw new NotImplementedException();
      //}
   }

}