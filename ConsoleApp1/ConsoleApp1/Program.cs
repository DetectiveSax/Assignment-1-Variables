﻿using System;

namespace ConsoleApp1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string name01;

            Console.Write("Hello user. My name is Al. What is your name?");

           name01 = (Console.ReadLine());

            Console.WriteLine("Hello" + name01);
            Console.ReadLine();

            Console.Write("How old are you" + name01);
            Console.ReadLine();

            int num01;
            num01 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine(num01 + "years old. Wow I am unaware of time as a concept, but that's still amazing!");
            Console.ReadLine();

            

        }
    }
}
