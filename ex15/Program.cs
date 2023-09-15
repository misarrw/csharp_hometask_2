// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Write a number: ");
int a = int.Parse(Console.ReadLine()!);

if (a>7 || a<1)
{
    Console.Write("It is not the day of a week!");
}

else
{
    if (a>5)
    {
        Console.Write("yes");
    }
    
    else
    {
        Console.Write("no");
    }
}