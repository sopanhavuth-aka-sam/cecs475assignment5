<<<<<<< HEAD
using _475_Lab_4_Part_3;
=======
﻿using _475_Lab_4_Part_3;
>>>>>>> samcopy
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace BusinessLayer {
   class Program {
      static void Main (string[] args) {
         //Initailize business layer for the program
         IBusinessLayer businessLayer = new BusinessLayer();
         bool menu = true;
         while (menu) {
=======
namespace BusinessLayer
{
   class Program
   {
      static void Main(string[] args)
      {
         //Initailize business layer for the program
         IBusinessLayer businessLayer = new BusinessLayer();
         bool menu = true;
         while (menu)
         {
>>>>>>> samcopy
            System.Console.WriteLine("1 Create Standard ");
            System.Console.WriteLine("2 Update Standard by ID");
            System.Console.WriteLine("3 Update Standard by Name ");
            System.Console.WriteLine("4 Delete Standard ");
            System.Console.WriteLine("5 Display students with same Standard ID ");
            System.Console.WriteLine("6 Display All Standards");
            System.Console.WriteLine("7 Create Student ");
            System.Console.WriteLine("8 Update Student by ID");
            System.Console.WriteLine("9 Update Student by Name");
            System.Console.WriteLine("10 Delete Student");
            System.Console.WriteLine("11 Display All Studnents ");
            System.Console.WriteLine("12 Exit");
            int input = Convert.ToInt32(Console.ReadLine());
<<<<<<< HEAD
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

                  Console.WriteLine("Which ID would you like to update?");
                  int standUpdateID = Convert.ToInt32(Console.ReadLine());
                  Standard updateStandardbyID = businessLayer.GetStandardByID(standUpdateID);
                  Console.WriteLine("Enter new Standard Name");
                  updateStandardbyID.StandardName = Console.ReadLine();



                  //Work around, hard coded update(Remove and then add in the new object with modified object)
                  //businessLayer.removeStandard(businessLayer.GetStandardByID(standUpdateID));
                  //businessLayer.addStandard(updateStandardbyID);
                  businessLayer.updateStandard(updateStandardbyID); // Not working for some reason

                  break;
               case 3:
                  //Update Standard by Name
                  Console.WriteLine("Which Name would you like to update?");
                  string updateStandardname = Console.ReadLine();
                  Standard updateStandardbyName = businessLayer.GetStandardByName(updateStandardname);
                  Console.WriteLine("Enter new Standard Name");
                  updateStandardbyName.StandardName = Console.ReadLine();

                  //businessLayer.removeStandard(businessLayer.GetStandardByName(updateStandardname));
                  //businessLayer.addStandard(updateStandardbyName);
                  businessLayer.updateStandard(updateStandardbyName); // Not updating 

                  break;
               case 4:
                  //Delete standard
                  Console.WriteLine("Enter Standard ID to delete");
                  int removeStandID = Convert.ToInt32(Console.ReadLine());
                  businessLayer.removeStandard(businessLayer.GetStandardByID(removeStandID));

                  break;
               case 5:
                  // Input the standard id and then display all students that has that standard id.
                  System.Console.WriteLine("Please enter a Standard ID ");
                  int standStudID = Convert.ToInt32(Console.ReadLine());

                  IList<Student> allStudentStandID = businessLayer.getAllStudents();
                  foreach (Student students in allStudentStandID) {
                     if (students.StandardId == standStudID) {
                        Console.WriteLine(string.Format("{0} - {1} - {2}", students.StudentID, students.StudentName, students.StandardId));
                     }
                     
=======
            switch (input)
            {
               case 1:

                  Console.WriteLine("Enter the standard name: ");
                  string standName = Console.ReadLine();
                  Standard nStandard = new Standard();
                  nStandard.StandardName = standName;
                  businessLayer.addStandard(nStandard);
                  break;
               case 2:
                  //Update Standard by ID

                  Console.WriteLine("Which ID would you like to update?");
                  int standUpdateID = Convert.ToInt32(Console.ReadLine());
                  Standard updateStandardbyID = businessLayer.GetStandardByID(standUpdateID);
                  Console.WriteLine("Enter new Standard Name");
                  updateStandardbyID.StandardName = Console.ReadLine();



                  //Work around, hard coded update(Remove and then add in the new object with modified object)
                  //businessLayer.removeStandard(businessLayer.GetStandardByID(standUpdateID));
                  //businessLayer.addStandard(updateStandardbyID);
                  businessLayer.updateStandard(updateStandardbyID); // Not working for some reason

                  break;
               case 3:
                  //Update Standard by Name
                  Console.WriteLine("Which Name would you like to update?");
                  string updateStandardname = Console.ReadLine();
                  Standard updateStandardbyName = businessLayer.GetStandardByName(updateStandardname);
                  Console.WriteLine("Enter new Standard Name");
                  updateStandardbyName.StandardName = Console.ReadLine();

                  //businessLayer.removeStandard(businessLayer.GetStandardByName(updateStandardname));
                  //businessLayer.addStandard(updateStandardbyName);
                  businessLayer.updateStandard(updateStandardbyName); // Not updating 

                  break;
               case 4:
                  //Delete standard
                  Console.WriteLine("Enter Standard ID to delete");
                  int removeStandID = Convert.ToInt32(Console.ReadLine());
                  businessLayer.removeStandard(businessLayer.GetStandardByID(removeStandID));

                  break;
               case 5:
                  // Input the standard id and then display all students that has that standard id.
                  System.Console.WriteLine("Please enter a Standard ID ");
                  int standStudID = Convert.ToInt32(Console.ReadLine());

                  IList<Student> allStudentStandID = businessLayer.getAllStudents();
                  foreach (Student students in allStudentStandID)
                  {
                     if (students.StandardId == standStudID)
                     {
                        Console.WriteLine(string.Format("{0} - {1} - {2}", students.StudentID, students.StudentName, students.StandardId));
                     }

>>>>>>> samcopy
                  }
                  break;
               case 6:
                  IList<Standard> allStandard = businessLayer.getAllStandards();
<<<<<<< HEAD
                  foreach (Standard standard in allStandard) {
=======
                  foreach (Standard standard in allStandard)
                  {
>>>>>>> samcopy
                     Console.WriteLine(string.Format("{0} - {1}", standard.StandardId, standard.StandardName));
                  }
                  Console.Write("\n");
                  break;
               case 7:
                  Console.WriteLine("Enter the student name: ");
                  string sName = Console.ReadLine();
<<<<<<< HEAD
                  Console.WriteLine("Enter the student ID: ");
                  int sID = Convert.ToInt32(Console.ReadLine());
                  Student nStudent = new Student();
                  nStudent.StudentName = sName;
                  nStudent.StandardId = sID;
=======
                  Console.WriteLine("Enter the standard ID that student belong to: ");
                  int StandardID = Convert.ToInt32(Console.ReadLine());
                  Student nStudent = new Student();
                  nStudent.StudentName = sName;
                  nStudent.StandardId = StandardID;
>>>>>>> samcopy

                  businessLayer.addStudent(nStudent);
                  break;
               case 8:
                  //Update by Student ID
                  Console.WriteLine("Which ID would you like to update?");
                  int studUpdateID = Convert.ToInt32(Console.ReadLine());
                  Student updateStudentbyID = businessLayer.GetStudentByID(studUpdateID); //temp student object
                  Console.WriteLine("Enter new Student Name");
                  updateStudentbyID.StudentName = Console.ReadLine();

                  businessLayer.UpdateStudent(updateStudentbyID);

                  break;
               case 9:
                  //update by Student Name
                  Console.WriteLine("Which Name would you like to update?");
                  Student updateStudentbyName = businessLayer.GetStudentByName(Console.ReadLine());
                  Console.WriteLine("Enter new Student Name");
                  updateStudentbyName.StudentName = Console.ReadLine();

                  businessLayer.UpdateStudent(updateStudentbyName);

                  break;
               case 10:
                  IList<Student> allStudentIDs = businessLayer.getAllStudents();
<<<<<<< HEAD
                  foreach (Student students in allStudentIDs) {
=======
                  foreach (Student students in allStudentIDs)
                  {
>>>>>>> samcopy
                     Console.WriteLine(string.Format("{0} - {1} - {2}", students.StudentID, students.StudentName));
                  }

                  Console.WriteLine("Enter Student ID to delete");
                  int removeStudID = Convert.ToInt32(Console.ReadLine());
                  businessLayer.removeStandard(businessLayer.GetStandardByID(removeStudID));

                  break;
               case 11:
                  IList<Student> allStudent = businessLayer.getAllStudents();
<<<<<<< HEAD
                  foreach (Student students in allStudent) {
=======
                  foreach (Student students in allStudent)
                  {
>>>>>>> samcopy
                     Console.WriteLine(string.Format("{0} - {1} - {2}", students.StudentID, students.StudentName, students.StandardId));
                  }
                  Console.Write("\n");
                  break;
               case 12:
                  menu = false;
                  break;
            }
         }
      }
   }
<<<<<<< HEAD
}
=======
}
>>>>>>> samcopy
