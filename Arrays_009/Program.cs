using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создайте массив целых чисел размерности 10х10 и заполните его случайными элементами.
/// Выведете на консоль полученный массив. Найдите суммы элементов каждой строки, произведения элементов каждого столбца,
/// и максимальный элемент главной диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца). 
/// </summary>
namespace Arrays_009
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] array = { { 1, 3, 4, 5 }, { 1, 2, 3, 4 } , { 1, 3, 4, 5 }, { 1, 2, 3, 4 } } ;
            int[,] array = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = random.Next(10);
                }

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {                   
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int max = array[0, 0];
            for (int i = 0; i < 10; i++)
            {
                int sum = 0;
                int mult = 1;
                for (int j = 0; j < 10; j++)
                {
                    sum += array[i,j];
                    mult *= array[j, i];
                    Console.Write(array[i, j] + " ");
                    if (j == i)
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                        }
                    }
                }
                Console.WriteLine($"sum of string = {sum} mult of column = {mult} ");
                Console.WriteLine(); 
            }
            Console.WriteLine($"max element of diagonal {max}");
            Console.ReadKey();
        }
    }
}
