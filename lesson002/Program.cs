using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите количество цифр (от 3 до 7): ");
                int a = int.Parse(Console.ReadLine());
                int[] ints;
                if (a == 3)
                {
                    ints = new int[] { 1, 2, 3 };
                    Console.WriteLine((ints[0] + ints[1] + ints[2])/a);
                }
                else if (a == 4)
                {
                    ints = new int[] { 1, 2, 3, 4 };
                    Console.WriteLine((ints[0] + ints[1] + ints[2] + ints[3])/a);
                }
                else if (a == 5)
                {
                    ints = new int[] { 1, 2, 3, 4, 5 };
                    Console.WriteLine((ints[0] + ints[1] + ints[2] + ints[3] + ints[4])/a);
                }
                else if (a == 6)
                {
                    ints = new int[] { 1, 2, 3, 4, 5, 6 };
                    Console.WriteLine((ints[0] + ints[1] + ints[2] + ints[3] + ints[4] + ints[5])/a);
                }
                else if (a == 7)
                {
                    ints = new int[] { 1, 2, 3, 4, 5, 6, 7 };
                    Console.WriteLine((ints[0] + ints[1] + ints[2] + ints[3] + ints[4] + ints[5] + ints[6])/a);
                }
                else
                    Console.WriteLine("Введено неверное количество цифр. Пожалуйста перезапустите программу и попробуйте снова");
            }
            catch
            {
                Console.WriteLine("Пожалуйста, вводите только 1 число от 3 до 7");
            }
        }
    }
}
