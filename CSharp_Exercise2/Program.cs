using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static CSharp_Exercise1.Class;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("EXERCISE 1");
            //Console.WriteLine("===========\n");

            //string firstName = "Vissolela";
            //string lastName = "Cundi";

            //Console.WriteLine($"{firstName} {lastName}\n");

            //Console.WriteLine("EXERCISE 2");
            //Console.WriteLine("===========\n");

            //string phrase = "Aprender C# é divertido";

            //Console.WriteLine(phrase);

            //string word = phrase.Substring(0, 8);
            //Console.WriteLine(word);

            //Console.WriteLine("EXERCISE 3");
            //Console.WriteLine("===========\n");

            //string phrase1 = "Eu gosto de programação";

            //Console.WriteLine(phrase1);

            //phrase1 = phrase1.Replace("programação", "C#");
            //Console.WriteLine(phrase1);

            //Console.WriteLine("EXERCISE 4");
            //Console.WriteLine("===========\n");

            //string phrase2 = "C# é uma linguagem poderosa";
            //Console.WriteLine(phrase2);

            //int indexPosition = phrase2.IndexOf("linguagem");
            //Console.WriteLine($"Index Position of 'linguagem' is {indexPosition}");

            //Console.WriteLine("EXERCISE 5");
            //Console.WriteLine("===========\n");

            //Console.WriteLine("Enter any phrase: ");
            //string userPhrase = Console.ReadLine();

            //Console.WriteLine(userPhrase);

            //int indexPosition1 = userPhrase.IndexOf('a');
            //Console.WriteLine($"Index Position of the first 'a' is {indexPosition1}");

            //Console.WriteLine("EXERCISE 6");
            //Console.WriteLine("===========\n");

            //StringBuilder num = new StringBuilder();

            //for (var i = 1; i <= 5; i++)
            //{
            //    num.Append(i);

            //    if (i < 5)
            //    {
            //        num.Append(", ");
            //    }
            //}

            //string result = num.ToString();
            //Console.WriteLine(result);

            //Console.WriteLine("EXERCISE 7");
            //Console.WriteLine("===========\n");

            //StringBuilder words = new StringBuilder();

            //words.Append("Hoje ");
            //words.Append("estou ");
            //words.Append("a ");
            //words.Append("aprender ");
            //words.Append("C#.");

            //Console.WriteLine(words);

            //Console.WriteLine("EXERCISE 8");
            //Console.WriteLine("===========\n");

            //StringBuilder num1 = new StringBuilder();

            //for (var i = 1; i <= 20; i++)
            //{
            //    num1.Append(i);

            //    if (i < 20)
            //    {
            //        num1.Append(", ");
            //    }
            //}

            //string result1 = num1.ToString();
            //Console.WriteLine(result1);

            //Console.WriteLine("EXERCISE 9");
            //Console.WriteLine("===========\n");

            //Person person1 = new Person("Nuno Cardoso");

            //Console.WriteLine(person1.Name);

            //Console.WriteLine("EXERCISE 10");
            //Console.WriteLine("===========\n");

            //Product product1 = new Product("Laptop", 1500);

            //Console.WriteLine($"Product 1: {product1.Name} | Price: {product1.Price} |");

            //Console.WriteLine("EXERCISE 11");
            //Console.WriteLine("===========\n");

            //Student student = new Student(-5);

            //Console.WriteLine(student.mark);

            //Console.WriteLine("EXERCISE 12");
            //Console.WriteLine("===========\n");

            //BankAccount account = new BankAccount("Maria", 0);
            //account.Deposit(500);

            //Console.WriteLine(account);

            //Console.WriteLine("EXERCISE 13");
            //Console.WriteLine("===========\n");

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            //foreach (var n in evenNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine("EXERCISE 14");
            //Console.WriteLine("===========\n");

            //List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
            //var squareRoot = numbers1.Select(n => n * n);

            //foreach (var n in squareRoot)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine("EXERCISE 15");
            //Console.WriteLine("===========\n");

            //List<string> names = new List<string> { "Bruno", "Diana", "Carlos", "Ana" };
            //var namesOrdered = names.OrderBy(n => n);

            //foreach (var n in namesOrdered)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine("EXERCISE 16");
            //Console.WriteLine("===========\n");

            //List<int> num3 = new List<int> { 10, 20, 30, 40 };
            //var sum = num3.Sum();
            //double average = num3.Average();

            //Console.WriteLine($"The sum is {sum}");
            //Console.WriteLine($"The average is {average}");

            //Console.WriteLine("EXERCISE 17");
            //Console.WriteLine("===========\n");

            //List<int> num4 = new List<int> { 3, 5, 7, 8, 9 };
            //bool existEvenNumber = num4.Any(n => n % 2 == 0);

            //Console.WriteLine(existEvenNumber);

            //Console.WriteLine("EXERCISE 18");
            //Console.WriteLine("===========\n");

            //List<int> num5 = new List<int> { 5, 8, 12, 3, 7 };
            //int firstNumber = num5.First(n => n > 6);

            //Console.WriteLine(firstNumber);

            //Console.WriteLine("EXERCISE 19");
            //Console.WriteLine("===========\n");

            //List<Person> list_person = new List<Person>();
            //Person person2 = new Person("Vissolela", 17);
            //Person person3 = new Person("Nuno", 28);
            //Person person4 = new Person("Grecia", 45);

            //list_person.Add(person2);
            //list_person.Add(person3);
            //list_person.Add(person4);

            //var underAge = list_person.Where(p => p.Age > 18);

            //foreach (var person in underAge)
            //{
            //    Console.WriteLine(person);
            //}

            //Console.WriteLine("EXERCISE 20");
            //Console.WriteLine("===========\n");

            //List<string> words1 = new List<string>() { "Olá", "Tudo", "Bem" };

            //var exclamation = words1.Select(w => w + "!");

            //foreach (var w in exclamation)
            //{
            //    Console.WriteLine(w);
            //}

            //Console.WriteLine("EXERCISE 21");
            //Console.WriteLine("===========\n");

            //List<int> num5 = new List<int>() {3,8,1,5,10};

            //var descending = num5.OrderByDescending(j => j);

            //foreach (var j in descending)
            //{
            //    Console.WriteLine(j);
            //}

            //Console.WriteLine("EXERCISE 22");
            //Console.WriteLine("===========\n");

            //List<int> num6 = new List<int>() {1,2,3,4,5,6};

            //var evenNum1 = num6.Where(n => n % 2 == 0);
            //int total = evenNum1.Sum();

            //Console.WriteLine($"The total is: {total}");

            //Console.WriteLine("EXERCISE 23");
            //Console.WriteLine("===========\n");

            //List<string> listNames = new List<string>() {"Ana","Carlos","Bruno"};

            //StringBuilder names = new StringBuilder();

            //for (int i = 0; i < listNames.Count; i++) 
            //{
            //    names.Append(listNames[i]);

            //    if (i < listNames.Count -1)
            //        names.Append(", ");
            //}

            //Console.WriteLine(names.ToString());

            //Console.WriteLine("EXERCISE 24");
            //Console.WriteLine("===========\n");

            //List<Book> book_list = new List<Book>();

            //Book book1 = new Book("Book A", "Author A", 2018);
            //Book book2 = new Book("Book B", "Author B", 2015);

            //book_list.Add(book1);
            //book_list.Add(book2);

            //var orderedBook = book_list.OrderBy(b => b.Year);

            //foreach (var book in orderedBook) 
            //{
            //    Console.WriteLine(book);
            //}

            Console.WriteLine("EXERCISE 25");
            Console.WriteLine("===========\n");

            List<Product> products = new List<Product>();

            Product product2 = new Product("Pen", 2.5f);
            Product product3 = new Product("Notebook", 12.50f);
            Product product4 = new Product("Mouse", 15.50f);

            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            var result = products.Where(p => p.Price > 10).OrderBy(p => p.Price);

            foreach (var p in result) 
                Console.WriteLine(p);
        }
    }
}
