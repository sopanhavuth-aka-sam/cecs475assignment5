
using _475_Lab_4_Part_3;
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
      void addStandard (Standard s);
      void updateStandard(Standard s);
      void removeStandard (Standard s);

      IList<Student> getAllStudents ();
      Student GetStudentByID (int id);
      void addStudent (Student st);
      void UpdateStudent (Student st);
      void RemoveStudent (Student st);

   }
}