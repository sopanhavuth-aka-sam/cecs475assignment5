using _475_Lab_4_Part_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    class Program
    {
      public static IBusinessLayer businessLayer = new BusinessLayer();

      static void Main(string[] args)
      {


         //Test: standard get all
         printAllStandard();

         //Test: student get all
         printAllStudent();

         //Test: add standard
         Student tempStudent = new Student()
         {
            StudentID = 2,
            StudentName = "John",
            StandardId = 3
         };
         businessLayer.addStudent(tempStudent);

         printAllStudent();

         //Test Delete
         //businessLayer.RemoveStudent(tempStudent);

         //printAllStudent();

         Student newStudent = businessLayer.GetStudentByName("John");

         Console.WriteLine("newStudent Search: " + newStudent.StudentName + newStudent.StudentID);

      }

      //print all standards
      public static void printAllStandard()
      {
         //Test: standard get all
         IList<Standard> allStandard = businessLayer.getAllStandards();
         foreach (Standard standard in allStandard)
         {
            Console.WriteLine(string.Format("{0} - {1}", standard.StandardId, standard.StandardName));
         }
         Console.WriteLine();
      }

      //print all students
      public static void printAllStudent()
      {
         IList<Student> allStudent = businessLayer.getAllStudents();
         foreach (Student student in allStudent)
         {
            Console.WriteLine(string.Format("{0} - {1}", student.StudentName, student.StudentID));
         }
         Console.WriteLine();
      }
    }
}


