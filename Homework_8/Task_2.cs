using System;
using System.Collections.Generic;

namespace Homework_8
{
    internal static class Task_2
    {
        private static Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        public static void Run()
        {
            Fill(phoneBook);
            Console.Clear();

            string name;
            while (true)
            {
                if (TryFind(out name))
                    Console.WriteLine(name);
                else
                    Console.WriteLine("Введённый номер не зарегистрирован");
                Console.WriteLine();
            }
        }

        private static void Fill(Dictionary<string, string> phoneBook)
        {
            string number;
            string name;
            while (true)
            {
                Console.WriteLine("Введите номер");
                number = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(number))
                    break;

                Console.WriteLine("Введите ФИО владельца");
                name = Console.ReadLine();

                phoneBook[number] = name;
            }
        }

        private static bool TryFind(out string name)
        {
            Console.WriteLine("Введите номер для поиска");
            string number = Console.ReadLine().Trim();
            if (phoneBook.TryGetValue(number, out name))
                return true;
            return false;
        }
    }
}
