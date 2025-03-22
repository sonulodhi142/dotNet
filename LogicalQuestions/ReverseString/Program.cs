using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        Console.Write("Enter any string::");
        string str = Console.ReadLine();

        

        for(int i = str.Length-1; i >= 0 ; i--){
            Console.Write(str[i]);
        }
    }
}