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
        private Int64[] farhan = new Int64[35];
        // Number of the elements in the array
        private Int64 n;
        // Get the number of elements to store in the array
        private Int64 i;

        public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of the element in the array: ");
                string s = Console.ReadLine();
                n = Int64.Parse(s);
                if ((n > 0) && (n <= 35))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 35 elements. \n");

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
