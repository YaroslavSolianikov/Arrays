using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создайте метод, который в качестве параметра принимает слово, а возвращает тоже слово,
/// но с измененным порядком букв в слове на обратный.
/// </summary>
namespace Arrays_004
{
    class Program
    {
        delegate string Reverse(ref string s);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
            string s = Convert.ToString(Console.ReadLine());
            s = ReverseWord(ref s);
            Console.WriteLine($"{s}  {s.GetType()}");           
            //Console.WriteLine(ReverseWord(ref s));
            Console.ReadKey();
        }
        static Reverse ReverseWord = (ref string s) =>
        {
            char temp;
            char[] a = s.ToCharArray();
            int size = a.Length;
            int mid = size / 2;
            for (int i = 0; i < mid; i++)
            {
                temp = a[i];
                a[i] = a[size - i - 1];
                a[size - i - 1] = temp;
            }
            string res = new string(a);
            //Console.WriteLine(res.GetType());
            return res;
        };
    }
}
