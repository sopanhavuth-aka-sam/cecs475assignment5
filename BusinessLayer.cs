using _475_Lab_4_Part_3;
using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {



   //Business layer class, implempents the interface
   public class BusinessLayer : IBusinessLayer {
      private readonly StandardRepository _standardRepository;
      private readonly StudentRepository _studentRepository;

      public BusinessLayer () {
         _standardRepository = new StandardRepository();
         _studentRepository = new StudentRepository();
      }

      //public BusinessLayer(StandardRepository standardRepo, StudentRepository studentRepo)
      //{
      //   _standardRepository = standardRepo;
      //   _studentRepository = studentRepo;
      //}

      public void addStandard (Standard standard) {
         _standardRepository.Insert(standard);
      }

      public void addStudent (Student student) {
         _studentRepository.Insert(student);
      }

      public IList<Standard> getAllStandards () {
         return _standardRepository.GetAll();
      }

      public IList<Student> getAllStudents () {
         return _studentRepository.GetAll();
      }

      public Standard GetStandardByID (int id) {
         return _standardRepository.GetById(id);
      }

      public Student GetStudentByID (int id) {
         return _studentRepository.GetById(id);
      }

      public void removeStandard (Standard standard) {
         _standardRepository.Delete(standard);
      }

      public void RemoveStudent (Student student) {
         _studentRepository.Delete(student);
      }

      public void updateStandard (Standard standard) {
         _standardRepository.Update(standard);
      }

      public void UpdateStudent (Student student) {
         _studentRepository.Update(student);
      }

   }
}