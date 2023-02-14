using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到1A2B遊戲");

            while (true)
            {
                int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int temp;
                Random random = new Random();

                for (int i = 0; i < numbers.Length; i++)
                {
                    int r = random.Next(numbers.Length);
                    temp = numbers[i];
                    numbers[i] = numbers[r];
                    numbers[r] = temp;
                }

                //12345

                //Console.WriteLine($"{numbers[0]}{numbers[1]}{numbers[2]}{numbers[3]}");

                while (true)
                {
                    int[] sul = new int[4];
                    int a = 0, b = 0, n = 0;

                    Console.WriteLine("請輸入猜測的數字");
                    foreach (char c in Console.ReadLine())
                    {
                        sul[n] = Convert.ToInt32(c.ToString());
                        n++;
                    }

                    for (int i = 0; i < sul.Length; i++)
                    {
                        for (int j = 0; j < sul.Length; j++)
                        {
                            if (numbers[i] == sul[j])
                            {
                                if (i == j)
                                {
                                    a++;
                                }
                                else
                                {
                                    b++;
                                }
                            }
                        }
                    }

                    Console.WriteLine(a + "A" + b + "B");
                    if (a == 4)
                    {
                        Console.WriteLine("正確答案");
                        break;
                    }
                }

                Console.WriteLine("是否再次進行遊戲(y/n)");
                if(Console.ReadLine() == "n")
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
