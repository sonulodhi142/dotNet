using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

// (Represents Database Table)
public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}