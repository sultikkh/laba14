using System;


namespace CodProgrammy
{
    class Program
    {
        static int SumOfDigits(int number) //Метод для вычисления суммы цифр числа
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static void Main(string[] args) //Главный метод программы
        {
            int n, maxNumber = 0, maxSum = 0;
            Console.Write("Введите количество чисел: ");
            n = int.Parse(Console.ReadLine()); //Ввод количества чисел
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите натуральное число: ");
                int number = int.Parse(Console.ReadLine()); //Ввод числа
                int sumOfDigits = SumOfDigits(number); //Вычисление суммы цифр числа
                if (sumOfDigits > maxSum) //Проверка на максимальность суммы цифр
                {
                    maxSum = sumOfDigits;
                    maxNumber = number;
                }
            }
            Console.WriteLine($"Число с наибольшей суммой цифр: {maxNumber}, сумма цифр: {maxSum}");
            Console.ReadKey(); //Чтобы окно консоли не закрылось сразу
        }
    }
}

