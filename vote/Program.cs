using System;

class Program{
    static void Main(string[] args){

        // try{
        //     Console.Write("Please Enter your age: ");
        //     int age = Convert.ToInt32(Console.ReadLine());
        //     if(age >= 18){
        //         Console.WriteLine("\n\nYou are eligible to vote:\n");
        //     }
        //     else{
        //         Console.WriteLine("\n\nOops! You are not eligible to vote:\n");
        //     }

        //     int[] array = { 1, 2, 3,};
        //     Console.WriteLine(array[age]);
        // }
        // catch(IndexOutOfRangeException ex){
        //     Console.WriteLine("Error: Array index is out of range.");
        // }
        // catch(Exception ex){
        //     Console.WriteLine(ex.ToString());
        // }

        Console.Write("Enter Your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18){
            throw new Exception("you are not eligible for vote");
        }
        else{
            Console.WriteLine("you are eligible for vote");
        }


    }
}