using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Code samples, comparison expression..
    /// exp: a=12
    /// https://pierlamsoftware.com
    /// </summary>
    public class Samples_Operand_Comp_Operand
    {
        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Eq_12_true()
        {
            string expr = "A = 12";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            // scan all variables found in the expression (found the variable named 'a')
            int i = 0;
            foreach (ExprVarUsed exprVar in parseResult.ListExprVarUsed)
            {
                i++;
                Console.WriteLine("Var #" + i + "Name=" + exprVar.Name);
            }


            Console.WriteLine("Define variables: a:=12");
            evaluator.DefineVarInt("a", 12);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Eq_27_false()
        {
            string expr = "A = 27";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=13");
            evaluator.DefineVarInt("a", 13);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Diff_14_true()
        {
            string expr = "A <> 14";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=33");
            evaluator.DefineVarInt("a", 33);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Diff_15_false()
        {
            string expr = "A <> 15";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=15");
            evaluator.DefineVarInt("a", 15);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        /// <summary>
        /// Expression: (A=B)
        /// A boolean expression using two variables.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Eq_B_true()
        {
            string expr = "A = B";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=15; B=15 ");
            evaluator.DefineVarInt("a", 15);
            evaluator.DefineVarInt("b", 15);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        /// <summary>
        /// Expression: (A=B)
        /// A boolean expression using two variables.
        /// returns always a boolean value result.
        /// 
        /// Particularity:
        /// Execute the same expression 2 times.
        /// The first time, both variables A and B are defined as integer.
        /// The second time, A and B are then defined as boolean.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Eq_B_Exec2Times()
        {
            string expr = "A = B";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=15; B=15 ");
            evaluator.DefineVarInt("a", 15);
            evaluator.DefineVarInt("b", 15);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);

            //======================================================
            //====2/prepare the execution, provide all used variables: type and value, remove the previous result

            Console.WriteLine("\nExecute again the same provided expression but changes variables types and values:");
            Console.WriteLine("Define variables: A=false; B=false");
            evaluator.DefineVarBool("a", false);
            evaluator.DefineVarBool("b", false);

            //====3/execute l'expression booléenne
            execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }
    }
}
