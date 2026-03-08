using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage tea = new Tea();
            Beverage coffee = new Coffee();
            Beverage hotChocolate = new HotChocolate();

            Console.WriteLine("Приготовление чая:");
            tea.PrepareRecipe();

            Console.WriteLine("\nПриготовление кофе:");
            coffee.PrepareRecipe();

            Console.WriteLine("\nПриготовление горячего шоколада:");
            hotChocolate.PrepareRecipe();
        }
    }
}