using System;

namespace MyLibrary
{
    public class MyMethods
    {
        // --- 2 метода с типом void ---
        public void SayHello()
        {
            Console.WriteLine("Привет! Это метод из DLL.");
        }

        public void PrintSum(int a, int b)
        {
            Console.WriteLine($"Сумма {a} и {b} = {a + b}");
        }

        // --- 3 метода с возвращаемыми значениями разных типов ---
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public string GetGreeting(string name)
        {
            return $"Привет, {name}!";
        }
    }
}