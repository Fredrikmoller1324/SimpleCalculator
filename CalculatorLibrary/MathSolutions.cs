using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CalculatorLibrary
{
    public class MathSolutions
    {
        public float Addition(params float[] numbers)
        {
            float sum = 0f;
            if (numbers.Length > 1)
            {
                foreach (float number in numbers)
                {
                    sum += number;

                }
                return sum;
            }
            return 0f;
        }

        public float Substraction(params float[] numbers)
        {
            float difference = numbers[0];
            if(numbers.Length>1)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    difference -= numbers[i];
                }
                return difference;
            }
            return 0f;
        }

        public float Multiplication(params float[] numbers)
        {
            float product = 1f;
            if (numbers.Length > 1)
            {
                foreach (float number in numbers)
                {
                    product *= number;
                }
                return MathF.Round(product,2);
            }
            return 0f;
        }

        public float Division(params float[] numbers)
        {
            if (!numbers.Contains(0))
            {
                float dividend = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    dividend /= numbers[i];
                }
                return MathF.Round(dividend,2);
            }
             throw new DivideByZeroException("Can't divide by 0");
        }

        public static float[] AddingFloatsToList(string[] converted)
        {
            List<float> numbersList = new List<float>();
            foreach (var chars in converted)
            {
                if(chars.Contains('-')|| chars.Contains('*') || chars.Contains('/'))
                {
                    return numbersList.ToArray();

                    //Försök att få in multioperator
                    //string[] substring = chars.Split('-').ToArray();
                    //for (int i = 0; i < substring.Length; i++)
                    //{
                    //    float addThisToo = float.Parse(substring[i].ToString());
                    //    numbersList.Add(addThisToo);
                    //}

                }
                else
                {
                    float addThis = float.Parse(chars.ToString());
                    numbersList.Add(addThis);
                }
                
            }

            return numbersList.ToArray();
        }

        public float AdvancedCalcforWinform(string textFromTextBox)
        {
            Stack<char> oper = new Stack<char>();
            Stack<int> num = new Stack<int>();
            char ch;
            bool err = false;
            // To keep it simple initially only allow 
            // 1 digit expressions with operators + and -
            // and 5 digits 1,2,3,4 and 5
            string text = textFromTextBox; // or use Console.ReadLine
            // Build up stacks from text expression
            char[] chstr = text.ToCharArray();
            for (int i = 0; i < chstr.Length; i++)
            {
                ch = chstr[i];
                if (IsOperator(ch))
                    oper.Push(ch);
                else if (IsNumber(ch)) // or char.IsDigit(ch)                  
                    num.Push(Convert.ToInt32(ch - '0'));
                else if (char.IsWhiteSpace(ch))
                    continue; //omit space,tab etc.
                else
                {
                    err = true;
                    break;
                }
            }

            foreach (int i in num)
                Console.Write(i);
            Console.WriteLine();
            // Calculate result
            if (err)
                Console.WriteLine("*** Error in expression.");
            else
            {
                //Reverse stacks
                oper = new Stack<char>(oper);
                num = new Stack<int>(num);

                int op1, op2;
                int result;
                while (num.Count > 1)
                {
                    op1 = num.Pop();
                    op2 = num.Pop();
                    switch (oper.Pop())
                    {
                        case '+':
                            result = op1 + op2;
                            num.Push(result);
                            break;
                        case '-':
                            result = op1 - op2;
                            num.Push(result);
                            break;
                        default:
                            break;
                    }
                }
            }
            // On the num stack there should be only one number, the final result.
            float finish = num.Pop();
            return finish;
        }
        static bool IsOperator(char ch)
        {
            return ch == '+' || ch == '-';
        }
        static bool IsNumber(char ch)
        {
            return  ch == '0'|| ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7'
                || ch == '8' || ch == '9';
        }
    }
    
}
