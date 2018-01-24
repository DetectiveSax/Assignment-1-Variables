using System;

namespace ConsoleApp1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int age1;
            string name01;

            Console.Write("Hello user. My name is Al. What is your name?");

           name01 = (Console.ReadLine());

            Console.WriteLine("Hello" + name01);
            Console.ReadKey();

            Console.Write("How old are you" + name01);
            Console.ReadKey();

            age1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(age1 + " years old. Wow I am unaware of time as a concept, but that's still amazing!");
            Console.ReadKey();


            

        }
    }
}
