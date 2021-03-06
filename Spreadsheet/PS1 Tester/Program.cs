﻿using FormulaEvaluator;
using System;
using System.Data;

/*
 * This is just a tester to be able to try out my arithmetic code.  Involves a refernce picker for variables of varying types
 */
namespace PS1_Tester
{
    class Program
    { 
        static void Main(string[] args)
        {
            String formula = " (4*8)*(7-3)/(7+5)+(8/2)*(3-2)+(4*3)";
            Console.WriteLine(Evaluator.Evaluate(formula, fieldFinder.referencePicker));
            Console.ReadLine();
        }
    }

    class fieldFinder
    {
        public static int referencePicker(String k)
        {
            if (k == "A9")
                return 36;
            if (k == "AA9")
                return 69;
            if (k == "A96")
                return 5;
            if (k == "AB12")
                return 10;
            return -400;
        }
    }
}
