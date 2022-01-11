using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран все элементы массива в обратном порядке.
/// </summary>
namespace Arrays_002
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
            for (int i = (array.Length - 1); i >= 0; i--)
            {
                Console.Write($"{array[i]} \t");
            }
            //int size = array.Length;
            //int mid = size / 2;
            //int temp;
            //for (int i = 0; i < mid; i++)
            //{
            //    temp = array[i];
            //    array[i] = array[size - i - 1];
            //    array[size - i - 1] = temp;
            //}

            //foreach (var item in array)
            //{
            //    Console.Write($"{item} \t");
            //}
            Console.ReadKey();
            
        }
    }
}
