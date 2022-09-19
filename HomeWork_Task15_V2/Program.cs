// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

String[] Week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
Console.Write("Pls enter week's day number: ");
int num = int.Parse(Console.ReadLine());

if (num >= 6 && num <= 7)
{
    Console.WriteLine($"{num} -> Yep, {Week[num - 1]} - Is a Weekend, Get ready to PARTY!");
}
else
{
    Console.WriteLine($"{num} -> Nop, {Week[num - 1]} - So sad, still hve to go work :-(");
}
