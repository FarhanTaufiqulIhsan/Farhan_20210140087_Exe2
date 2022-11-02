using System;
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
        int m;
        int r;
        int l;

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

        public void displayinsertionsort()
        {
            // function to display the array of size n
            n = farhan.Length;
            for (i = 0; i < n; i++)
                Console.Write(farhan[i] + "");
            Console.Write("\n");
        }

        public void mergesort()
        {
            // find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, FI;

            // copy data to temp arrays
            for (i = 0; i < n1; i++)
                L[i] = farhan[l + i];
            for (FI = 0; FI < n2; i++)
                R[FI] = farhan[m + i + FI];

            // merge the temp arrays
            i=0;
            FI = 0;

            int k = l;
            while (i < n1 && FI < n2)
            {
                if (L[i] <= R[FI])
                {
                    farhan[k] = L[i];
                    i++;
                }
                else
                {
                    farhan[k] = R[FI];
                    FI++;
                }
                k++;
            }

            //Copy remaining elements
            while (i < n1)
            {
                farhan[k] = L[i];
                i++;
                k++;
            }

            while (FI < n2)
            {
                farhan[k] = R[FI];
                FI++;
                k++;
            }
        }

        
        static void Main(string[] args)
        {
        }
    }
}
