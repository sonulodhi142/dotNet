using System;

class Program{
    static void Main(string[] args){
        Console.Write("Enter the num::");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < num; i++){
            for(int j = 0; j < num - i; j++){
                Console.Write(" ");
            }
            for(int k = 0; k < i; k++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}