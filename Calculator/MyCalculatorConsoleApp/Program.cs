using System;
using System.Collections.Generic;


namespace MyCalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tConsole Calculator\n");
            bool restart = false;
            calculator Mycalculator = new calculator();

    do{
            Console.WriteLine("Enter Your First Number: ");
            double firstnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Select An Operator: {+ , - , * , /, ^}");
            string operators = Console.ReadLine();
            double secondnum = 1;

            if (operators != "^")
            {
                Console.WriteLine("Enter Your Second Number: ");
                secondnum = Double.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");

            }

            
            Mycalculator.FirstNum = firstnum;
            Mycalculator.SecondNum = secondnum;
            Mycalculator.Operators = operators;
            try
            {
                Mycalculator.Calculate();
                Console.WriteLine(Mycalculator.Answer);
            }
            catch(DivideByZeroException e )
            {
                Console.WriteLine("Sorry , Can Not divide by Zero");
            }
            Console.WriteLine("Want your calcualtion history? Press h");
            Console.WriteLine("Want To Continue ? Y / N");
             string decision = Console.ReadLine();
             switch(decision.ToLower())
             {
                case "y":
                restart = true;
                break;
                case "h":
                foreach(var hist in Mycalculator.History)
                {
                    Console.WriteLine(hist);
                }
                break;
                default :
                restart = false;
                break;
             }

    }while(restart);
            

            Console.ReadKey();
        }
    }
}
