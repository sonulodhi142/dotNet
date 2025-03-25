using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        List<int> list = new List<int>();
        list.Add(1);

        bool isPrime(int x){
            for(int i=2; i<x; i++){
                if(x%i==0){
                    return false;
                }
            }
            return true;
        }
        Console.Write("Enter the number::");
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i=2; i<num; i++){
            if(isPrime(i)){
                list.Add(i);
            }
        }
        Console.WriteLine($"\n\nThe Count of Prime num is upto {num}::{list.Count}\n\n");

        foreach(int i in list){
            Console.Write(i+", ");
        }


    }
}