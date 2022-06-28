using System;
using System.Collections.Generic;

namespace Homework_8
{
    internal static class Task_3
    {
        public static void Run()
        {
            HashSet<int> set = new HashSet<int>();
            Console.WriteLine("Введите число");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Введено не число");
                    continue;
                }

                if (set.Contains(number))
                {
                    Console.WriteLine("Число уже было введено");
                    continue;
                }
                
                set.Add(number);
                Console.WriteLine("Число успешно добавлено");
            }
        }
    }
}
