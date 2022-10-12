// See https://aka.ms/new-console-template for more information
global using SpecFlowCalculator;
Calculator asdf = new Calculator();

Console.WriteLine("hello there, welcome to the calculator app");
Console.WriteLine("type 1 to add and 2 to multiply");
string input = Console.ReadLine();
string first, second;
int firstint = 0;
int secondint = 0;
if (input == "1")
{
    Console.WriteLine("give me the first number");
    first = Console.ReadLine();
    Console.WriteLine("give me the second number");
    second = Console.ReadLine();
    firstint = int.Parse(first);
    secondint = int.Parse(second);
    asdf.FirstNumber = firstint;
    asdf.SecondNumber = secondint;
    asdf.Add();
}
else if (input == "2")
{
    Console.WriteLine("give me the first number");
    first = Console.ReadLine();
    Console.WriteLine("give me the second number");
    second = Console.ReadLine();
    firstint = int.Parse(first);
    secondint = int.Parse(second);
    asdf.FirstNumber = firstint;
    asdf.SecondNumber = secondint;
    asdf.Multiply();
}
else
{
    Console.WriteLine("sorry that hasn't been implemented yet");
}


    