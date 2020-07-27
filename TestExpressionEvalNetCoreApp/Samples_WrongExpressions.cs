using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Wrong expressions, error occurs on the parse stage.
    /// https://pierlamsoftware.com
    /// </summary>
    public class Samples_WrongExpressions
    {
        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Eq_12_MissingBracket()
        {
            string expr = "(A = 12";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ParseResult parseResult = evaluator.Parse(expr);

            if(parseResult.HasError)
            {
                Console.WriteLine("The expr '" + expr + "' has errors, nb=" + parseResult.ListError.Count);
                ParseError error = parseResult.ListError[0];
                Console.WriteLine("Error code: " + error.Code);
                Console.WriteLine("Pos in the expr: " + error.Position);
                Console.WriteLine("Wrong token in the expr: " + error.Token);
                return;
            }

            Console.WriteLine("The expr " + expr + " parse finished sucessfully!" );

        }

        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Gt_15_ToManyBracket()
        {
            string expr = "(A > 15))";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ParseResult parseResult = evaluator.Parse(expr);

            if (parseResult.HasError)
            {
                Console.WriteLine("The expr '" + expr + "' has errors, nb=" + parseResult.ListError.Count);
                ParseError error = parseResult.ListError[0];
                Console.WriteLine("Error code: " + error.Code);
                Console.WriteLine("Pos in the expr: " + error.Position);
                Console.WriteLine("Wrong token in the expr: " + error.Token);
                return;
            }

            Console.WriteLine("The expr " + expr + " parse finished sucessfully!");

        }

    }
}
