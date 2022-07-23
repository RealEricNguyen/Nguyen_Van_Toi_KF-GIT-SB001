using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Features
    {
        private char[,] FEATURES_INPUT =
                                        {
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                            {' ',' ','I','N','P','U','T',' ','A','R','R','A','Y',' ',' '},
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                        };
        private char[,] FEATURES_SORT_INCREASE =
                                        {
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                            {' ','S','O','R','T',' ','I','N','C','R','E','A','S','E',' '},
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                        };
        private char[,] FEATURES_SORT_DECREASE =
                                        {
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                            {' ','S','O','R','T',' ','D','E','C','R','E','A','S','E',' '},
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                        };
        private char[,] FEATURES_SHOW =
                                        {
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                            {' ',' ','S','H','O','W',' ',' ','A','R','R','A','Y',' ',' '},
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                        };
        private char[,] FEATURES_DEMO =
                                        {
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                            {' ',' ',' ',' ',' ','D','E','M','O',' ',' ',' ',' ',' ',' '},
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                        };
        private char[,] FEATURES_EXIT =
                                        {
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                            {' ',' ',' ',' ',' ','E','X','I','T',' ',' ',' ',' ',' ',' '},
                                            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                        };
        private int n = 3, m = 15;
        //------------------------------------------------------
        public void print_Features(int index, int x, int y)
        {
            char[,] board_temp;
            switch (index)
            {
                case 0:
                    board_temp = FEATURES_INPUT;
                    break;
                case 1:
                    board_temp = FEATURES_SORT_INCREASE;
                    break;
                case 2:
                    board_temp = FEATURES_SORT_DECREASE;
                    break;
                case 3:
                    board_temp = FEATURES_SHOW;
                    break;
                case 4:
                    board_temp = FEATURES_DEMO;
                    break;
                case 5:
                    board_temp = FEATURES_EXIT;
                    break;
                default:
                    board_temp = null;
                    break;
            }
            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < m; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(board_temp[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine("");
                y++;
            }
        }
        public void background()
        {
            int y = 4;
            for (int k = 0; k < 6; k++)
            {
                char[,] board_bg;
                switch (k)
                {
                    case 0:
                        board_bg = FEATURES_INPUT;
                        break;
                    case 1:
                        board_bg = FEATURES_SORT_INCREASE;
                        break;
                    case 2:
                        board_bg = FEATURES_SORT_DECREASE;
                        break;
                    case 3:
                        board_bg = FEATURES_SHOW;
                        break;
                    case 4:
                        board_bg = FEATURES_DEMO;
                        break;
                    case 5:
                        board_bg = FEATURES_EXIT;
                        break;
                    default:
                        board_bg = null;
                        break;
                }
                for (int i = 0; i < n; i++)
                {
                    Console.SetCursorPosition(2, y);
                    for (int j = 0; j < m; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(board_bg[i, j]);
                        Console.ResetColor();
                    }
                    Console.WriteLine("");
                    y++;
                }
            }
        }
    }
}
