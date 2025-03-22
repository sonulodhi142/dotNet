using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){

        List<Dictionary<string, object>> students = new List<Dictionary<string, object>>();

        Dictionary<string,object> student = new Dictionary<string, object>();

        while(true){
            Console.Write("enter the choice :: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice){
                case 1:
                    viewStudents();
                    break;
                case 2:
                    viewStudents();
                    break;
                case 3:
                    viewStudents();
                    break;
                case 4:
                    viewStudents();
                    break;
                case 5:
                    return;
                
            }
        }

        

        void viewStudents(){
            student["id"] = 1;
        student["name"] = "sonu";
        student["grade"] = "A";

        students.Add(student);
            Console.WriteLine(students.Count);
            foreach(var stud in students){
                Console.WriteLine((int)stud["id"]==1);
            }
        }
    }
}