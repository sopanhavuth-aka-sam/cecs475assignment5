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
   }
}