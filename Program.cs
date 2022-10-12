/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine ("Enter the first number");
string firstNumber = Console.ReadLine ();

Console.WriteLine ("Enter the second number");
string secondNumber = Console.ReadLine ();

Console.WriteLine ("Enter the third number");
string thirdNumber = Console.ReadLine ();

int firstNum = int.Parse(firstNumber);
int secondNum = int.Parse(secondNumber);
int thirdNum = int.Parse(thirdNumber);

int max = firstNum;

if (firstNum > max) max = firstNum;

if (secondNum > max) max = secondNum;

if (thirdNum > max) max = thirdNum;

Console.Write("max -> ");
Console.WriteLine(max);
