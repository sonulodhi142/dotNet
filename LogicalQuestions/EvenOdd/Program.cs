using System;

class Porgam{
    public static void Main(string[] args){

        Console.Write("Enter the Number:: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num%2==0){
            Console.WriteLine("The given number is even::");
        }
        else{
            Console.WriteLine("The given number is odd::");
        }
    }
}