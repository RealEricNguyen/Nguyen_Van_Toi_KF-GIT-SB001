using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Action
    {
        private int amount;
        public int[] arr;
        public void input()
        {
            Console.Write("PLEASE INPUT AMOUNT: ");
            amount = Int32.Parse(Console.ReadLine());
            arr = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"PLEASE INPUT NUMBER {i}: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("INPUT COMPLETE!!! PLEASE [ESC]");
            Console.ReadKey();
        }
        public void title()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t WELCOME TO MY APP\n");
            Console.ResetColor();
            Console.WriteLine("PLEASE CHOSE FEATURES:\n");
        }
        private void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public void sort()
        {
            int i, j;
            bool haveSwap = false;
            for (i = 0; i < amount - 1; i++)
            {
                haveSwap = false;
                for (j = 0; j < amount - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(ref arr[j], ref arr[j + 1]);
                        haveSwap = true;
                    }
                }
                if (haveSwap = false)
                {
                    break;
                }
            }
            Console.WriteLine("SORT COMPLETE!!! PLEASE [ESC]");
            Console.ReadKey();
        }
        public void show()
        {
            Console.Write("ARRAY AFTER SORT: ");
            int i;
            for (i = 0; i < amount; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine("");
            Console.WriteLine("PLEASE [ESC]");
            Console.ReadKey();
        }
    }
}
