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
        static void Main(string[] args)
        {
            Console.WriteLine("--Text the ExpressionEval nuget library:");

            A_Eq_B.Test_A_Eq_B();

            Console.WriteLine("Input a key..");
            Console.ReadKey();

        }
    }
}
