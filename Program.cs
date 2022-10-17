using System.Runtime.CompilerServices;
using Lesson4Mass;

int row;
int column;
bool end = false;

Console.WriteLine("How many rows are in the matrix?");
row = int.Parse(Console.ReadLine());
Console.WriteLine("How many column are in the matrix?");
column = int.Parse(Console.ReadLine());

int[,] Massive = new int[row, column];

for (int i=0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.WriteLine($"Enter parameter value with index {i} : {j}");
        Massive[i,j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Your array looks like this:");

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write($"{Massive[i, j],10}");        
    }
    Console.WriteLine();
}
Console.ReadLine();

while (!end)
{
    Console.WriteLine("If you want to count the number of positive numbers, click '+'\r\n" +
        "If you want to count the number of negative numbers, click '-'\r\n" +
        "If you want to Exit, press any other key");
    string WhatsNext = Console.ReadLine();

    switch (WhatsNext)
    {
        case "+":
            Counter.NumberOfPositive(Massive, row, column);
            break;
        case "-":
            Counter.NumberOfNegative(Massive, row, column);
            break;
        default:
            end = true;
            return;
    }
}
