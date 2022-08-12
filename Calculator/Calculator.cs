using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
        public string? Operator { get; set; }

        public double CalculateSquareRoot()
        {
            return Math.Sqrt(Number1);
        }
     
        public double Calculate()
        {
            switch (Operator)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Math.Round((Number1 * Number2), 2);
                    break;
                case "/":
                    Result = Math.Round((Number1 / Number2), 2);
                    break;
                case "^":
                    Result = Math.Pow(Number1, Number2);
                    break;
            }
            return Result;                
        }
    }
}
