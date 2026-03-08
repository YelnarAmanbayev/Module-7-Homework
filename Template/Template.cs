using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected void BoilWater()
        {
            Console.WriteLine("Кипятим воду");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Наливаем в чашку");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        protected bool GetUserAnswer(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "да" || input == "д")
                return true;

            if (input == "нет" || input == "н")
                return false;

            Console.WriteLine("Некорректный ввод. По умолчанию добавки не будут добавлены.");
            return false;
        }
    }

    class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем чай");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем лимон");
        }
    }

    class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем сахар и молоко");
        }

        protected override bool CustomerWantsCondiments()
        {
            return GetUserAnswer("Добавить сахар и молоко в кофе? (да/нет): ");
        }
    }

    class HotChocolate : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Готовим горячий шоколад");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем маршмеллоу");
        }

        protected override bool CustomerWantsCondiments()
        {
            return GetUserAnswer("Добавить маршмеллоу? (да/нет): ");
        }
    }
}
