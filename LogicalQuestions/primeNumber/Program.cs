using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i < num; i++) {
            if(num%i==0){
                Console.WriteLine("The given number is Not prime:");
                return;
            }
        }
        Console.WriteLine("The given number is Prime::");
    }
}