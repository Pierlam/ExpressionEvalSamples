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
        /// error, the variables types mismatch.
        /// Can't compare an integer and a boolean.
        /// 
        /// ====The expression is: (a=b)
        /// The expr '(a=b)' has errors, nb = 1
        /// Error code: ExprComparisonOperandsTypeMismatchIntExpected
        /// Error param: Position= 3
        ///
        /// </summary>
        public static void A_Eq_B_TypeMismatch()
        {
            string expr = "(a=b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            // 1-decode the expression
            evaluator.Parse(expr);

            // 2-set variables
            evaluator.DefineVarInt("a", 12);
            evaluator.DefineVarBool("b", true);

            // 3-execute the expression
            ExecResult execResult= evaluator.Exec();

            // 4-check error
            if (execResult.HasError)
            {
                // display the error code
                Console.WriteLine("The expr '" + expr + "' has errors, nb=" + execResult.ListError.Count);
                ExecError error = execResult.ListError[0];
                Console.WriteLine("Error code: " + error.Code);

                // display the error parameter (the position of the wrong token)
                Console.WriteLine("Error param: " + error.ListErrorParam[0].Key+ "= " + error.ListErrorParam[0].Value);

                return;
            }

            Console.WriteLine("The expr " + expr + " parse finished sucessfully!");

        }

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
