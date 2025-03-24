using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter the number of terms::");
        int num = Convert.ToInt32(Console.ReadLine());

        int firstNum = 0;
        int secNum = 1;
        int thirdNum = 0;
        Console.WriteLine(firstNum);
        Console.WriteLine(secNum);

        for (int i = 2; i < num; i++) {
            thirdNum = firstNum + secNum;
            firstNum = secNum;
            secNum = thirdNum;
            Console.WriteLine(thirdNum);
        }

    }
}