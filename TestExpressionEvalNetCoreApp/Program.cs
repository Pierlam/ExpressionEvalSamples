using Pierlam.ExpressionEval;
using System;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Test the library ExpressionEval
    /// .NET Core.
    /// Use the netstandard2.0 version.
    /// 
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
            // A=12, A=12 ->return true
            Operand_Comp_Operand.A_Eq_12_true();

            // A=27, A=13 ->return false
            Operand_Comp_Operand.A_Eq_27_false();


            // A<>14, A=33 ->return true
            Operand_Comp_Operand.A_Diff_14_true();

            // A<>15, A=15 ->return false
            Operand_Comp_Operand.A_Diff_15_false();

            // A=B, A=15, B=15 ->return true
            Operand_Comp_Operand.A_Eq_B_true();

            // A=B, Exec 1: A=15, B=15 ->return true
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
        /// not logical expression.
        /// 
        /// </summary>
        static void Samples_Not()
        {
            // Not(A and B): A=true, B=false -> return true
            Not_Expr.Not_OP_A_and_b_CP_true();

            // Not(A and B): A=true, B=true-> return false
            Not_Expr.Not_OP_A_and_b_CP_false();

        }

        /// <summary>
        /// wrong expressions samples
        /// </summary>
        static void Samples_WrongExpressions()
        {
            WrongExpressions.A_Eq_12_MissingBracket();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--Text the ExpressionEval nuget library:");

            // operand comparison operator operand expression samples
            //Samples_Operand_Comp_Oprand();

            // operand comparison operator operand expression samples, with open and close parenthesis
            //Samples_OP_Operand_Comp_Operand_CP();

            // not logical expression
            Samples_Not();

            // wrong expressions samples
            Samples_WrongExpressions();

            Console.WriteLine("Input a key..");
            Console.ReadKey();

        }
    }
}
