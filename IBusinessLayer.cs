
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
<<<<<<< HEAD
      void addStandard (Standard s);
      void updateStandard(Standard s);
      void removeStandard (Standard s);
=======
      Standard GetStandardByName(String name);
      void addStandard (Standard s);
      void updateStandard(Standard s);
      void removeStandard (Standard s);

>>>>>>> samcopy

      IList<Student> getAllStudents ();
      Student GetStudentByName(String name);
      Student GetStudentByID (int id);
      void addStudent (Student st);
      void UpdateStudent (Student st);
      void RemoveStudent (Student st);

   }
}