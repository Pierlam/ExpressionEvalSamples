using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Samples of function call used in expression: having 3 parameters.
    /// The function attachment is different from functionCall with less parameter (0, one or two).
    /// Need to use a mapper.
    /// </summary>
    public class Samples_FunctionCall3Params
    {
        /// <summary>
        /// Function , will be attached to the function call Fct used in the expression.
        /// Has 2 int parameters.
        /// </summary>
        /// <returns></returns>
        private static int FctRetInt_Int_Int_Int(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Execute a function having 2 int parameters.
        /// </summary>
        public static void CallFunctionWith3IntParams_ret_10()
        {
            string expr = "fct(a,b,c)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, attach function
            Console.WriteLine("Attach function code to Fct() and set value to param: a=2, b=3; c=5");
            evaluator.DefineVarInt("a", 2);
            evaluator.DefineVarInt("b", 3);
            evaluator.DefineVarInt("c", 5);

            // attach the 3 params function to the function call
            Func3ParamsRetIntMapper<int, int, int> func3ParamsRetIntMapper = new Func3ParamsRetIntMapper<int, int, int>();
            func3ParamsRetIntMapper.SetFunction(FctRetInt_Int_Int_Int);
            evaluator.AttachFunction("fct", func3ParamsRetIntMapper);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution has error? (should be false): " + execResult.HasError);
            Console.WriteLine("Execution Result is an int type?: " + execResult.IsResultInt);
            Console.WriteLine("Execution Result is (should be 10): " + execResult.ResultInt);

        }

    }
}
