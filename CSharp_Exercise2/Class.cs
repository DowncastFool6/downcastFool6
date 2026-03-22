using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Exercise1
{
    public class Class
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name)
            {
                this.Name = name;
            }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public override string ToString()
            {
                // Concatenation
                return $"Person Name: {Name} | Age: {Age} |";
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public float Price { get; set; }

            public Product(string name, float price)
            {
                this.Name = name;
                this.Price = price;
            }

            public override string ToString()
            {
                // Concatenation
                return $"Product Name: {Name} | Price: {Price} |";
            }
        }

        public class Student
        {
            private float Mark;

            public float mark
            {
                get {  return mark; }
                set
                {
                    if (value < 0)
                        Console.WriteLine("Error: Grade cannot be negative.");
                    else
                        mark = value;
                }
            }

            public Student(float mark)
            {
                this.Mark = mark;
            }

            public override string ToString()
            {
                // Concatenation
                return $"Student's mark: {Mark} |";
            }
        }

        public class BankAccount
        {
            public string Holder { get; set; }

            public double Balance { get; private set; }

            public BankAccount(string holder, double balance)
            {
                this.Holder = holder;
                this.Balance = balance;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
            }

            public override string ToString()
            {
                // Concatenation
                return $"Account Holder: {Holder} | Balance: {Balance} |";
            }
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }

            public Book(string title, string author, int year)
            {
                this.Title = title;
                this.Author = author;
                this.Year = year;
            }

            public override string ToString()
            {
                // Concatenation
                return $"Book Title: {Title} | Author: {Author} | Year: {Year} |";
            }
        }
    }
}
