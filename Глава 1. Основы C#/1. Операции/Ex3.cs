using System;

namespace ConsoleApp1
{
    class Program
    {
        // Чему будет равна переменная z после выполнения следующего кода и почему?
        // int x = 8;
        // int y = 9;
        // int z = x++ + ++y;
        static void Main(string[] args)
        {
            int x = 8;
            int y = 9;
            int z = x++ + ++y;
            int result = z;

            //Бинарные арифметические операторы имеют левую ассоциативность. То есть операторы с одинаковым приоритетом вычисляются в направлении слева направо.
            int xMY = 8;
            int yMY = 9;
            //int yourResult = xMY++ + ++yMY;

            int a = ++yMY;
            int b = xMY++;
            int c = a + b;
            int yourResult = c;

            // int yourResult = ?

            //Вывод результата
            Console.WriteLine($"--------------------");
            if (result == yourResult)
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.WriteLine("Ответ правильный");
                Console.ResetColor(); // сбрасываем в стандартный
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine("Ответ не правильный");
                Console.ResetColor(); // сбрасываем в стандартный
            }
            Console.WriteLine("Правильный ответ: " + result +"\nВаш ответ: "+ yourResult);
            Console.ReadKey();
        }
    }
}
