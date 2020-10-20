using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Banana banana = new Banana();

            apple.Grow();
            banana.Grow();
        }

        class Fruit
        {
            public virtual void Grow()
            {                                                
                Console.WriteLine("Grow");
            }
        }
        class Apple : Fruit
        {
            public override void Grow()
            {
                Console.WriteLine("Apple");
                base.Grow();
            }
        }
        class Banana : Fruit
        {
            public override void Grow()
            {
                Console.WriteLine("Banana");
                base.Grow();
            }
        }
    }
}