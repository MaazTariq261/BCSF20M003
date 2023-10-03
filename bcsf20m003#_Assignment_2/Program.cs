using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.Intrinsics.X86;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        static void Question_1()
        {

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;

            Console.WriteLine("Full name: " + fullName);
        }

        static void Question_2()
        {
            string sentence = "This is a sample sentence";
            char[] arry = sentence.ToCharArray();

            for (int i = sentence.Length - 5; i < sentence.Length; i++)
            {
                Console.Write(arry[i]);
            }

            Console.WriteLine();
        }
        static void Question_3()
        {

            Console.WriteLine("Enter temperature");
            double temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter city name");
            string city = Console.ReadLine();

            Console.WriteLine($"The temperature in {city} is {temperature} degrees Celsius.");

        }
        static void Question_4()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        static void Question_5a()
        {
            string[] fruits = { "apple", "oranges", "banana", "mango" };
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);

            }
        }
        static void Question_5b()
        {
            string[] colors = { "green", "blue", "white", "yellow" };
            foreach (var color in colors)
            {
                Console.Write($"{color}, ");

            }
        }
        static void Question_6()
        {

            int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            int i = 0;

            do
            {
                sum = sum + scores[i];
                i++;
            } while (i < scores.Length);

            Console.WriteLine($"Sum is : {sum}");

        }
        static void Question_7()
        {
            int[] values = { 20, 19, 56, 1, 3, 50 };
            int max = values[1];
            int i = 0;

            while (i < values.Length)
            {
                if (max < values[i])
                {
                    max = values[i];
                }
                i++;
            }
            Console.WriteLine($"Max value : {max}");

        }
        static void Question_8()
        {

            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.Reverse(numbers);

            foreach (var no in numbers)
            {
                Console.Write($"{no},");
            }
        }
        static void Question_9a()
        {
            
            int x = 42;
            Object obj = x;
            int y = Convert.ToInt32(obj);
            Console.WriteLine(y);
        }
        static void Question_9b()
        {
            double doubleValue = 3.14159;
            Object obj_1 = doubleValue;
            double unboxedValue = Convert.ToDouble(obj_1);
            Console.Write(unboxedValue);
        }
        static void Question_10a()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (var no in numbers)
            {
                Object obj = no;
                int unbox = no;
                unbox = unbox * unbox;
                Console.WriteLine($"Originsl number : {no} Square : {unbox}");
            }
        }
        static void Question_10b()
        {
            List<Object> genericList = new List<object>();

            genericList.Add(2);
            genericList.Add(2.4747);
            genericList.Add('c');

            foreach (var element in genericList)
            {
                Type whatType = element.GetType();
                Console.WriteLine($"Elemet : {element} Type : {whatType}");
            }
        }
        static void Question_11a()
        {
            dynamic myVariable = 42;
            Console.WriteLine(myVariable);
            myVariable = "Hello, Dynamic!";
            Console.WriteLine(myVariable);
        }
        static void Question_11b()
        {

            dynamic myVariable = 42;
            Console.WriteLine(myVariable.GetType());
            myVariable = 56.998;
            Console.WriteLine(myVariable.GetType());
            myVariable = DateTime.Now;
            Console.WriteLine(myVariable.GetType());
            myVariable = "Hello World";
            Console.WriteLine(myVariable.GetType());

        }

        Console.WriteLine("Question 1");
        Question_1();
        Console.WriteLine("Question 2");
        Question_2();
        Console.WriteLine("Question 3");
        Question_3();
        Console.WriteLine("Question 4");
        Question_4();
        Console.WriteLine("Question 5a");
        Question_5a();
        Console.WriteLine("Question 5b");
        Question_5b();
        Console.WriteLine("Question 6");
        Question_6();
        Console.WriteLine("Question 7");
        Question_7();
        Console.WriteLine("Question 8");
        Question_8();
        Console.WriteLine("Question 9a");
        Question_9a();
        Console.WriteLine("Question 9b");
        Question_9b();
        Console.WriteLine("Question 10a");
        Question_10a();
        Console.WriteLine("Question 10b");
        Question_10b();
        Console.WriteLine("Question 11a");
        Question_11a();
        Console.WriteLine("Question 11b");
        Question_11b();
        



    }
}
