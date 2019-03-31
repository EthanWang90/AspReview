using System;

namespace ConsoleReview1
{
    class Program
    {
        static void Main(string[] args)
        {
            Son newSon = new Son();
            newSon.live();
            Console.WriteLine("--------------------");
            newSon.eat();
        }
    }
}
