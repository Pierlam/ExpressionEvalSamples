using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Test the expression :
    /// (A=B)
    /// </summary>
    public class A_Eq_B
    {
        /// <summary>
        /// Execute the same expression 2 times.
        /// The first time, both variables A and B are defined as integer.
        /// The second time, A and B are then defined as boolean.
        /// </summary>
        public static void Test_A_Eq_B()
        {
            string expr = "(A = B)";
            Console.WriteLine("  The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=15; B=15 ");
            evaluator.DefineVariableInt("a", 15);
            evaluator.DefineVariableInt("b", 15);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            ExprExecValueBool valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());

            //======================================================
            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("\nExecute again the same provided expression but changes variables types and values:");
            Console.WriteLine("Define variables: A=false; B=false");
            evaluator.DefineVariableBool("a", false);
            evaluator.DefineVariableBool("b", false);

            //====3/execute l'expression booléenne
            evaluator.Exec();

            //====4/get the result, its a bool value
            valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());

        }

    }
}
