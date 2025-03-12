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
    public DbSet<Student> Students { get; set;}; // Table Creation

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data source = school.db"); // data base connection
    }
}