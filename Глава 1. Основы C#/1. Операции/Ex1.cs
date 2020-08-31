using System;

namespace ConsoleApp1
{
    class Program
    {
        // Есть следующий код:
        // int n1 = 2;
        // int n2 = 5;
        // int result = n2 * 3 + 20 / 2 * n1--;
        // Используя приоритеты операций, разложите выражение int result = n2 * 3 + 20 / 2 * n1-- по шагам.
        // int yourResult = ?
        static void Main(string[] args)
        {
            int n1 = 2;
            int n2 = 5;
            int result = n2 * 3 + 20 / 2 * n1--;

            //Бинарные арифметические операторы имеют левую ассоциативность. То есть операторы с одинаковым приоритетом вычисляются в направлении слева направо.
            int r1 = 2;
            int r2 = 5;

            int a = r1--;   // 2
            int b = r2 * 3; //15
            int c = 20 / 2;     // 10
            int d = c * a;      // 20
            int yourResult = b + d; // 35

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
