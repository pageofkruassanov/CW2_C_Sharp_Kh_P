using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_C_Sharp_Kh_P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Введите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите второе число: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите третье число: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            const int SIZE_ARR = 2000;
            int[] arrOfNum = new int[SIZE_ARR];
            Random rand = new Random();
            for(int i = 0; i < SIZE_ARR; i++) 
            {
                arrOfNum[i] = rand.Next(0, 10);
            }

            int findingNums = 0;
            for (int i = 0; i < SIZE_ARR; i++)
            {
                if (arrOfNum[i] == num1)
                {
                    i++;
                    if (arrOfNum[i] == num2)
                    {
                        i++;
                        if (arrOfNum[i] == num3)
                        {
                            findingNums++;
                        }
                    }
                }
            }
            Console.WriteLine($"Ваши числа {num1} {num2} {num3} встерчаются в массиве {findingNums} раз");
            Console.ReadLine();
        }
    }
}
