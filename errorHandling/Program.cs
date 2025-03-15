using System;

class Program{
    static void Main(string[] args){
        try{
            Console.WriteLine("every thing looks good:");
            int num1 = 10;
            int num2 = 0;
            Console.WriteLine(num1/num2);
        }
        catch(Exception e){
            Console.WriteLine("The error is : "+e.ToString());
            
        }
        finally{
            Console.WriteLine("Program end:");
        }
    }
}