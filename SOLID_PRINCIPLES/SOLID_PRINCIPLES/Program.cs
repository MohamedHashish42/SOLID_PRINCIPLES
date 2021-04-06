using SOLID_PRINCIPLES._3_LSP;
using System;

namespace SOLID_PRINCIPLES
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Liskov Substitution Principle
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());

            Fruit fruit = new Orange2();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple2();
            Console.WriteLine(fruit.GetColor());
            #endregion
        }
    }
}
