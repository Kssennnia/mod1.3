using System;

namespace модуль_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод числителя и знаменателя с клавиатуры
            Console.Write("Введите числитель (неотрицательное целое число): ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель (положительное целое число): ");
            int denominator = int.Parse(Console.ReadLine());
            // Проверка корректности знаменателя
            if (denominator <= 0)
            {
                Console.WriteLine("Ошибка: знаменатель должен быть положительным числом.");
                return;
            }
            // Вычисление НОД числителя и знаменателя
            int gcd = GreatestCommonDivisor(numerator, denominator);
            // Сокращение дроби
            numerator /= gcd;
            denominator /= gcd;
            // Вывод сокращенной дроби
            Console.WriteLine($"Сокращенная дробь: {numerator}/{denominator}");
        }
        // Статический метод для нахождения НОД (наибольшего общего делителя) двух чисел
        static int GreatestCommonDivisor(int a, int b)
        {
            // Использование алгоритма Евклида для нахождения НОД
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}