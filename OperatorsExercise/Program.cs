//Exercise 1

using OperatorsExercise;

int num1 = 17;
int num2 = 4;

int quotient = num1 / num2;
int remainder = num1% num2;

if (num1 == 17 && num2 == 4)
{
    Console.WriteLine($"{num1}/{num2} is {quotient} remainder {remainder}");
}

//Exercise 2
 
Console.WriteLine("What is the radius of your circle?");
var radius = double.Parse(Console.ReadLine());

double area = Exercise2.AreaOfCircle(radius);

Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.");