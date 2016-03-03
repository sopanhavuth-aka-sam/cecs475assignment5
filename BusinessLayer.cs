using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {



   //Business layer class, implempents the interface
   public class BusinessLayer : IBusinessLayer {
      private readonly IStandardRepository _standardRepository;
      private readonly IStandardRepository _studentRepository;

      public BusinessLayer () {
         _standardRepository = new StandardRepository();
         _studentRepository = new StudentRepository();
      }

      public void addStandard (Standard ) {
         throw new NotImplementedException();
      }

      public void addStudent (Student ) {
         throw new NotImplementedException();
      }

      public IList<Standard> getAllStandards () {
         throw new NotImplementedException();
      }

      public IList<Student> getAllStudents () {
         throw new NotImplementedException();
      }

      public Standard GetStandardByID (int id) {
         _standardRepository.getById(id);
      }

      public Student GetStudentByID (int id) {
         throw new NotImplementedException();
      }

      public void removeStandard (Standard ) {
         throw new NotImplementedException();
      }

      public void RemoveStudent (Student ) {
         throw new NotImplementedException();
      }

      public void updateStandard (Standard ) {
         throw new NotImplementedException();
      }

      public void UpdateStudent (Student ) {
         throw new NotImplementedException();
      }

      //Implement other methods

   }
}