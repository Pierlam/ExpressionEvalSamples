using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    public class Not_Expr
    {
        public static void Not_OP_A_and_b_CP_true()
        {
            string expr = "Not(A and B)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=true, B=false");
            evaluator.DefineVariableBool("a", true);
            evaluator.DefineVariableBool("b", false);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            ExprExecValueBool valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());
        }

        public static void Not_OP_A_and_b_CP_false()
        {
            string expr = "Not(A and B)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=true, B=true");
            evaluator.DefineVariableBool("a", true);
            evaluator.DefineVariableBool("b", true);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            ExprExecValueBool valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());
        }

        public static void OP_A_or_B_CP_and_not_OP_C_and_D_CP_true()
        {
            string expr = "(A or B) and not(C and D)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=true, B=false, C=true, D=false");
            evaluator.DefineVariableBool("a", true);
            evaluator.DefineVariableBool("b", false);
            evaluator.DefineVariableBool("c", true);
            evaluator.DefineVariableBool("d", false);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            ExprExecValueBool valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());
        }

    }
}
