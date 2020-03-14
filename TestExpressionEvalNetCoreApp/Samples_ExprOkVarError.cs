using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Expressions with variables well built but variables bad defined (type or/and value).
    /// </summary>
    public class Samples_ExprOkVarError
    {
        public static void Not_OP_A_CP_Var_a_NotDefined_Err()
        {
            string expr = "Not(A)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            //Console.WriteLine("Define variables: A=12");
            //evaluator.DefineVarInt("a", 12);

            //====3/Execute the expression
            evaluator.Exec();

            if(execResult.HasError)
            {
                // error: VariableNotCreated
                Console.WriteLine("Execution Result failed, err: " + execResult.ListError[0].ErrCode);

                // Key: VarName, Value: a
                Console.WriteLine("Execution Result failed, ParamKey: " + execResult.ListError[0].ListErrorParam[0].Key + ", ParamValue: " + execResult.ListError[0].ListErrorParam[0].Value);
                return;
            }

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }

        public static void Not_OP_A_CP_A_Int_Err()
        {
            string expr = "Not(A)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=12");
            evaluator.DefineVarInt("a", 12);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            Console.WriteLine("Execution Result: " + execResult.ResultBool);
        }
    }
}
