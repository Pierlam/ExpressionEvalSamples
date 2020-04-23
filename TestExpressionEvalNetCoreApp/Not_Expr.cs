using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    public class Not_Expr
    {
        public static void Not_OP_A_CP_true()
        {
            string expr = "Not(A)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=false");
            evaluator.DefineVarBool("a", false);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void Not_OP_A_CP_false()
        {
            string expr = "Not(A)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=true");
            evaluator.DefineVarBool("a", true);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void Not_OP_A_and_b_CP_true()
        {
            string expr = "Not(A and B)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=true, B=false");
            evaluator.DefineVarBool("a", true);
            evaluator.DefineVarBool("b", false);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void Not_OP_A_and_b_CP_false()
        {
            string expr = "Not(A and B)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=true, B=true");
            evaluator.DefineVarBool("a", true);
            evaluator.DefineVarBool("b", true);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void OP_A_or_B_CP_and_not_OP_C_and_D_CP_true()
        {
            string expr = "(A or B) and not(C and D)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=true, B=false, C=true, D=false");
            evaluator.DefineVarBool("a", true);
            evaluator.DefineVarBool("b", false);
            evaluator.DefineVarBool("c", true);
            evaluator.DefineVarBool("d", false);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void Non_OP_A_CP_true()
        {
            string expr = "Non(A)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            // set the tool in french
            evaluator.SetLang(Language.Fr);

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=false");
            evaluator.DefineVarBool("a", false);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void Non_OP_A_CP_false()
        {
            string expr = "Non(A)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            // set the tool in french
            evaluator.SetLang(Language.Fr);

            //====1/decode the expression
            evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            Console.WriteLine("Define variables: A=true");
            evaluator.DefineVarBool("a", true);

            //====3/Execute the expression
            ExprExecResult execResult = evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

    }
}
