using Pierlam.ExpressionEval;
using System;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Test the library ExpressionEval
    /// .NET Core.
    /// Use the netstandard2.0 version.
    /// 
    /// Use the version 0.3 of the ExpressionEval library from nuget.
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
        static void Samples_Operand_Comp_Oprand()
        {
            // A=12, A:=12 ->return true
            // see how to scan all variables found in the expression
            Operand_Comp_Operand.A_Eq_12_true();

            // A=27, A:=13 ->return false
            Operand_Comp_Operand.A_Eq_27_false();


            // A<>14, A:=33 ->return true
            Operand_Comp_Operand.A_Diff_14_true();

            // A<>15, A:=15 ->return false
            Operand_Comp_Operand.A_Diff_15_false();

            // A=B, A:=15, B:=15 ->return true
            Operand_Comp_Operand.A_Eq_B_true();

            // A=B, Exec 1: A:=15, B:=15 ->return true
            // Exec 2: a=false, b=false -> return true
            Operand_Comp_Operand.A_Eq_B_Exec2Times();

            // todo: Comparaison: >, >=, <, <=


        }


        /// <summary>
        /// OP: Opening Parenthesis: (
        /// CP: Closing Parenthesis: )
        /// 
        /// operande comparison operator operand expression samples
        /// 
        /// </summary>
        static void Samples_OP_Operand_Comp_Operand_CP()
        {
            // (A=12), A=12 ->return true
            OP_Operand_Comp_Operand_CP.A_Eq_12_true();

            // (A=27), A=13 ->return false
            OP_Operand_Comp_Operand_CP.A_Eq_27_false();

            // (A<>14), A=33 ->return true
            OP_Operand_Comp_Operand_CP.A_Diff_14_true();

            // (A<>15), A=15 ->return false
            OP_Operand_Comp_Operand_CP.A_Diff_15_false();

            // (A=B), A=15, B=15 ->return true
            OP_Operand_Comp_Operand_CP.A_Eq_B_true();

            // (A=B), Exec 1: A=15, B=15 ->return true
            // Exec 2: a=false, b=false -> return true
            OP_Operand_Comp_Operand_CP.A_Eq_B_Exec2Times();

            // todo: Comparaison: >, >=, <, <=
        }

        /// <summary>
        ///  logical two operands expression: and, or

        /// </summary>
        static void Samples_OrAnd_Expressions()
        {
            // (a Or b): a:=false, b:=true, return true
            OrAndExpressions.OP_A_Or_b_CP_true();

            // (a Or b): a:=false, b:=false, return false
            OrAndExpressions.OP_A_Or_b_CP_false();

            // (a And b): a:=true, b:=true, return true
            OrAndExpressions.OP_A_And_b_CP_true();

            // (a And b): a:=false, b:=true, return false
            OrAndExpressions.OP_A_And_b_CP_false();


            // set the language to French, so logical operator are: Ou, Et, Non
            // (a Ou b): a:=false, b:=true, return true
            OrAndExpressions.OP_A_Ou_b_CP_true();
        }

        /// <summary>
        /// not logical expression.
        /// 
        /// </summary>
        static void Samples_Not()
        {
            // Not(A): A:=false -> return true
            Not_Expr.Not_OP_A_CP_true();

            // Not(A): A:=true-> return false
            Not_Expr.Not_OP_A_CP_false();
            
            // Not(A and B): A:=true, B:=false -> return true
            Not_Expr.Not_OP_A_and_b_CP_true();

            // Not(A and B): A:=true, B:=true-> return false
            Not_Expr.Not_OP_A_and_b_CP_false();

            // set the language to French, so logical operator is: Non
            // Non(A): A:=false -> return true
            Not_Expr.Non_OP_A_CP_true();

            // Non(A): A=true-> return false
            Not_Expr.Non_OP_A_CP_false();
        }

        /// <summary>
        /// wrong expressions structure samples: missing parenthesis,...
        /// </summary>
        static void Samples_WrongExpressions()
        {
            WrongExpressions.A_Eq_12_MissingBracket();

            WrongExpressions.A_Gt_15_ToManyBracket();
        }

        /// <summary>
        /// Expressions with variables well built but variables bad defined (type or/and value).
        /// </summary>
        static void Samples_WrongVariables()
        {
            // Not(A): -> error, the variable a should be defined/created
            Samples_ExprOkVarError.Not_OP_A_CP_Var_a_NotDefined_Err();
            
            // Not(A): A:=12-> error, the variable should be a boolean 
            // -->an exception occurs, need a fix and a new version.
            Samples_ExprOkVarError.Not_OP_A_CP_A_Int_Err();
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
        /// use function call in expression
        /// </summary>
        static void Exec_Samples_UseFunctionCall()
        {
            // a=12.34:  a:=12.34, return true
            Samples_UseFunctionCallBasic.Fct_OP_CP_true();

            // todo: others samples will coming soon!
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
            Console.WriteLine("  Simplifcation to use the component: InitExec() removed.");
            Console.WriteLine("  Now possible to use function cal in expression, with any or one parameter.");
            Console.WriteLine("  functionCall: return type: bool, int , string and double managed");
            Console.WriteLine("  functionCall: parameter type: bool, int , string and double managed");
        }

        static void Main(string[] args)
        {
            //ShowInfos_v0_3();
            ShowInfos_v0_4();

            // operand comparison operator operand expression samples
            Samples_Operand_Comp_Oprand();

            // operand comparison operator operand expression samples, with open and close parenthesis
            Samples_OP_Operand_Comp_Operand_CP();

            // logical two operands expression: and, or
            Samples_OrAnd_Expressions();

            // not logical expression
            Samples_Not();

            // wrong expressions samples
            Samples_WrongExpressions();

            // Expressions with variables well built but variables bad defined (type or/and value).
            Samples_WrongVariables();

            // expressions with double number
            Exec_Samples_UseNumber();

            // use function call in expression
            Exec_Samples_UseFunctionCall();

            Console.WriteLine("Input a key..");
            Console.ReadKey();

        }
    }
}
