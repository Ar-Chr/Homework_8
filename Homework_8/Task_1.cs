using System;
using System.Collections.Generic;

namespace Homework_8
{
    internal static class Task_1
    {
        private static Random random = new Random();

        public static void Run()
        {
            List<int> list = GenerateRandomList(100, 0, 100);
            Console.WriteLine("Изначальный список:");
            PrintList(list);

            RemoveBetween(list, 25, 50);
            Console.WriteLine();
            Console.WriteLine("После удаления:");
            PrintList(list);
        }

        private static List<int> GenerateRandomList(int count, int min, int max)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < count; i++)
                result.Add(random.Next(min, max + 1));

            return result;
        }

        private static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ", ");
            }
            Console.WriteLine();
        }

        private static void RemoveBetween(List<int> list, int min, int max)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > min && list[i] < max)
                    list.RemoveAt(i);
            }
        }
    }
}

