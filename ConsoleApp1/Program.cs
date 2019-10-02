using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        /* program to test above function */


        static void printRepeating(int[] arr, int size)
        {
            int i, j;

            Console.Write("Repeated Elements are :");
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[i] + " ");
                }
            }
        }
        // driver code 
        public static void Main()
        {
            int[] arr = { 4, 2, 4, 5, 2, 3, 1 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);
        }
    }
}