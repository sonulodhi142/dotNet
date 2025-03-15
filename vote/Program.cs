using System;

class Program{
    static void Main(string[] args){

        try{
            Console.Write("Please Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age >= 18){
                Console.WriteLine("You are eligible to vote:");
            }
            else{
                Console.WriteLine("\n\nOops! You are not eligible to vote:");
            }
        }
        catch(Exception ex){
            Console.WriteLine(ex.ToString());
        }
    }
}