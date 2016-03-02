namespace _03CalculateArithmeticExpression
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class CalculateArithmeticExpression
    {
        private static readonly Dictionary<string, int> OperatorPriority = new Dictionary<string, int>();

        private static readonly Dictionary<string, AssociativityType> OperatorAssociativity = new Dictionary<string, AssociativityType>();

        public static void Main(string[] args)
        {
            OperatorPriority.Add("(", 1);
            OperatorPriority.Add("+", 2);
            OperatorPriority.Add("-", 2);
            OperatorPriority.Add("*", 3);
            OperatorPriority.Add("/", 3);
            OperatorPriority.Add("pow", 4);
            OperatorPriority.Add("sqrt", 4);
            OperatorPriority.Add("++", 5);
            OperatorPriority.Add("--", 5);

            // not needed currently but if right associative operators are added will be needed
            OperatorAssociativity.Add("+", AssociativityType.Left);
            OperatorAssociativity.Add("*", AssociativityType.Left);
            OperatorAssociativity.Add("/", AssociativityType.Left);
            OperatorAssociativity.Add("-", AssociativityType.Left);

            string expression = Console.ReadLine();

            string pattern = @"(\-\-(?=\d+)|\+\+(?=\d+)|\(|\)|\-?\d+\.*\d*|\*|\/|\-|\+|pow|sqrt)";

            var parameters = Regex.Matches(expression, pattern).Cast<Match>().Select(x => x.Groups[0].Value).ToArray();

            try
            {
                var output = ConvertIntoRpn(parameters);
                var result = CalculateRpn(output);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect expression");
            }
        }

        private static Queue<string> ConvertIntoRpn(string[] parameters)
        {
            // create reverse polish notation out of the parameters
            Stack<string> operators = new Stack<string>();

            Queue<string> output = new Queue<string>();

            for (int i = 0; i < parameters.Length; i++)
            {
                double number;
                if (double.TryParse(parameters[i], out number))
                {
                    output.Enqueue(parameters[i]);
                }
                else if (parameters[i] == ",")
                {
                    while (operators.Peek() != "(")
                    {
                        output.Enqueue(operators.Pop());
                    }
                }
                else if (parameters[i] == "(")
                {
                    operators.Push(parameters[i]);
                }
                else if (parameters[i] == ")")
                {
                    while (operators.Peek() != "(")
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Pop();
                }
                else
                {
                    while (operators.Count > 0 && OperatorPriority[parameters[i]] <= OperatorPriority[operators.Peek()])
                    {
                        output.Enqueue(operators.Pop());
                    }

                    operators.Push(parameters[i]);
                }
            }

            while (operators.Count > 0)
            {
                output.Enqueue(operators.Pop());
            }

            return output;
        }

        private static string CalculateRpn(Queue<string> output)
        {
            // calculate reverse polish notation
            Stack<double> operands = new Stack<double>();
            while (output.Count > 0)
            {
                var next = output.Dequeue();
                double number;
                if (double.TryParse(next, out number))
                {
                    operands.Push(number);
                }
                else if (next == "+" || next == "-" || next == "*" || next == "/" || next == "pow")
                {
                    var operand2 = operands.Pop();
                    var operand1 = operands.Pop();
                    operands.Push(CalculateOperationWithTwoOperands(operand1, operand2, next));
                }
                else
                {
                    var operand = operands.Pop();
                    operands.Push(CalculateOperationWithOneOperand(operand, next));
                }
            }

            if (operands.Count > 1)
            {
                throw new ArithmeticException("Incorrect amount of parameters or operands!");
            }

            return operands.Pop().ToString();
        }

        private static double CalculateOperationWithTwoOperands(double operand1, double operand2, string operatorType)
        {
            switch (operatorType)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return operand1 / operand2;
                case "pow":
                    return Math.Pow(operand1, operand2);
                default:
                    throw new NotImplementedException();
            }
        }

        private static double CalculateOperationWithOneOperand(double operand, string operatorType)
        {
            switch (operatorType)
            {
                case "++":
                    return ++operand;
                case "--":
                    return --operand;
                case "sqrt":
                    return Math.Sqrt(operand);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
