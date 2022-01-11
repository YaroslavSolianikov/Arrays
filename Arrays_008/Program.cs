using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создайте метод, который будет выполнять увеличение длины массива переданного в качестве аргумента, на 1 элемент.
/// Метод, должен принимает два аргумента, первый аргумент - типа int[] array, второй аргумент - типа int value.
/// В теле метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0, при этом длина нового массива, должна увеличиться на 1 элемент,
/// а элементы получаемого массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.
/// </summary>
namespace Arrays_008
{
    class Program
    {
        delegate int[] ArrOperation(ref int[] array, int value);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the element");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEnter the value");
            int value = int.Parse(Console.ReadLine());
            OurResize(ref array, value);
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write($"{item} \t");
            }
            Console.ReadKey();
        }
        static ArrOperation OurResize = (ref int[] array, int value) =>
        {
            int[] anotherArr = new int[array.Length + 1];
            anotherArr[0] = value;
            Array.Copy(array, 0, anotherArr, 1, array.Length); //1 variant 

            //for (int i = 0; i < anotherArr.Length && i < array.Length; i++) 2 variant
            //{
            //    anotherArr[i] = array[i];
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    anotherArr[0] = value;
            //    anotherArr[i + 1] = array[i];
            //}
            array = anotherArr;
            return array;
        };
    }
}
