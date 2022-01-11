using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создайте два строковых массива с именами A и B (размерностью 4 элемента). Массив A заполняется в цикле пользователем.
/// Получить результирующий массив B, обратный к исходному массиву A (элементы массива B идут в обратном порядке по отношению к массиву A).
/// </summary>
namespace Arrays_003
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[4];
            string[] b = new string[4];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter the element");
                a[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine();
            //for (int i = b.Length-1; i >=0; i--)
            //{
            //    b[i] = a[i];
            //    Console.Write($"{b[i]} \t");
            //}
            int size = a.Length;
            int mid = size / 2;
            string temp;
            for (int i = 0; i < mid; i++)
            {
                temp = a[i];
                a[i] = a[size - i - 1];
                a[size - i - 1] = temp;
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i];
                Console.Write($"{b[i]} \t");
            }
            //Console.WriteLine();
            //foreach (var item in b)
            //{
            //    Console.Write($"{item} \t");
            //}
            Console.ReadKey();
        }
    }
}
