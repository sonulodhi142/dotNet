using System;

class SI 
{
    public static void Main()
    {
        float p = 12000, r = 2, t = 2, si;
        si = (p * r * t) / 100;
        Console.WriteLine("The simple interest is {0}", si);
    }
}
