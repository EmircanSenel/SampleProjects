using System;

namespace BTutorial2
{
    class Program
    {
        static void Main(string[] args)
        {/*
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

            //triangle
            Start:
            int hight=0;
            int size = (hight*2)-1;
            int row = 0;
            int a = 3;
            int b = 2;
            Console.WriteLine("Write the hight of triangle");
            try
            {
              hight = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException) { Console.WriteLine("write a number please"); goto Start; }
            size = (hight * 2) - 1;

            //karma
            while (row < (size+1)/2)
            {
                if (row == 0)
                {
                    for (int i = 0; i <= (size - 2); i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int i = 0; i < (size - 1); i++)
                    {
                        Console.Write(" ");
                    }
                }else if(row== (size-1)/2){
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    for (int i=0;i<size-a;i++)
                    {
                        Console.Write(" ");
                        
                    }
                    a = a + 2;
                    Console.Write("*");
                    for (int i = 0; i < (2*b)-1 ; i++)
                    {
                        Console.Write(" ");

                    }
                    b = b + 2;
                    Console.Write("*");

                }
                Console.WriteLine();
                row++;
            }
            goto Start;
        }
    }
}
