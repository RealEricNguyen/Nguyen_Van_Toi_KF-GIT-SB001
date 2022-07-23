using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Action
    {
        public int amount;
        public int[] arr;
        public int[] arr_temp;
        public void input()
        {
            Console.Write("PLEASE INPUT AMOUNT: ");
            amount = Int32.Parse(Console.ReadLine());
            arr = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.Write($"PLEASE INPUT NUMBER {i}: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            arr_temp = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                arr_temp[i] = arr[i];
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
        private void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public void sort_increase()
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
                        swap(ref arr[j],ref arr[j + 1]);
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
        public void sort_decrease()
        {
            int i, j;
            bool haveSwap = false;
            for (i = 0; i < amount - 1; i++)
            {
                haveSwap = false;
                for (j = 0; j < amount - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        swap(ref arr[j],ref arr[j + 1]);
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
        public void demo()
        {
            show(arr_temp, 0, amount);
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
                show(arr, 1, amount);
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
        public void show(int[] x, int index, int l)
        {
            int pos = 0;
            if (index == 0)
            {
                pos = 1;
                Console.Write("ARRAY BEFORE SORT: ");
            }
            else if (index == 1)
            {
                pos = 5;
                Console.Write("ARRAY AFTER SORT:  ");
            }
            for (int i = 0; i < l; i++)
            {
                if (i == (l-1))
                {
                    Console.WriteLine("+---+");
                }else
                {
                    Console.Write("+---");
                }
            }
            Console.WriteLine();
            Console.SetCursorPosition(19,pos);
            for (int i = 0; i < l; i++)
            {
                if (i == (l - 1))
                {
                    Console.Write($"| {x[i]} |");
                }
                else
                {
                    Console.Write($"| {x[i]} ");
                }
            }
            Console.WriteLine("");
            Console.SetCursorPosition(19, (pos+1));
            for (int i = 0; i < l; i++)
            {
                if (i == (l - 1))
                {
                    Console.WriteLine("+---+");
                }
                else
                {
                    Console.Write("+---");
                }
            }
            Console.WriteLine("");
        }
    }
}
