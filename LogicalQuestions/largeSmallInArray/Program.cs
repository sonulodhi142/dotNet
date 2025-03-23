using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        int[] array = { 1, 2, 3, 4, 5, 10, 99, 67, 47, 88, 0, 777};

        int largest = array[0];
        int smallest = array[0];

        foreach (int i in array) {
            if(smallest > i){
                smallest = i;
            }
            if(largest < i){
                largest = i;
            }
        }
        Console.WriteLine("the Largest number in array is :" + largest);
        Console.WriteLine("the smallest number in array is :" + smallest);
    }
}