using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Dictionary<string, object>> students = new List<Dictionary<string, object>>();
        int studentId = 1;

        while (true)
        {
            Console.WriteLine("\n\nEnter 1 to view all students:");
            Console.WriteLine("Enter 2 to add student :");
            Console.WriteLine("Enter 4 to delete student :");
            Console.WriteLine("Enter 5 to exit:: ");
            Console.Write("enter the choice :: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    viewStudents();
                    break;
                case 2:
                    addStudents();
                    break;
                case 3:
                    updateStudent();
                    break;
                case 4:
                    deleteStudent();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("\n\nPlease Eenter a vailed choice:-");
            }
        }



        void viewStudents()
        {
            int id = 1;
            Console.WriteLine("The number of Total student is :" + students.Count);
            foreach (var stud in students)
            {
                Console.WriteLine("\n\nId    :: " + stud["id"]);
                Console.WriteLine("Name  :: " + stud["name"]);
                Console.WriteLine("Grade :: " + stud["grade"]);
                Console.WriteLine((int)stud["id"] == id);
            }
        }

        void addStudents()
        {

            Dictionary<string, object> student = new Dictionary<string, object>();
            Console.WriteLine("Enter the Student basic Details");
            student["id"] = studentId++;
            Console.Write("Name:: ");
            student["name"] = Console.ReadLine();
            Console.Write("Grade:: ");
            student["grade"] = Console.ReadLine();

            students.Add(student);
            Console.WriteLine("The student is Succesfully added to the list:-");
        }

        void deleteStudent()
        {
            Console.Write("Enter the Id of Student::");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= students.Count - 1; i++) {
                if ((int)students[i]["id"] == id){
                    students.RemoveAt(i);
                    Console.WriteLine("Student deleted successfully.\n");
                    return;
                }
            }

            Console.WriteLine("Student not found.");
        }

        void updateStudent()
        {
            Console.Write("Enter the Id of Student::");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= students.Count - 1; i++) {
                if ((int)students[i]["id"] == id){
                    Console.WriteLine("Update the Student's Details::");
                    Console.Write("Name:: ");
                    students[i]["name"] = Console.ReadLine();
                    Console.Write("Grade:: ");
                    students[i]["grade"] = Console.ReadLine();
                    Console.WriteLine("The student data is Succesfully updated in the list:-\n\n");
                    return;
                }
            }

            Console.WriteLine("Student not found.");
        }

    }
}