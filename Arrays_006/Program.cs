using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создайте массив размера N элементов (размер массива задет пользователь), заполнить его произвольными целыми значениями.
/// Вывести на экран: наибольшее значение массива,
/// наименьшее значение массива, общую сумму всех элементов, среднее арифметическое всех элементов, вывести все нечетные значения. 
/// </summary>
namespace Arrays_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elemetns");
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nOur array\n");            
            foreach (var item in array)
            {
                Console.Write($"{item} \t");
            }
            int min = array[0];
            int max = array[0];
            int sum = 0;
            int average = 0;
            Console.WriteLine("\n\nAll odd elements\n");
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
                sum += array[i];
                average = sum / N;
                if(array[i]%2 != 0)
                {
                    Console.Write($"{array[i]} \t");
                }
            }
            Console.WriteLine($"\n\nMin element = {min}");
            Console.WriteLine($"Max element = {max}");
            Console.WriteLine($"Sum of all elements = {sum}");
            Console.WriteLine($"Average of elements = {average}");
            Console.ReadKey();
        }
    }
}
