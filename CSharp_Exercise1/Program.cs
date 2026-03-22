namespace Level1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Verification of Postive & Negative Numbers.");
            //Console.WriteLine("===========================================");

            //Console.WriteLine("\nInsert any number: ");
            //int number = Int32.Parse(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("That is a negative number.");
            //}
            //else if (number > 0)
            //{
            //    Console.WriteLine("That is a postive number.");
            //}
            //else
            //{
            //    Console.WriteLine("Neither positive nor negative, that is a zero");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Verification of the Largest Number");
            //Console.WriteLine("===========================================");

            //Console.WriteLine("\nInsert three numbers: ");
            //float n1 = float.Parse(Console.ReadLine());
            //float n2 = float.Parse(Console.ReadLine());
            //float n3 = float.Parse(Console.ReadLine());

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine($"Number {n1} is the largest.");
            //}
            //else if (n2 > n3 && n2 > n1)
            //{
            //    Console.WriteLine($"Number {n2} is the largest");
            //}
            //else if (n3 > n1 && n3 > n2) 
            //{
            //    Console.WriteLine($"Number {n3} is the largest");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers are the same.");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Verification of Even & Odd Numbers");
            //Console.WriteLine("===========================================");

            //Console.WriteLine("\nInsert any number: ");
            //int n4 = Int32.Parse(Console.ReadLine());

            //if (n4 % 2 == 0)
            //{
            //    Console.WriteLine($"Number {n4} is an even number");
            //}
            //else if (n4 % 2 == 1)
            //{
            //    Console.WriteLine($"Number {n4} is an odd number");
            //}
            //else if (n4 == 0)
            //{
            //    Console.WriteLine($"Number {n4} is not divisible");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Multiplication Table of a Number");
            //Console.WriteLine("===========================================");

            //Console.WriteLine("\nInsert any number: \n");
            //int multiplier = Int32.Parse(Console.ReadLine());

            //for (int i = 1; i < 13; i++)
            //{
            //    Console.WriteLine($"{i} x {multiplier} = {i * multiplier}");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Sum of Numbers up to Zero");
            //Console.WriteLine("===========================================");

            //Console.WriteLine("\nInsert various numbers, then type 0: ");

            //float sum = 0;
            //float j;

            //do
            //{
            //    j = float.Parse(Console.ReadLine());
            //    sum += j;
            //}
            //while (j > 0);

            //Console.WriteLine($"\nThe sum of these numbers is {sum}");

            //Console.WriteLine("");
            //Console.WriteLine("Countdown");
            //Console.WriteLine("===========================================");

            //Console.WriteLine("\nInsert any number: ");

            //int n5 = Int32.Parse(Console.ReadLine());

            //for (int i = n5; i >= 0; i--)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Even Numbers from 1 to 50");
            //Console.WriteLine("===========================================");

            //int k = 0;
            //int n6 = 50;

            //while (k < n6)
            //{
            //    if (k % 2 == 0)
            //    {
            //        Console.WriteLine(k);
            //    }
            //    k++;
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Number of Attempts Until Correct");
            //Console.WriteLine("===========================================");

            //Random rnd = new Random();
            //int random_num = rnd.Next(1, 20);
            //int guess;
            //int attempt = 0;

            // Console.WriteLine(rnd.Next(1, 20));

            //do
            //{
            //    guess = Int32.Parse(Console.ReadLine());
            //    attempt++;
            //}
            //while (guess != random_num);

            //Console.WriteLine($"Correct! Number of attempts: {attempt}");

            //Console.WriteLine("");
            //Console.WriteLine("Average Grade");
            //Console.WriteLine("===========================================");

            //float[] grade = new float[5];
            //float sum = 0;

            //Console.WriteLine("\nInsert 5 grades to calculate the average\n");

            //for (int i = 0; i < grade.Length; i++) 
            //{
            //    Console.Write($"Grade {i + 1}: ");
            //    grade[i] = float.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < grade.Length; i++) 
            //{
            //    sum += grade[i];
            //}

            //float average = sum / grade.Length;

            //Console.WriteLine($"The average grade is: {average:F2}");

            //Console.WriteLine("");
            //Console.WriteLine("Largest and smallest Number");
            //Console.WriteLine("===========================================");

            //int[] n7 = new int[10];

            //for (int i = 0; i < n7.Length; i++)
            //{
            //    Console.Write($"Insert 10 numbers to Determine the Largest & Smallest {i + 1}: ");
            //    n7[i] = int.Parse(Console.ReadLine());
            //}

            //int largest = n7[0];
            //int smallest = n7[0];

            //for (int i = 1; i < n7.Length; i++)
            //{
            //    if (n7[i] > largest)
            //    {
            //        largest = n7[i];
            //    }

            //    if (n7[i] < smallest)
            //    {
            //        smallest = n7[i];
            //    }
            //}

            //Console.WriteLine($"\nThe largest number is: {largest}");
            //Console.WriteLine($"The smallest number is: {smallest}");

            //Console.WriteLine("");
            //Console.WriteLine("Reverse Count of An Array of Numbers");
            //Console.WriteLine("===========================================");

            //int[] n8 = new int[5];

            //for (int i = 0; i < n8.Length; i++)
            //{
            //    Console.Write($"Insert a number {i + 1}: ");
            //    n8[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nArray in reverse order:");

            //for (int i = n8.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(n8[i]);
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Summing Up Elements in An Array");
            //Console.WriteLine("===========================================");

            //int[] n9 = new int[5];
            //int sum = 0;

            //for (int i = 0; i < n9.Length; i++)
            //{
            //    Console.Write($"Insert a number {i + 1}: ");
            //    n9[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int number in n9)
            //{
            //    sum += number;
            //}

            //Console.WriteLine($"\nThe sum of all elements is: {sum}");

            //Console.WriteLine("");
            //Console.WriteLine("A List of Names");
            //Console.WriteLine("===========================================");

            //List<string> names = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter a name {i + 1}: ");
            //    string name = Console.ReadLine();
            //    names.Add(name);
            //}

            //Console.WriteLine("\nThe names you entered are:");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Removing Items from a List");
            //Console.WriteLine("===========================================");

            //List<int> digits = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter a number {i + 1}: ");
            //    int n10 = int.Parse(Console.ReadLine());
            //    digits.Add(n10);
            //}

            //// Removes all the even numbers in the list
            //digits.RemoveAll(n => n % 2 == 0);

            //Console.WriteLine("\nUpdated list of the odd numbers only: ");
            //foreach (int n10 in digits)
            //{
            //    Console.WriteLine(n10);
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Counting Repeated Elements in a List");
            //Console.WriteLine("===========================================");

            //List<string> fruits = new List<string>();

            //Console.Write("How many fruits do you want to enter? ");
            //int n11 = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n11; i++)
            //{
            //    Console.Write($"Enter fruit {i + 1}: ");
            //    string fruit = Console.ReadLine();
            //    fruits.Add(fruit);
            //}

            //List<string> counted = new List<string>();

            //Console.WriteLine("\nFruit occurrences:");

            //foreach (string fruit in fruits)
            //{
            //    // Skips if already counted
            //    if (counted.Contains(fruit, StringComparer.OrdinalIgnoreCase))
            //        continue;

            //    int count = 0;

            //    // Counts how many times this fruit appears
            //    foreach (string f in fruits)
            //    {
            //        if (string.Equals(f, fruit, StringComparison.OrdinalIgnoreCase))
            //            count++;
            //    }

            //    Console.WriteLine($"{fruit} appears {count} time(s)");

            //    counted.Add(fruit);
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Function: Greeting");
            //Console.WriteLine("==========================");

            //Console.Write("Enter your name: ");
            //string userName = Console.ReadLine();

            //CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            //function.Greet(userName);

            //Console.WriteLine("");
            //Console.WriteLine("Function: Return Square Root");
            //Console.WriteLine("==============================");

            //CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            //Console.Write("Enter a number to square root it: ");
            //int n12 = int.Parse(Console.ReadLine());

            //int squared = function.Square(n12);

            //Console.WriteLine($"The square root of {n12} is {squared}");

            //Console.WriteLine("");
            //Console.WriteLine("Function: Calculate Average");
            //Console.WriteLine("==============================");

            //CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            //Console.WriteLine("Enter 5 numbers to calculate the average: ");

            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //double avg = function.Average(numbers);

            //Console.WriteLine($"The average is: {avg:F2}");

            //Console.WriteLine("");
            //Console.WriteLine("Function: Verify Even Numbers");
            //Console.WriteLine("==============================");

            //CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            //Console.Write("Enter a number to check if it's even: ");
            //int n14 = int.Parse(Console.ReadLine());

            //bool isEven = function.IsEven(n14);

            //if (function.IsEven(n14))
            //{
            //    Console.WriteLine($"{n14} is even");
            //}
            //else
            //{
            //    Console.WriteLine($"{n14} is odd");
            //}

            //Console.WriteLine($"{n14} is {(isEven ? "even" : "odd")}");     // ALternative solution (Ternary Conditional)

            //Console.WriteLine("");
            //Console.WriteLine("Function: Verify Prime Numbers");
            //Console.WriteLine("==============================");

            //CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            //Console.Write("Enter a number to check if it is prime: ");
            //int n15 = int.Parse(Console.ReadLine());

            //bool isPrime = function.IsPrime(n15);

            //if (isPrime)
            //    Console.WriteLine($"{n15} is a prime number.");
            //else
            //    Console.WriteLine($"{n15} is not a prime number.");

            //Console.WriteLine("");
            //Console.WriteLine("Function: Reverse a String");
            //Console.WriteLine("==============================");

            //CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            //Console.Write("Enter a string to reverse: ");
            //string word = Console.ReadLine();

            //string reversed = function.ReverseString(word);

            //Console.WriteLine($"Reversed string: {reversed}");

            //Console.WriteLine("");
            //Console.WriteLine("Function: Counting Vowels");
            //Console.WriteLine("==============================");

            //CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            //Console.Write("Enter a string to count vowels: ");
            //string userInput = Console.ReadLine();

            //int vowelCount = function.CountVowels(userInput);

            //Console.WriteLine($"Number of vowels: {vowelCount}");

            //Console.WriteLine("");
            //Console.WriteLine("Function: Sum of Two Numbers");
            //Console.WriteLine("==============================");

            //CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            //Console.Write("Enter the first number: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int b = int.Parse(Console.ReadLine());

            //int result = function.Sum(a, b);

            //Console.WriteLine($"{a} + {b} = {result}");

            Console.WriteLine("");
            Console.WriteLine("Function: Print Numbers from 1 to N");
            Console.WriteLine("==============================");

            CSharp_Exercises.Function function = new CSharp_Exercises.Function();

            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numbers from 1 to {N}:");
            function.PrintNumbers(N);
        }
    }
}
