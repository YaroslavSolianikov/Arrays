using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создает метод, который в качестве аргументов принимает: 1)целочисленный массив(int [] array), 2)целочисленный индекс(int index),
/// 3)количество элементов (int count), возвращает целочисленный массив элементов(int [] subArray).
/// Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index,
/// размерностью, которая соответствует значению аргумента count.
/// </summary>
namespace Arrays_007
{
    class Program
    {
        delegate int[] ArrOperation(int[] array, int index, int count);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the index");
            int index = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            int [] subArray = Arr(array, index, count);
            foreach (var item in subArray)
            {
                Console.Write($"{item} \t");
            }
            Console.ReadKey();
        }
        static ArrOperation Arr = (array,index,count) =>
        {
            int[] subArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the element");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = index; i < subArray.Length;  i++)
            {
                subArray[i] = array[i];
            }
            subArray = subArray.Where(x => x != 0).ToArray();
            

            //int size = subArray.Length;
            //int mid = size / 2;
            //int temp;
            //for (int i = 0; i < mid; i++)
            //{
            //    temp = subArray[i];
            //    subArray[i] = subArray[size - i - 1];
            //    subArray[size - i - 1] = temp;
            //}
            //Array.Resize(ref subArray, count-index);

            //int size1 = subArray.Length;
            //int mid1 = size1 / 2;
            //int temp1;
            //for (int i = 0; i < mid1; i++)
            //{
            //    temp1 = subArray[i];
            //    subArray[i] = subArray[size1 - i - 1];
            //    subArray[size1 - i - 1] = temp1;
            //}
            Console.WriteLine("\nOur subArray\n");
            return subArray;
        };
    }
}
