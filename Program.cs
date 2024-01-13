using System;
using System.Collections;

namespace Demo
{
    class Programs
    {
        static void Main(string[] args)
        {
            Queue ar = new Queue();

            ar.Enqueue("red");
            ar.Enqueue("roses");
            ar.Enqueue("wine");

            Console.WriteLine("Does the que contain roses? True or false? " + ar.Contains("roses"));
            Console.Read();
        }
    }
}