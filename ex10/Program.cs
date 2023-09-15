// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Write a number: ");
int a = int.Parse(Console.ReadLine()!);

if (a/100>0)
{
    int a1 = a / 10;
    int a2 = a1 % 10;
    Console.Write(a2);
}

else
{
    Console.Write("The number is lower than 100!");
}