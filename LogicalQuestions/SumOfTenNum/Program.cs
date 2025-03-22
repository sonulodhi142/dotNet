using System;

class Program{
    static void Main(string[] args){

        Console.Write("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for(int i = 0; i <= num; i++){
            sum = sum + i;
        }

        Console.WriteLine($"Sum of {num} numers is :{sum}");
    }
}