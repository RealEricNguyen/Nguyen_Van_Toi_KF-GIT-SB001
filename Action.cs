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
        public const int before = 0;
        public const int after = 1;
        public void input()
        {
            Console.Write("PLEASE INPUT AMOUNT: ");
            amount = Int32.Parse(Console.ReadLine());
            arr = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                int x;
                do
                {
                    Console.Write($"PLEASE INPUT NUMBER {i}: ");
                    x = Int32.Parse(Console.ReadLine());
                    if (x < 0 || x > 9)
                    {
                        Console.WriteLine("(0 <= value <= 9) Please input again!!");
                    }else
                    {
                        break;
                    }
                } while (true);
                arr[i] = x;
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
            Console.WriteLine(" WELCOME TO MY APP\n");
            Console.ResetColor();
            Console.WriteLine("PLEASE CHOOSE FEATURES:\n");
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
            show(arr_temp);
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
                    show(arr);
                    Thread.Sleep(1000);
                }
                if (haveSwap = false)
                {
                    break;
                }
                show(arr);
                Thread.Sleep(1000);
            }
            Console.WriteLine("SORT COMPLETE!!! PLEASE [ESC]");
            Console.ReadKey();
        }
        public void show(int[] x)
        {
            int pos = 0;
            if (x == arr_temp)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("ARRAY BEFORE SORT: ");
                pos = 1;
            }
            else if (x == arr)
            {
                Console.SetCursorPosition(0,4);
                Console.Write("ARRAY AFTER SORT:  ");
                pos = 5;
            }
            for (int i = 0; i < amount; i++)
            {
                if (i == (amount -1))
                {
                    Console.WriteLine("+---+");
                }else
                {
                    Console.Write("+---");
                }
            }
            Console.WriteLine();
            Console.SetCursorPosition(19,pos);
            for (int i = 0; i < amount; i++)
            {
                if (i == (amount - 1))
                {
                    Console.Write("| ");
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.Write($"{x[i]}");
                    Console.ResetColor();
                    Console.Write(" |");
                }
                else
                {
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{x[i]}");
                    Console.ResetColor();
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
            Console.SetCursorPosition(19, (pos+1));
            for (int i = 0; i < amount; i++)
            {
                if (i == (amount - 1))
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
