using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {

        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9,};
        // using loop itration
        for(int i = 0; i < list.Count; i++){
            Console.WriteLine(list[i]);
        }

        // using LINQ
        var result = from num in list
                     where num > 4
                     select num;

        foreach (int num in result) {
            Console.WriteLine(num);
        }
    }
}