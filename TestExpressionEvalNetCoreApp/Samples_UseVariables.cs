using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Samples concerning variables.
    /// 
    /// https://pierlamsoftware.com
    /// </summary>
    public class Samples_UseVariables
    {
        /// <summary>
        /// Get variables used in the expression.
        /// 
        /// The execution will displays:
        /// Var #1, Name=a
        /// Var #2, Name=b
        /// </summary>
        public static void GetVariableOfExpression()
        {
            string expr = "a=b";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            // scan all variables found in the expression (found the variable named 'a')
            int i = 0;
            foreach (ExprVarUsed exprVar in parseResult.ListExprVarUsed)
            {
                i++;
                Console.WriteLine("Var #" + i + ", Name=" + exprVar.Name);
            }

            Console.WriteLine("Define variables: a:=12, b:=12");
            evaluator.DefineVarInt("a", 12);
            evaluator.DefineVarInt("b", 12);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result (should be true): " + execResult.ResultBool);
        }
    }
}
