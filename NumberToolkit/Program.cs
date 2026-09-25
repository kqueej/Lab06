Console.Write("enter first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("enter second number: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("enter third number: ");
int number3 = int.Parse(Console.ReadLine());

PrintSeparator();

Console.WriteLine($"{number1} prime: {IsPrime(number1)}");
Console.WriteLine($"{number2} prime: {IsPrime(number2)}");
Console.WriteLine($"{number3} prime: {IsPrime(number3)}");

PrintSeparator();

Console.WriteLine($"max of three: {FindMax(number1, number2, number3)}");
Console.WriteLine($"max of first two: {FindMax(number1, number2, 0)}");

PrintSeparator();

Console.WriteLine(
    $"average: {CalculateAverage(number1, number2, number3):F2}"
);

bool IsPrime(int number)
{
    if (number < 2)
    {
        return false;
    }
    for (int i = 2; i <= number -1; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

int FindMax(int a, int b, int c)
{
    int maxN = a;

    if (b > maxN)
    {
        maxN = b;
    }

    if (c > maxN)
    {
        maxN = c;
    }
    return maxN;
}

double CalculateAverage(int a, int b, int c)
{
    return (a + b + c) / 3.0;
}

void PrintSeparator()
{
    Console.WriteLine();
}
