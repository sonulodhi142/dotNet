using System;

class Program{
    static void Main(string[] args){

        try{
            Console.Write("Please Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age >= 18){
                Console.WriteLine("\n\nYou are eligible to vote:\n");
            }
            else{
                Console.WriteLine("\n\nOops! You are not eligible to vote:\n");
            }
        }
        catch(Exception ex){
            Console.WriteLine(ex.ToString());
        }
    }
}