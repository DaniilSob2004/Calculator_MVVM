using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson5
{
    public class Calculator
    {
        public int RightOperand { get; set; }
        public int LeftOperand { get; set; }
        public string Operator { get; set; }

        public int Total
        {
            get
            {
                switch (Operator)
                {
                    case "+": return LeftOperand + RightOperand;
                    case "-": return LeftOperand - RightOperand;
                    case "*": return LeftOperand * RightOperand;
                    case "/":
                        if (RightOperand != 0)
                            return LeftOperand / RightOperand;
                        return -1;
                }
                return -1;
            }
        }
    }
}
