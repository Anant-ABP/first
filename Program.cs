using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("hello " + name);
            Console.WriteLine("enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("your age is :" + age);

            //operator and interpolation
            int a;
            int b;
            Console.WriteLine("Enter first positive no. :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second positive no. :");
            b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine($"addition of {a} and {b} is :" + sum);
            int sub = a - b;
            Console.WriteLine($"minus of {a} and {b} is :" + sub);
            float div = a / (float)b;
            Console.WriteLine($"division of {a} and {b} is :" + div);
            int mul = a * b;
            Console.WriteLine($"multiplication of {a} and {b} is :" + mul);

            //bitwise
            int alb = a << b;
            Console.WriteLine(alb);
            int arb = a >> b;
            Console.WriteLine(arb);
            int aab = a & b;
            Console.WriteLine(aab);

            int c = 10;
            while (c > 0)
            {
                Console.WriteLine(c);
                c--;
            }
            string str1, str2, str3;
            Console.WriteLine("Enter string no.1: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter string no.2: ");
            str2 = Console.ReadLine();
            int len = str1.Length;
            Console.WriteLine("length of string no.1 is: " + len);
            str3 = str1.ToLower();
            Console.WriteLine("string no.1 in lower: " + str3);
            str3 = str2.ToUpper();
            Console.WriteLine("string no.1 in upper: " + str3);
            str3 = str1 + " " + str2;
            Console.WriteLine("adding two strings: " + str3);
        }
    }
}