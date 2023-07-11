using System;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit;
            double Celsius;
            double result=0;
            int roundResult = 0;
            string ConvertDecider;
            bool ContainsAnswer = false;
            bool Start = true;
            bool a= true;
            while (a) {
                if (Start) {
                    Console.WriteLine("");
                    Console.WriteLine("a)Convert Fahrenheit to Celsius");
                    Console.WriteLine("b)Convert Celsius to Fahrenheit");
                    Console.WriteLine("to choose please enter 'a' or 'b', to exit press 'q'");
                    Start = false;
                    ContainsAnswer = false;
                }
                ConvertDecider = Console.ReadLine();
                if (ConvertDecider == "a") {
                    while (ContainsAnswer==false) {
                        Console.WriteLine("Enter a temperature in Fahrenheit");
                        try
                        {
                            Fahrenheit = Convert.ToDouble(Console.ReadLine());

                            result = (Fahrenheit - 32) / 1.8;
                            roundResult = Convert.ToInt32(Math.Round(result));

                            Console.WriteLine(Fahrenheit + " Fahrenheit is equal to exactly " + result + " and approximately " + roundResult + " Celsius ");
                            ContainsAnswer = true;
                            Start = true;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you should write a Number");
                        }
                    }
                }
                else if (ConvertDecider == "b") {
                    while (ContainsAnswer == false)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Enter a temperature in Celsius");
                        try
                        {
                            Celsius = Convert.ToDouble(Console.ReadLine());

                            result = 32 + (Celsius * 1.8);
                            roundResult = Convert.ToInt32(Math.Round(result));

                            Console.WriteLine("");
                            Console.WriteLine(Celsius + " Celsius is equal to " + result + " and approximately " + roundResult + " Fahrenheit");
                            ContainsAnswer = true;
                            Start = true;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you should write a Number");
                        }
                    }
                }
                else if (ConvertDecider=="q"){
                    Console.WriteLine("");
                    Console.WriteLine("Goodbye");
                    break;
                }
                else{
                    Console.WriteLine("");
                    Console.WriteLine("you need to choose a or b");
                }
            }

        }
    }
}
