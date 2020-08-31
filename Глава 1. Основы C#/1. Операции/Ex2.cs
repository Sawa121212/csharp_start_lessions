using System;

namespace ConsoleApp1
{
    class Program
    {
        // Есть следующий код:
        // int num1 = 4;
        // int num2 = 5;
        // int num3 = 15;
        // int num4 = 10;
        // int num5 = 5;
        // int result = 12;
        //
        // result += num1* num2 + num3 % num4 / num5;
        // Используя приоритеты операций, разложите выражение result += num1* num2 + num3 % num4 / num5 по шагам.
        // int yourResult = ?
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 5;
            int num3 = 15;
            int num4 = 10;
            int num5 = 5;
            int result = 12;

            result += num1 * num2 + num3 % num4 / num5;

            //Бинарные арифметические операторы имеют левую ассоциативность. То есть операторы с одинаковым приоритетом вычисляются в направлении слева направо.
            int mynum1 = 4;
            int mynum2 = 5;
            int mynum3 = 15;
            int mynum4 = 10;
            int mynum5 = 5;
            int yourResult = 12;

            int a = mynum4 / mynum5;    // 2
            int b = mynum3 % a;         // 1
            int c = mynum1 * num2;      // 20
            int d = b + c;              // 21
            yourResult = yourResult + d;// 33
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
