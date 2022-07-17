using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static int index = 1;
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
                        if (index >= 4)
                        {
                            index = 4;
                        }
                        else
                        {
                            pos_y += 3;
                            index++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (index <= 1)
                        {
                            index = 1;
                        }
                        else
                        {
                            pos_y -= 3;
                            index--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (index == 1)
                        {
                            act.input();
                            Console.Clear();
                            act.title();
                        }
                        else if (index == 2)
                        {
                            if (act.arr != null)
                            {
                                act.sort();
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
                                act.show();
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
