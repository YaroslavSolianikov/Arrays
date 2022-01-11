using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран все элементы массива.
/// </summary>
namespace Arrays_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the elemetnt");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            foreach (var item in array)
            {
                Console.Write($"{item} \t");
            }
            Console.ReadKey();
        }
    }
}

