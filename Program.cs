using _475_Lab_4_Part_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
   class Program {
      static void Main (string[] args) {
         //Initailize business layer for the program
         IBusinessLayer businessLayer = new BusinessLayer();

         bool menu = true;
         
         while (menu) {
            System.Console.WriteLine("1 Create Standard ");
            System.Console.WriteLine("2 Update Standard by ID");
            System.Console.WriteLine("3 Update Standard by Name ");
            System.Console.WriteLine("4 Delete Standard ");
            System.Console.WriteLine("5 Display All Standards");
            System.Console.WriteLine("6 Create Student ");
            System.Console.WriteLine("7 Update Student by ID");
            System.Console.WriteLine("8 Update Student by Name");
            System.Console.WriteLine("9 Delete Student");
            System.Console.WriteLine("10 Display All Studnents ");
            System.Console.WriteLine("11 Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            
            switch (input) {
               case 1:

                  Console.WriteLine("Enter the standard name: ");
                  string standName = Console.ReadLine();
                  Console.WriteLine("Enter the standard ID: ");
                  int standID = Convert.ToInt32(Console.ReadLine());
                  Standard nStandard = new Standard();
                  nStandard.StandardName = standName;
                  nStandard.StandardId = standID;
                  businessLayer.addStandard(nStandard);
                  break;
               case 2:
                  //Update Standard by ID

                  Console.WriteLine("Which Name would you like to update?");
                  int standUpdateID = Convert.ToInt32(Console.ReadLine());
                  Standard updateStandardbyID = businessLayer.GetStandardByID(standUpdateID);
                  Console.WriteLine("Enter updated ID");
                  int updatedStandardID = Convert.ToInt32(Console.ReadLine());
                  updateStandardbyID.StandardId = updatedStandardID;
                  businessLayer.updateStandard(updateStandardbyID);

                  break;
               case 3:
                  //Update Standard by Name
                  Console.WriteLine("Which Name would you like to update?");

                  businessLayer.updateStandard();

                  break;
               case 4:
                  //Delete standard
                  Console.WriteLine("Enter Standard ID to delete");
                  int removeStandID = Convert.ToInt32(Console.ReadLine());               
                  businessLayer.removeStandard(businessLayer.GetStandardByID(removeStandID));

                  break;
               case 5:
                  IList<Standard> allStandard = businessLayer.getAllStandards();
                  foreach (Standard standard in allStandard) {
                     Console.WriteLine(string.Format("{0} - {1}", standard.StandardId, standard.StandardName));
                  }
                  Console.Write("\n");
                  break;
               case 6:
                  Console.WriteLine("Enter the student name: ");
                  string sName = Console.ReadLine();
                  Console.WriteLine("Enter the student ID: ");
                  int sID = Convert.ToInt32(Console.ReadLine());
                  Student nStudent = new Student();
                  nStudent.StudentName = sName;
                  nStudent.StandardId = sID;
                  businessLayer.addStudent(nStudent);
                  break;
               case 7:
                  //Update by Student ID
                  Console.WriteLine("Which ID would you like to update?");
                  int studUpdateID = Convert.ToInt32(Console.ReadLine());
                  Student updateStudentbyID = businessLayer.GetStudentByID(studUpdateID); //temp student object
                  Console.WriteLine("Enter updated ID");
                  int updatedStudID = Convert.ToInt32(Console.ReadLine());
                  updateStudentbyID.StandardId = updatedStudID; // Updates the temp student objecct
                  businessLayer.UpdateStudent(updateStudentbyID);

                  break;
               case 8:
                  //update by Student Name


                  break;
               case 9:
                  IList<Student> allStudentIDs = businessLayer.getAllStudents();
                  foreach (Student students in allStudentIDs) {
                     Console.WriteLine(string.Format("{0} - {1} - {2}", students.StudentID, students.StudentName));
                  }

                  Console.WriteLine("Enter Student ID to delete");
                  int removeStudID = Convert.ToInt32(Console.ReadLine());
                  businessLayer.removeStandard(businessLayer.GetStandardByID(removeStudID));

                  break;
               case 10:
                  IList<Student> allStudent = businessLayer.getAllStudents();
                  foreach (Student students in allStudent) {
                     Console.WriteLine(string.Format("{0} - {1} - {2}", students.StudentID, students.StudentName, students.StandardId));
                  }
                  Console.Write("\n");
                  break;
               case 11:
                  menu = false;
                  break;
            }
         }
      }
   }
}


