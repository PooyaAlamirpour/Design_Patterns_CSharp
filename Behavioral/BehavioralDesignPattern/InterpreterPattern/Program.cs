using System;
using System.Collections.Generic;
using InterpreterPattern.AbstractExpressions;
using InterpreterPattern.Contexts;
using InterpreterPattern.TerminalExpressions;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            const string roman = "MCMXXVIII";
            var context = new Context(roman);

            var interpreterTree = new List<Expression>()
            {
                new ThousandExpress(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (var expression in interpreterTree)
            {
                expression.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");
        }
    }
}