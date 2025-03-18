using System;

class Program
{
    static void Main(string[] args)
    {

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

        // Console.Write("Enter Your age: ");
        // int age = Convert.ToInt32(Console.ReadLine());

        // if (age < 18){
        //     throw new Exception("you are not eligible for vote");
        // }
        // else{
        //     Console.WriteLine("you are eligible for vote");
        // }

        // try{
        //     Console.Write("enter the num1: ");
        // int num1 = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Enter the num2: ");
        // int num2 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine($"\n\nnum1 is {num1} and num2 is {num2}");
        // }
        // catch(Exception ex){
        //     Console.WriteLine("\n\nError is :"+ex.Message);
        // }
        // finally{

        //     Console.WriteLine("\n\nthe code is end:");
        // }

        try
        {
            Console.Write("enter the num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore Swaping the value:- \n");
            Console.WriteLine($"num1 = {num1} \n num2 = {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\n After Swaping the value:- \n");
            Console.WriteLine($"num1 = {num1} \n num2 = {num2}");
        }
        catch (Exception ex){
            Console.WriteLine("Error:"+ex.Message);
        }
        finally{
            Console.WriteLine("code end::-");
        }




    }
}