using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Samples of function call used in expression.
    /// </summary>
    public class Samples_UseFunctionCallBasic
    {
        /// <summary>
        /// Function , will be attached to the function call Fct used in the expression.
        /// </summary>
        /// <returns></returns>
        private static bool FctRetBool()
        {
            return true;
        }


        public static void Fct_OP_CP_true()
        {
            string expr = "fct()";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, attach function
            Console.WriteLine("Attach function code to Fct():");
            evaluator.AttachFunction("fct", FctRetBool);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

    }
}
