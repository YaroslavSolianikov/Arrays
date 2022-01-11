using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев. После чего пользователь вводит диапазон (например, 3 и 6 – поиск между 3-м и 6-м месяцем).
/// Необходимо определить месяц, в котором прибыль была максимальна и месяц, в котором прибыль была минимальна с учетом выбранного диапазона.
/// </summary>
namespace Arrays_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[12];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the profit for {i+1} month");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEnter the range");
            int r1 = int.Parse(Console.ReadLine());
            int r2 = int.Parse(Console.ReadLine());
            int min = 0; //= arr[0];
            int max = 0; //= arr[0];
            for (int i = r1-1; i < r2; i++)
            {
                Console.WriteLine(arr[i]);
                if (i == r1 - 1)
                {
                    max = arr[i];
                    min = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"\nMin result {min}");
            Console.WriteLine($"Max result {max}");
            Console.ReadKey();
        }		

    }
}
