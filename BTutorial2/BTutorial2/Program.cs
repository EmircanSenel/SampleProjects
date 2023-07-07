using System;

namespace BTutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
           int size = 10;
            int row = 0;
            //karma
            while (row < size)
            {
                if (row == 0 || row == size - 1)
                {
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int a = 0; a < (size * 2) - 3; a++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
                row++;
            }
            //while
            /*
            int i = 0;
            while (row < size)
            {
                if (row == 0 || row == size - 1)
                {
                    while (i < size)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                        i++;
                    }
                }
                else
                {
                    i = 0;
                    Console.Write("*");
                    while(i < (size * 2) - 3)
                    {
                        Console.Write(" ");
                        i++;
                    }
                    Console.Write("*");
                    i = 0;
                }
                Console.WriteLine();
                row++;
            }*/

        }
    }
}
