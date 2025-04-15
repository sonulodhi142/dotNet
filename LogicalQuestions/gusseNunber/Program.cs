using System;
class Program{
    static void Main(string[] args){
        Random random = new Random();
        int targetNumber = random.Next(0,10);

        Console.WriteLine("Welcome to the Number Guessing Game !");
        Console.WriteLine("I have chosen a number between 1 and 10. try to guess it\n");
        
            Console.Write("Enter Your guess::");
            int guessNumber = Convert.ToInt32(Console.ReadLine());
            if(guessNumber == targetNumber){
                Console.WriteLine("Cogratulation! you guess the correct number\n\n");
            }
            else{
                Console.WriteLine("Oops ! You gues the wrong number \n\n best of luck for next time \n try again !\n");
            } 
    }
}