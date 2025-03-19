using System;
using System.IO;
class Program{
    static void Main(string[] args){
        string path = "example.txt";
        using (StreamWriter fs = new StreamWriter(path)){
            fs.Write("\nthis is the text of that i wrote in this file");
        }
    }
}