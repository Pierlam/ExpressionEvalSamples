using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Samples of function call used in expression.
    /// https://pierlamsoftware.com
    /// </summary>
    public class Samples_UseFunctionCallBasic
    {
        /// <summary>
        /// Function , will be attached to the function call Fct used in the expression.
        /// </summary>
        /// <returns></returns>
        private static bool FctRetBool()
        {
            // ok its stupid but its for a test ;)
            return true;
        }

        
        /// <summary>
        /// Function , will be attached to the function call Fct used in the expression.
        /// </summary>
        /// <returns></returns>
        private static bool FctRetBool_Int(int a)
        {
            if (a < 10)
                return false;

            // a >= 10 return true
            return true;
        }


        /// <summary>
        /// Function , will be attached to the function call Fct used in the expression.
        /// Has 2 int parameters.
        /// </summary>
        /// <returns></returns>
        private static int FctRetInt_Int_Int(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Use a function call in the expression.
        /// A function code is attached to the function call and executed.
        /// </summary>
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

        /// <summary>
        /// Execute a function call two times with different values.
        /// 
        /// fct(a)  a:=8  ->return false
        /// fct(a)  a:=12  ->return true
        /// 
        /// </summary>
        public static void CallFunctionWithIntParam_TwoTimes()
        {
            string expr = "fct(a)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, attach function
            Console.WriteLine("Attach function code to Fct() and set value to param: a=8");
            evaluator.DefineVarInt("a", 8);
            evaluator.AttachFunction("fct", FctRetBool_Int);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result (should return false): " + execResult.ResultBool);

            //============================================================
            //====2/prepare the execution, attach function
            Console.WriteLine("Set value to param: a=12");
            evaluator.DefineVarInt("a", 12);
            evaluator.AttachFunction("fct", FctRetBool_Int);

            //====3/Execute the expression
            execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result (should return true): " + execResult.ResultBool);
        }

        /// <summary>
        /// Execute a function having 2 int parameters.
        /// </summary>
        public static void CallFunctionWith2IntParams_ret_5()
        {
            string expr = "fct(a,b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, attach function
            Console.WriteLine("Attach function code to Fct() and set value to param: a=8");
            evaluator.DefineVarInt("a", 2);
            evaluator.DefineVarInt("b", 3);
            evaluator.AttachFunction("fct", FctRetInt_Int_Int);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result is an int type?: " + execResult.IsResultInt);
            Console.WriteLine("Execution Result is (should be 5): " + execResult.ResultInt);

        }
    }
    }
