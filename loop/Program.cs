﻿
using System;
using System.Collections.Generic;

class Program
{

    public static void Main(string[] args)
    {

        // List<string> list = new List<string>();

        // list.Add("mango");
        // list.Add("papaya");
        // list.Add("lichi");
        // list.Add("apple");
        // Console.WriteLine("enter the fruit name that you want to add in list:");
        // string fruit = Console.ReadLine();
        // list.Add(fruit);

        // list.Sort();
        // list.Reverse();
        // list.Remove("mango");
        // Console.WriteLine(list.Contains("lic"));
        // Console.WriteLine(list.Count);
        // list.Insert(1, "kaju");
        // foreach (string item in list){
        //     Console.WriteLine(item);
        // }


        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // dictionary.Add("A", "apple");
        // dictionary.Add("B", "ball");
        // dictionary.Add("C", "cat");
        

        string check = "yes";

        while (check == "yes"){
            Console.WriteLine("inter the key and with respect to their value:");
            string latter =Console.ReadLine();
            string fruit = Console.ReadLine();
            if (dictionary.ContainsKey(latter)){
                Console.WriteLine("the Key is already exists:");
            }
            else{
                
            dictionary.Add(latter, fruit);
            }

            Console.WriteLine("<-------The Data is Succesfully Added to List------>");


            Console.WriteLine("Are you add some more Data? yes/no:");
            check = Console.ReadLine();

            int num = Convert.ToInt32(Console.ReadLine());
            

        }



        foreach(string key in dictionary.Keys){
            Console.WriteLine($"{key}:{dictionary[key]}");
        }

    }
}