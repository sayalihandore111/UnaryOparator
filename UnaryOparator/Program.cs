
using System;

namespace UnaryOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Assigning value to a and b");
            a = b = 15;
            Console.WriteLine("a= " + a);//a = 15
            Console.WriteLine("b= " + b);//b = 15
            Console.WriteLine("Post incrementing a & assinging its value to b");
            b = a++;
            Console.WriteLine("a= " + a);//a = 16
            Console.WriteLine("b= " + b);//b = 15
            Console.WriteLine("Post decrementing a & assinging its value to b");
            b = a--;
            Console.WriteLine("a= " + a);//a = 15
            Console.WriteLine("b= " + b);//b = 16
            Console.WriteLine("Pre decrementing a & assinging its value to b");
            b = ++a;
            Console.WriteLine("a= " + a);//a = 16
            Console.WriteLine("b= " + b);//a = 16
            Console.WriteLine("Pre decrementing a & assinging its value to b");
            b = --a;
            Console.WriteLine("a= " + a);//a = 15
            Console.WriteLine("b= " + b);//b = 15
            Console.ReadKey();
        }
    }
}