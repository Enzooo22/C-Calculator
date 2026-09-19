Console.WriteLine("Calculator ko");

Console.WriteLine("Enter 1st number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd number");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter an operator (+, -, *, /, %)");
String op = Console.ReadLine();

if(op == "+")
{
    Console.WriteLine(num1 + num2);
}

else if(op == "-")
{
    Console.WriteLine(num1 - num2);
}

else if(op == "*")
{
    Console.WriteLine(num1 * num2);
}

else if(op == "%")
{
    Console.WriteLine(num1 % num2);
}

else if(op == "/")
{
    Console.WriteLine(num1 / num2);
    if(num1 == 0 || num2 == 0)
    {
        Console.WriteLine("Cannot divide by 0");
    }
}