/*** Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int a = n;
if (n < 100)
{ 
    Console.WriteLine($"{n} -> Третьей цифры нет");}
else
{ while (a/10 > 100)
    {a = a/10;}
a = a%10;

Console.WriteLine($"{n} -> {a}");}

