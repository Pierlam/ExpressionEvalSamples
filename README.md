# ExpressionEvalSamples

## Description
The solution contains samples of the ExpressionEval library published on nuget.

ExpressionEval is an Expression Evaluator back-office component. It enables you to evaluate easily comparison (Or, And and Not) or logical expression (=, <>, >, <, <=, >=) in a application. Comparison and logical can be mixed, as you want. It's possible to use variable in the expression. This component is a library provided in .NET Standard 2.0 and also in .NET Framework 4.5.

The library on nuget:
https://www.nuget.org/packages/Pierlam.ExpressionEval/

The web site:
https://pierlam-project.wixsite.com/website 

Contact us:
Pierlam-Project@outlook.com

## Examples of Expressions
Expressions are provided as a raw string to the library.

Some examples of expressions you can execute:
(a And b)

(a or b) And (c or d)

NOT(a)

Not a

a=b

(a >= b) and ( c <> d)

a, b, c, d are variables used in expressions.

After the parse (decode) of the expression, you have to define these variables: define the type and provide a value.

Possibles types are: bool, int, double and string.


## TestExpressionEvalNetCoreApp
This an application example, it's a .NET Core console application
See the code inside this application to have several examples of use of the ExpressionEval library.

The solution uses now the last published version: 0.2-beta 


