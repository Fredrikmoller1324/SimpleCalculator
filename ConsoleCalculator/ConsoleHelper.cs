using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public static class ConsoleHelper
    {
        public static void AdditionToConsole(params float[] numbers)
        {
            Console.WriteLine("Addition");
            //Testing Additon (Done)
            #region Addition method
            MathSolutions addition = new MathSolutions();
            Console.WriteLine($"Sum: {addition.Addition(numbers)}");
            #endregion
        }

        public static void SubsctrationToConsole(params float[] numbers)
        {
            Console.WriteLine("Substraction");
            //Testing Substracting (Done)
            #region Substract method
            MathSolutions Substract = new MathSolutions();
            Console.WriteLine($"Difference: {Substract.Substraction(numbers)}");
            #endregion
        }

        public static void MultiplicationToConsole(params float[] numbers)
        {
            Console.WriteLine("Multiplication");
            //Testing Multiplication (Done)
            #region Multiplication method
            MathSolutions product = new MathSolutions();
            Console.WriteLine($"Product: {product.Multiplication(numbers)}");
            #endregion
        }

        public static void DivisionToConsole(params float[] numbers)
        {
            Console.WriteLine("Division");
            //Testing Division (Done)
            #region Division
            MathSolutions divisions = new MathSolutions();
            Console.WriteLine($"Dividend: {divisions.Division(numbers)}");
            #endregion
        }
    }
}
