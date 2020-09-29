using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Version informations.
    /// </summary>
    public class VersionInfos
    {
        public void ShowInfos_v0_8_1()
        {
            Console.WriteLine("--Test the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.8.1");
            Console.WriteLine("Changes:");
            Console.WriteLine("  -Now open-source and free of charge with full funcionnalities.");
        }

        public void ShowInfos_v0_7()
        {
            Console.WriteLine("--Test the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.7");
            Console.WriteLine("Changes:");
            Console.WriteLine("  -Simplication of errors classes: only one error class now: ExprError.");
            Console.WriteLine("    for licensing, parse, exec and config (var definition and function attachment) ");
            Console.WriteLine("  -Now possible to get expression configuration errors: define var and attach function.");
            Console.WriteLine("    List<ExprError> ExpressionEval.GetListErrorExprConfig()");
            Console.WriteLine("  -Calculation expression: can now have more than one operator/two operands.");
            Console.WriteLine("    exp: a+b-c,  a*b*c+d");
            Console.WriteLine("  -DoubleFunctionCallParamSeparators renamed by: DecimalAndFunctionSeparators");
        }

        public void ShowInfos_v0_6()
        {
            Console.WriteLine("--Test the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.6");
            Console.WriteLine("Changes:");
            Console.WriteLine("  Simplication of parse and exec result objects.");
            Console.WriteLine("  Add XOR logical operator.");
            Console.WriteLine("  Subject to License (trial by default).");
        }

        public void ShowInfos_v0_5()
        {
            Console.WriteLine("--Test the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.5");
            Console.WriteLine("Changes:");
            Console.WriteLine("  Bug fixed on negative number.");
            Console.WriteLine("  Function call can have until 3 parameters.");
            Console.WriteLine("  New! Calculation expression added in this release: +, -, *, /.");
            Console.WriteLine("  functionCall: parameter type: bool, int , string and double managed");
        }

        public void ShowInfos_v0_4()
        {
            Console.WriteLine("--Test the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.4");
            Console.WriteLine("Changes:");
            Console.WriteLine("  Simplification to use the component: InitExec() removed.");
            Console.WriteLine("  Now possible to use function cal in expression, with any or one parameter.");
            Console.WriteLine("  functionCall: return type: bool, int , string and double managed");
            Console.WriteLine("  functionCall: parameter type: bool, int , string and double managed");
        }

        public void ShowInfos_v0_3()
        {
            Console.WriteLine("--Test the ExpressionEval nuget library:");
            Console.WriteLine("Version is: 0.3");
            Console.WriteLine("Changes:");
            Console.WriteLine("  Bugs fixes on expressions using NOT logical operator.");
            Console.WriteLine("  ExpressionEval.DefineVariableBool() replaced by ExpressionEval.DefineVarBool()");
            Console.WriteLine("  ExpressionEval.DefineVariableInt() replaced by ExpressionEval.DefineVarInt()");
            Console.WriteLine("  ExpressionEval.DefineVariableString() replaced by ExpressionEval.DefineVarString()");
            Console.WriteLine("  ExpressionEval.DefineVariableDouble() replaced by ExpressionEval.DefineVarDouble()");
            Console.WriteLine("  Get the bool result of an execution, is now simplier, just use: ExprExecResult.ResultBool, its a boolean value.");
        }

    }
}
