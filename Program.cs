using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string FirstName;
            string age;


            Console.WriteLine("what is Your Name");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your age");
            age = Console.ReadLine();


            //string response = "Your name is" + FirstName + "And your age is " + age;

            string response = $"Your name is {FirstName} and your age is {age}";

            Console.WriteLine(response);



        }

    }
    }

