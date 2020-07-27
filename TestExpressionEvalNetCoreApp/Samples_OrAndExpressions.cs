using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Samples of logical expressions using or/and.
    /// https://pierlamsoftware.com
    /// </summary>
    public class Samples_OrAndExpressions
    {
        public static void OP_A_Or_b_CP_true()
        {
            string expr = "(a Or b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=false, b=true");
            evaluator.DefineVarBool("a", false);
            evaluator.DefineVarBool("b", true);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void OP_A_Or_b_CP_false()
        {
            string expr = "(a Or b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=false, b=false");
            evaluator.DefineVarBool("a", false);
            evaluator.DefineVarBool("b", false);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void OP_A_And_b_CP_true()
        {
            string expr = "(a And b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=true, b=true");
            evaluator.DefineVarBool("a", true);
            evaluator.DefineVarBool("b", true);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void OP_A_And_b_CP_false()
        {
            string expr = "(a And b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=false, b=true");
            evaluator.DefineVarBool("a", false);
            evaluator.DefineVarBool("b", true);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void OP_A_Ou_b_CP_true()
        {
            string expr = "(a Ou b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            // set the tool in french
            evaluator.SetLang(Language.Fr);

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=false, b=true");
            evaluator.DefineVarBool("a", false);
            evaluator.DefineVarBool("b", true);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void OP_A_Xor_b_CP_true()
        {
            string expr = "(a Xor b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=true, b=false");
            evaluator.DefineVarBool("a", true);
            evaluator.DefineVarBool("b", false);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result (true): " + execResult.ResultBool);
        }

        public static void OP_A_Xor_b_CP_false()
        {
            string expr = "(a Xor b)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: a:=true, b=true");
            evaluator.DefineVarBool("a", true);
            evaluator.DefineVarBool("b", true);

            //====3/Execute the expression
            ExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result (false): " + execResult.ResultBool);
        }

    }
}
