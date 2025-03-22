using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){

        List<Dictionary<string, object>> students = new List<Dictionary<string, object>>();

        Dictionary<string,object> student = new Dictionary<string, object>();

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