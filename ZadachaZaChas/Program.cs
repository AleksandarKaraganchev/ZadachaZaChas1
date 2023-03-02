using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaZaChas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Въведете числа на списъка: ");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            CountPrint(numbers);
            Console.Write("Въведи числа на масив (1): ");
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ArrayToList(numbers, arr1);
            Console.Write("Въведи число и ще ти кажа дали е в масива: ");
            int n = int.Parse(Console.ReadLine());
            NumInList(numbers, n);
            Console.Write("Въведи числа за масив (2): ");
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ArrayToList2(numbers, arr2);
        }
        private static void ArrayToList2(List<int> numbers, int[] arr2)
        {
            numbers.AddRange(arr2);
            numbers.Sort();
            Console.WriteLine($"Масив 2 се добавя в списъка, заедно с масив (1): {string.Join(" ", numbers)}");
        }
        private static void NumInList(List<int> numbers, int n)
        {
            if (numbers.Contains(n))
            {
                n++;
                Console.WriteLine($"Числото {n} е на позиция {numbers.IndexOf(n)} !!!");
            }
            else
            {
                Console.WriteLine($"Числото {n} не се намира в масива!!!");
            }
        }
        private static void ArrayToList(List<int> numbers, int[] arr1)
        {
            numbers.AddRange(arr1);
            numbers.Sort();
            Console.WriteLine($"Масив 2 се добавя към списъка с първия масив {string.Join(", ", numbers)}");
        }
        private static void CountPrint(List<int> numbers)
        {
            Console.WriteLine($"Броя на елементите на списъка са: {numbers.Count}");
        }
    }
}
