using Pierlam.ExpressionEval;
using System;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Test the library ExpressionEval
    /// It's a .NET Core target application.
    /// Use the netstandard2.0 version of the Library.
    /// 
    /// Use the version 0.5 of the ExpressionEval library from nuget.
    /// 
    /// https://pierlamsoftware.com
    /// </summary>
    class Program
    {
        /// <summary>
        /// OP: Opening Parenthesis: (
        /// CP: Closing Parenthesis: )
        /// 
        /// operande comparison operator operand expression samples
        /// 
        /// </summary>
        static void Exec_Samples_Operand_Comp_Operand()
        {
            // A=12, A:=12 ->return true
            // see how to scan all variables found in the expression
            Samples_Operand_Comp_Operand.A_Eq_12_true();

            // A=27, A:=13 ->return false
            Samples_Operand_Comp_Operand.A_Eq_27_false();


            // A<>14, A:=33 ->return true
            Samples_Operand_Comp_Operand.A_Diff_14_true();

            // A<>15, A:=15 ->return false
            Samples_Operand_Comp_Operand.A_Diff_15_false();

            // A=B, A:=15, B:=15 ->return true
            Samples_Operand_Comp_Operand.A_Eq_B_true();

            // A=B, Exec 1: A:=15, B:=15 ->return true
            // Exec 2: a=false, b=false -> return true
            Samples_Operand_Comp_Operand.A_Eq_B_Exec2Times();

            // todo: Comparaison: >, >=, <, <=


        }


        /// <summary>
        /// OP: Opening Parenthesis: (
        /// CP: Closing Parenthesis: )
        /// 
        /// operande comparison operator operand expression samples
        /// 
        /// </summary>
        static void Exec_Samples_OP_Operand_Comp_Operand_CP()
        {
            // (A=12), A=12 ->return true
            TestExpressionEvalNetCoreApp.Samples_OP_Operand_Comp_Operand_CP.A_Eq_12_true();

            // (A=27), A=13 ->return false
            TestExpressionEvalNetCoreApp.Samples_OP_Operand_Comp_Operand_CP.A_Eq_27_false();

            // (A<>14), A=33 ->return true
            TestExpressionEvalNetCoreApp.Samples_OP_Operand_Comp_Operand_CP.A_Diff_14_true();

            // (A<>15), A=15 ->return false
            TestExpressionEvalNetCoreApp.Samples_OP_Operand_Comp_Operand_CP.A_Diff_15_false();

            // (A=B), A=15, B=15 ->return true
            TestExpressionEvalNetCoreApp.Samples_OP_Operand_Comp_Operand_CP.A_Eq_B_true();

            // (A=B), Exec 1: A=15, B=15 ->return true
            // Exec 2: a=false, b=false -> return true
            TestExpressionEvalNetCoreApp.Samples_OP_Operand_Comp_Operand_CP.A_Eq_B_Exec2Times();

            // todo: Comparaison: >, >=, <, <=
        }

        /// <summary>
        ///  logical two operands expression: and, or

        /// </summary>
        static void Exec_Samples_OrAnd_Expressions()
        {
            // (a Or b): a:=false, b:=true, return true
            Samples_OrAndXorExpressions.OP_A_Or_b_CP_true();

            // (a Or b): a:=false, b:=false, return false
            Samples_OrAndXorExpressions.OP_A_Or_b_CP_false();

            // (a And b): a:=true, b:=true, return true
            Samples_OrAndXorExpressions.OP_A_And_b_CP_true();

            // (a And b): a:=false, b:=true, return false
            Samples_OrAndXorExpressions.OP_A_And_b_CP_false();


            // set the language to French, so logical operator are: Ou, Et, Non
            // (a Ou b): a:=false, b:=true, return true
            Samples_OrAndXorExpressions.OP_A_Ou_b_CP_true();

            // (a Xor b): a:=true, b:=false, return true
            Samples_OrAndXorExpressions.OP_A_Xor_b_CP_true();

            // (a Xor b): a:=true, b:=true, return false
            Samples_OrAndXorExpressions.OP_A_Xor_b_CP_false();

        }

        /// <summary>
        /// not logical expression.
        /// 
        /// </summary>
        static void Exec_Samples_Not()
        {
            // Not(A): A:=false -> return true
            Samples_Not_Expr.Not_OP_A_CP_true();

            // Not(A): A:=true-> return false
            Samples_Not_Expr.Not_OP_A_CP_false();
            
            // Not(A and B): A:=true, B:=false -> return true
            Samples_Not_Expr.Not_OP_A_and_b_CP_true();

            // Not(A and B): A:=true, B:=true-> return false
            Samples_Not_Expr.Not_OP_A_and_b_CP_false();

            // set the language to French, so logical operator is: Non
            // Non(A): A:=false -> return true
            Samples_Not_Expr.Non_OP_A_CP_true();

            // Non(A): A=true-> return false
            Samples_Not_Expr.Non_OP_A_CP_false();
        }

        /// <summary>
        /// expressions with double number
        /// exp: 12.34  123E6
        /// 
        /// </summary>
        static void Exec_Samples_UseNumber()
        {
            // a=12.34:  a:=12.34, return true
            Samples_UseNumber.a_Eq_12dot34_true();

            // a=123E5:  a:=123E5, return true
            Samples_UseNumber.a_Eq_123E5_true();

        }

        /// <summary>
        /// Samples concerning variables:
        /// how to scan it...
        /// </summary>
        static void Exec_Samples_UseVariables()
        {
            // get the variables used in the expression, in the parse stage
            Samples_UseVariables.GetVariableOfExpression();
        }

        /// <summary>
        /// use function call in expression.
        /// 0, one, two or three parameters.
        /// </summary>
        static void Exec_Samples_UseFunctionCall()
        {
            // function call without parameter: fct()
            Samples_UseFunctionCallBasic.Fct_OP_CP_true();

            // function call with one int parameter called two times: fct(a)
            Samples_UseFunctionCallBasic.CallFunctionWithIntParam_TwoTimes();

            // call a function having 2 int parameters, returning the sum (an int)
            Samples_UseFunctionCallBasic.CallFunctionWith2IntParams_ret_5();

            // use a function having 3 parameters
            Samples_FunctionCall3Params.CallFunctionWith3IntParams_ret_10();        
        }

        /// <summary>
        /// Use calculation in expression.
        /// exp: a+b
        /// </summary>
        static void Exec_Samples_Calculation_Basic()
        {
            Samples_Calculation_Basic.a_plus_b_ret_9();

            Samples_Calculation_Basic.a_plus_b_mul_c_ret_90();
        }

        /// <summary>
        /// wrong expressions structure samples: missing parenthesis,...
        /// </summary>
        static void Exec_Samples_WrongExpressions()
        {
            TestExpressionEvalNetCoreApp.Samples_WrongExpressions.A_Eq_B_TypeMismatch();

            TestExpressionEvalNetCoreApp.Samples_WrongExpressions.A_Eq_12_MissingBracket();

            TestExpressionEvalNetCoreApp.Samples_WrongExpressions.A_Gt_15_ToManyBracket();
        }

        /// <summary>
        /// Expressions with variables well built but variables bad defined (type or/and value).
        /// </summary>
        static void Exec_Samples_WrongVariables()
        {
            // Not(A): -> error, the variable a should be defined/created
            Samples_ExprOkVarError.Not_OP_A_CP_Var_a_NotDefined_Err();

            // Not(A): A:=12-> error, the variable should be a boolean 
            // -->an exception occurs, need a fix and a new version.
            Samples_ExprOkVarError.Not_OP_A_CP_A_Int_Err();
        }

        static void ShowInfos_v0_3()
        {
            Console.WriteLine("--Text the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.3");
            Console.WriteLine("Changes:");
            Console.WriteLine("  Bugs fixes on expressions using NOT logical operator.");
            Console.WriteLine("  ExpressionEval.DefineVariableBool() replaced by ExpressionEval.DefineVarBool()");
            Console.WriteLine("  ExpressionEval.DefineVariableInt() replaced by ExpressionEval.DefineVarInt()");
            Console.WriteLine("  ExpressionEval.DefineVariableString() replaced by ExpressionEval.DefineVarString()");
            Console.WriteLine("  ExpressionEval.DefineVariableDouble() replaced by ExpressionEval.DefineVarDouble()");
            Console.WriteLine("  Get the bool result of an execution, is now simplier, just use: ExprExecResult.ResultBool, its a boolean value.");
        }

        static void ShowInfos_v0_4()
        {
            Console.WriteLine("--Text the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.4");
            Console.WriteLine("Changes:");
            Console.WriteLine("  Simplification to use the component: InitExec() removed.");
            Console.WriteLine("  Now possible to use function cal in expression, with any or one parameter.");
            Console.WriteLine("  functionCall: return type: bool, int , string and double managed");
            Console.WriteLine("  functionCall: parameter type: bool, int , string and double managed");
        }

        static void ShowInfos_v0_5()
        {
            Console.WriteLine("--Text the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.5");
            Console.WriteLine("Changes:");
            Console.WriteLine("  Bug fixed on negative number.");
            Console.WriteLine("  Function call can have until 3 parameters.");
            Console.WriteLine("  New! Calculation expression added in this release: +, -, *, /.");
            Console.WriteLine("  functionCall: parameter type: bool, int , string and double managed");
        }

        static void ShowInfos_v0_6()
        {
            Console.WriteLine("--Text the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.6");
            Console.WriteLine("Changes:");
            Console.WriteLine("  Simplication of parse and exec result objects.");
            Console.WriteLine("  Add XOR logical operator.");
        }

        static void Main(string[] args)
        {
            //ShowInfos_v0_3();
            //ShowInfos_v0_4();
            //ShowInfos_v0_5();
            ShowInfos_v0_6();

            Console.WriteLine("\nInput a key to continue..");
            Console.ReadKey();

            // operand comparison operator operand expression samples
            Exec_Samples_Operand_Comp_Operand();

            // operand comparison operator operand expression samples, with open and close parenthesis
            Exec_Samples_OP_Operand_Comp_Operand_CP();

            // logical two operands expression: and, or
            Exec_Samples_OrAnd_Expressions();

            // not logical expression
            Exec_Samples_Not();

            // expressions with double number
            Exec_Samples_UseNumber();

            // variables in expression
            Exec_Samples_UseVariables();

            // use function call in expression
            Exec_Samples_UseFunctionCall();

            // execute calculation expression
            Exec_Samples_Calculation_Basic();

            // wrong expressions samples
            Exec_Samples_WrongExpressions();

            // Expressions with variables well built but variables bad defined (type or/and value).
            Exec_Samples_WrongVariables();

            Console.WriteLine("\nInput a key to ends..");
            Console.ReadKey();

        }
    }
}
