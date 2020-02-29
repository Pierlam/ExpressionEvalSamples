using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Test the expression :
    /// (A=B)
    /// OP  Opening Parenthesis
    /// CP  Closing
    /// </summary>
    public class OP_Operand_Comp_Operand_CP
    {
        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Eq_12_true()
        {
            string expr = "(A = 12)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=12");
            evaluator.DefineVariableInt("a", 12);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            ExprExecValueBool valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());
        }

        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Eq_27_false()
        {
            string expr = "(A = 27)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=13");
            evaluator.DefineVariableInt("a", 13);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            ExprExecValueBool valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());
        }

        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Diff_14_true()
        {
            string expr = "(A <> 14)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=33");
            evaluator.DefineVariableInt("a", 33);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            ExprExecValueBool valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());
        }

        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Diff_15_false()
        {
            string expr = "(A <> 15)";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            //====2/prepare the execution, provide all used variables: type and value, remove the previous result
            ExprExecResult execResult = evaluator.InitExec(parseResult);

            Console.WriteLine("Define variables: A=15");
            evaluator.DefineVariableInt("a", 15);

            //====3/Execute the expression
            evaluator.Exec();

            //====4/get the result, its a bool value
            ExprExecValueBool valueBool = execResult.ExprExec as ExprExecValueBool;

            Console.WriteLine("Execution Result: " + valueBool.Value.ToString());
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
            string expr = "(A = B)";
            Console.WriteLine("\n====The expression is: " + expr);

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
            string expr = "(A = B)";
            Console.WriteLine("\n====The expression is: " + expr);

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
