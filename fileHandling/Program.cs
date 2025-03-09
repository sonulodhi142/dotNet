using System;
using System.IO;

class Program{
    static void Main(string[] args){

        string file = "file.txt";

        File.WriteAllText(file,"\nthis the new file with the name of file.txt");
        

        Console.WriteLine(file);
    }
}