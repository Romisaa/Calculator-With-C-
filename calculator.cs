using System;
using System.Collections.Generic;

namespace MyCalculatorConsoleApp
{
    public class calculator
    {
        public double FirstNum {get; set;}
        public double SecondNum {get; set;}
        public double Answer {get; private set;}
        public string Operators{get; set;}
        public List<string> History {get;} 

        public calculator()
        {
            History = new List<string>();
        }
        public double Calculate()
        {
            if (Operators == "+")
            {
                Answer = addNumbers();
                History.Add($"{FirstNum} + {SecondNum} = {Answer}");
            }
            else if (Operators == "-")
            {
                Answer = subtractNumbers();
                History.Add($"{FirstNum} + {SecondNum} = {Answer}");

            }
            else if (Operators == "*")
            {
                Answer = multiNumbers();
                History.Add($"{FirstNum} + {SecondNum} = {Answer}");

            }
            else if (Operators == "/")
            {
                    Answer = divideNumbers();
                    History.Add($"{FirstNum} + {SecondNum} = {Answer}");
                
            }
            else if (Operators == "^")
            {
                Answer = squareNumbers();
                History.Add($"{FirstNum} + {SecondNum} = {Answer}");

            }
            return Answer;

        }

        private double addNumbers()
        {
            return FirstNum + SecondNum;
        }
        private double subtractNumbers()
        {
            return FirstNum - SecondNum;
        }
        private double multiNumbers()
        {
            return FirstNum * SecondNum;
        }
        private double divideNumbers()
        {
            if (SecondNum == 0)
            {
                throw new DivideByZeroException();
            }
            return FirstNum / SecondNum;
        }
        private double squareNumbers()
        {
            return FirstNum * FirstNum;
        }

    }
    
}
