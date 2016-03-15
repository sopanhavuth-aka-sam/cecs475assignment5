using _475_Lab_4_Part_3;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
   public class StudentRepository : Repository<Student>, IStudentRepository
   {
      //Constructor
      public StudentRepository() : base(new SchoolDBEntities())
      {
      }

      //public void Delete(Student entity)
      //{
      //   base.Delete(entity);
      //}

      //public void Insert(Student entity)
      //{
      //   throw new NotImplementedException();
      //}

      //public IQueryable<Student> SearchFor(System.Linq.Expressions.Expression<Func<Student, bool>> predicate)
      //{
      //   throw new NotImplementedException();
      //}

      //public void Update(Student entity)
      //{
      //   throw new NotImplementedException();
      //}

      //IEnumerable<Student> IRepository<Student>.GetAll()
      //{
      //   throw new NotImplementedException();
      //}

      //Student IRepository<Student>.GetById(int id)
      //{
      //   throw new NotImplementedException();
      //}
   }
}