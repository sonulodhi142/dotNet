﻿using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);
        // list.Clear();
        list.Reverse();

        Console.WriteLine("enter the num:");
        int num = Convert.ToInt32(Console.ReadLine("please enter the num:"));

        list.Add(num);

        foreach(int i in list){
            Console.WriteLine(i);
        }
    }
}