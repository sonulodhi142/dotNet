using System;

class program {
    static void Main(string[] args){
        Console.Write("Enter the Number line ::");
        int num = Convert.ToInt32(Console.ReadLine());

        string star = "* ";
        Console.WriteLine("Star pattern:-");
        for (int i = 0; i < num; i++) {
            Console.WriteLine(star);
            star = star + "* ";
        }
    }
}