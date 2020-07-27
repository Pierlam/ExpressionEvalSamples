using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Samples of calculation expression.
    /// exp: a+b
    /// https://pierlamsoftware.com
    /// </summary>
    public class Samples_Calculation_Basic
    {
        public static void a_plus_b_ret_9()
        {
            string expr = "a+b";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=4, b:=5");
            evaluator.DefineVarInt("a", 4);
            evaluator.DefineVarInt("b", 5);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Resultis an int?: " + execResult.IsResultInt);
            Console.WriteLine("Execution Result (should be 9): " + execResult.ResultInt);
        }

        public static void a_plus_b_mul_c_ret_90()
        {
            string expr = "(a+b) *c";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=4, b:=5, c:= 10");
            evaluator.DefineVarInt("a", 4);
            evaluator.DefineVarInt("b", 5);
            evaluator.DefineVarInt("c", 10);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Resultis an int?: " + execResult.IsResultInt);
            Console.WriteLine("Execution Result (should be 90): " + execResult.ResultInt);
        }

    }
}
