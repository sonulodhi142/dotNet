using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 2, 3, 4, 4, 5, 6, 7, 7, 1, 5, 0 };
        
        HashSet<int> set = new HashSet<int>(array);
        
        foreach(int i in set){
            Console.WriteLine(i);
        }
    }
}
