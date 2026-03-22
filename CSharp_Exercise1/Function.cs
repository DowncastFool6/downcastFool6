using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercises
{
    public class Function
    {
        // void function – greeting
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // Function with return value – square
        public int Square(int n12)
        {
            return n12 * n12;
        }

        // Function to calculate average
        public double Average(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            double sum = 0;

            foreach (int n13 in numbers)
            {
                sum += n13;
            }

            return sum / numbers.Length;
        }

        // Function to check for even numbers
        public bool IsEven(int n14)
        {
            if (n14 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Function to check prime numbers
        public bool IsPrime(int n15)
        {
            if (n15 <= 1)
                return false; // becuase 0 and 1 are not prime numbers


            for (int i = 2; i <= Math.Sqrt(n15); i++) // Check divisibility from 2 up to squared number
            {
                if (n15 % i == 0)
                    return false;
            }
            return true;
        }

        // Function to reverse a string
        public string ReverseString(string word)
        {
            char[] chars = word.ToCharArray(); // Convert string to char array
            Array.Reverse(chars);               // Reverse the array
            return new string(chars);           // Convert back to string
        }

        // Function for counting vowels
        public int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU"; // Include uppercase and lowercase

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                    count++;
            }

            return count;
        }

            // Function for the sum of two numbers
            public int Sum(int a, int b)
            {
                return a + b;
            }

        // Function to print numbers from 1 to N
        public void PrintNumbers(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    } 

}
