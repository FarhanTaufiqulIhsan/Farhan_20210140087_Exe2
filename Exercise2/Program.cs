﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        // Array to be searched
        private int[] farhan = new int[35];
        // Number of the elements in the array
        private int n;
        // Get the number of elements to store in the array
        private int i;

        public void input()
        {
            // for looping the input class
            while (true)
            {
                // message for user to enter the array
                Console.WriteLine("Enter the number of the element in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);

                // add maximum and minimum array that can be assign in this system
                if ((n > 0) && (n <= 35))
                    break;
                else
                    // add message if the user try to input the array above the limits
                    Console.WriteLine("\nArray should have minimum 1 and maximum 35 elements. \n");

            }
            // Accept array elements
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("----------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                farhan[i] = Int32.Parse(s1);
            }   
        }
        public void InsertionSort()
        {
            for (i = 1; i < n; i++)
            {
                // Move elements of array [0...i-1],
                // thar are greater than temp,
                // to one position ahead of,
                // their current position.
                int temp = farhan[i];
                int FI = i - 1;

                while (FI >= 0 && farhan[FI] > temp)
                {
                    farhan[FI + 1] = farhan[FI];
                    FI = FI - 1;
                }
                farhan[FI + 1] = temp;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
