using System;
using System.IO;

class Program{
    static void Main(string[] args){

        string file = "file.txt";

        File.AppendAllText(file,"\nthis the new file with the name of file.txt");
        
        string content = File.ReadAllText(file);
        Console.WriteLine(content);

        Console.WriteLine(file);
    }
}