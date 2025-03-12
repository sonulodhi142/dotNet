using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

// (Represents Database Table)
public class Student{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

// Bridge betwenn db and code
public class SchoolContext : DbContext{
    public DbSet<Student> Students { get; set; } // Table Creation

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data source = school.db"); // data base connection
    }
}

// Main Program for CRUD Operations
class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            // Auto-create database if not exists
            context.Database.EnsureCreated();

            // ✅ CREATE Operation
            var student1 = new Student { Name = "John", Age = 20 };
            var student2 = new Student { Name = "Emma", Age = 22 };
            context.Students.AddRange(student1, student2);
            context.SaveChanges();
            Console.WriteLine("✔ Students added successfully.\n");

            // ✅ READ Operation
            Console.WriteLine("📋 Student List:");
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
            }

            // ✅ UPDATE Operation
            var updateStudent = context.Students.FirstOrDefault(s => s.Name == "John");
            if (updateStudent != null)
            {
                updateStudent.Age = 21;
                context.SaveChanges();
                Console.WriteLine("\n✔ Student updated successfully.");
            }

            // ✅ DELETE Operation
            var deleteStudent = context.Students.FirstOrDefault(s => s.Name == "Emma");
            if (deleteStudent != null)
            {
                context.Students.Remove(deleteStudent);
                context.SaveChanges();
                Console.WriteLine("\n✔ Student deleted successfully.");
            }

            // Final List After Update and Delete
            Console.WriteLine("\n📋 Final Student List:");
            foreach (var student in context.Students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}