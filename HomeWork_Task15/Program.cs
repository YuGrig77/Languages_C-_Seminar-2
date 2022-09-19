// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Enter Week's day number: ");
int day = int.Parse(Console.ReadLine());

if(day == 1) Console.Write($"{day} - Nop, it is a Monday pal, got to work!");
if(day == 2) Console.Write($"{day} - Nop, it is a Tuesday pal, got to work!");
if(day == 3) Console.Write($"{day} - Nop, it is a Wednesday pal, got to work!");
if(day == 4) Console.Write($"{day} - Nop, it is a Thursday pal, got to work!");
if(day == 5) 
{
    Console.WriteLine(@$"{day} - Nop, it is a Friday pal got to work, 
    BUT! Don't forget, Friends are waiting You in the BAR tonignt! ;-)");
}
if(day == 6) Console.Write($"{day} - Yep, it is a Saturday - a Weekend! Get ready to PARTY!");
if(day == 7) Console.Write($"{day} - Yep, it is a Sunday - still a weekend, but get ready to work :-(");
if(day > 7) Console.WriteLine("Come on, it's a week, enter number from 1 to 7!");
