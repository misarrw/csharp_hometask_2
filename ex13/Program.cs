// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Write a number: ");
int a = int.Parse(Console.ReadLine()!);

if (a/100>0)
{
    char [] ar = a.ToString().ToCharArray();
    Console.WriteLine(ar[2]);   
}

else
{
    Console.WriteLine("The third digit does not exist!");   
}