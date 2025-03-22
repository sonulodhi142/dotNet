using System;

class Program{
    static void Main(string[] args){

        Console.Write("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int Factorial = 1;

        for(int i = 1; i <= num; i++){
            Factorial = Factorial * i;
        }

        Console.WriteLine($"Factorial of {num}  is :{Factorial}");
    }
}