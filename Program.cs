using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static int index = 0;
        static Features ft = new Features();
        static ConsoleKeyInfo key;
        static int pos_x = 2, pos_y = 4;
        static Action act = new Action();
        static bool exit = true;
        static void Main(string[] args)
        {
            act.title();
            do
            {
                ft.background();
                Console.SetCursorPosition(4, 7);
                ft.print_Features(index, pos_x, pos_y);
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index >= 5)
                        {
                            index = 5;
                        }
                        else
                        {
                            pos_y += 3;
                            index++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (index <= 0)
                        {
                            index = 0;
                        }
                        else
                        {
                            pos_y -= 3;
                            index--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (index == 0)
                        {
                            act.input();
                            Console.Clear();
                            act.title();
                        }
                        else if(index == 1)
                        {
                            if (act.arr != null)
                            {
                                act.sort_increase();
                            }
                            else
                            {
                                Console.Write("YOU NEED INPUT VALUE FIRST!!! PLEASE [ESC]");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            act.title();
                        }
                        else if(index == 2)
                        {
                            if (act.arr != null)
                            {
                                act.sort_decrease();
                            }
                            else
                            {
                                Console.Write("YOU NEED INPUT VALUE FIRST!!! PLEASE [ESC]");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            act.title();
                        }
                        else if (index == 3)
                        {
                            if (act.arr != null)
                            {
                                act.show(act.arr_temp,0,act.amount);
                                act.show(act.arr, 1,act.amount);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("YOU NEED INPUT VALUE FIRST!!! PLEASE [ESC]");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            act.title();
                        }
                        else if (index == 4)
                        {
                            if (act.arr != null)
                            {
                                act.demo();
                            }
                            else
                            {
                                Console.Write("YOU NEED INPUT VALUE FIRST!!! PLEASE [ESC]");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            act.title();
                        }
                        else if (index == 5)
                        {
                            exit = false;
                        }
                        break;
                    default:
                        break;
                }
            } while (exit);
        }
    }
}
