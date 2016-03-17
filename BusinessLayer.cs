using _475_Lab_4_Part_3;
using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {

   //Business layer class, implempents IBusinessLayer the interface
   public class BusinessLayer : IBusinessLayer {
      private readonly StandardRepository _standardRepository;
      private readonly StudentRepository _studentRepository;

      //Constructor
      public BusinessLayer () {
         _standardRepository = new StandardRepository();
         _studentRepository = new StudentRepository();
      }

      //add standard to db
      public void addStandard (Standard standard) {
         _standardRepository.Insert(standard);
      }


      //add student to db
      public void addStudent (Student student) {
         _studentRepository.Insert(student);
      }

      //return a list of all standards
      public IList<Standard> getAllStandards () {
         return _standardRepository.GetAll();
      }

      //return a list of all students
      public IList<Student> getAllStudents () {
         return _studentRepository.GetAll();
      }

      //return a standard base on id
      public Standard GetStandardByID (int id) {
         return _standardRepository.GetById(id);
      }

      //return a student base on id
      public Student GetStudentByID (int id) {
         return _studentRepository.GetById(id);
      }

      //remove standard from db
      public void removeStandard (Standard standard) {
         _standardRepository.Delete(standard);
      }

      //remove student from db
      public void RemoveStudent (Student student) {
         _studentRepository.Delete(student);
      }

      //update standard in db
      public void updateStandard (Standard standard) {
         _standardRepository.Update(standard);
      }

      //update student in db
      public void UpdateStudent (Student student) {
         _studentRepository.Update(student);
      }

      //get student base on String(name)
      public Student GetStudentByName(String name)
      {
         return _studentRepository.GetSingle(d => d.StudentName.Equals(name));
      }

      //get stadard base on String(name)
      public Standard GetStandardByName(String name)
      {
         return _standardRepository.GetSingle(d => d.StandardName.Equals(name));
      }
   }
}