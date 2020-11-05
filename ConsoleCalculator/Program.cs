using CalculatorLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add an expression: (this version of calculator can only take one operator a time):");
            string testerAdd = Console.ReadLine();

            if (testerAdd.Contains('+'))
            {
                string[] convertedString = testerAdd.Split('+');
                if (convertedString[0] == "") { convertedString[0] = "0"; }
                ConsoleHelper.AdditionToConsole(MathSolutions.AddingFloatsToList(convertedString));
            }

            if (testerAdd.Contains('-'))
            {
                string[] convertedString = testerAdd.Split('-');
                if (convertedString[0] == "") { convertedString[0] = "0"; }
                ConsoleHelper.SubsctrationToConsole(MathSolutions.AddingFloatsToList(convertedString));
            }

            if (testerAdd.Contains('*'))
            {
                string[] convertedString = testerAdd.Split('*');
                if (convertedString[0] == "") { convertedString[0] = "0"; }
                ConsoleHelper.MultiplicationToConsole(MathSolutions.AddingFloatsToList(convertedString));
            }

            if (testerAdd.Contains('/'))
            {
                string[] convertedString = testerAdd.Split('/');
                if (convertedString[0] == "") { convertedString[0] = "0"; }
                ConsoleHelper.DivisionToConsole(MathSolutions.AddingFloatsToList(convertedString));
            }
        }
        
    }
}
