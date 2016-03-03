using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {

   public interface IBusinessLayer {

      IList<Standard> getAllStandards ();
      Standard GetStandardByID (int id);
      void addStandard (Standard);
      void updateStandard (Standard)
      void removeStandard (Standard);

      IList<Student> getAllStudents ();
      Student GetStudentByID (int id);
      void addStudent (Student);
      void UpdateStudent (Student);
      void RemoveStudent (Student);

   }
}