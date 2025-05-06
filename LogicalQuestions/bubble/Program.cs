using System;

class BubbleSortExample
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        // Loop through the array
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            // Compare each pair of adjacent elements
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap if they are in wrong order
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no elements were swapped, array is sorted
            if (!swapped)
                break;
        }
    }

    static void Main()
    {
        int[] arr = { 78, 32, 42, 98, 12, 34, 83 };

        Console.WriteLine("Original array: " + string.Join(" ", arr));

        BubbleSort(arr);

        Console.WriteLine("Sorted array: " + string.Join(" ", arr));
    }
}
