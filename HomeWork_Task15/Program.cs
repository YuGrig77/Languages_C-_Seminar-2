// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Enter Week's day number: ");
int day = int.Parse(Console.ReadLine());

if(day == 1) Console.Write($"{day} - Nop, It is Monday pal, got to work!");
if(day == 2) Console.Write($"{day} - Nop, It is Tuesday pal, got to work!");
if(day == 3) Console.Write($"{day} - Nop, It is Wednesday pal, got to work!");
if(day == 4) Console.Write($"{day} - Nop, It is Thursday pal, got to work!");
if(day == 5) Console.WriteLine($"{day} - Nop, It is Friday pal, got to work."); 
Console.Write("BUT! Don't forget, Friends are waiting You in the BAR tonignt!");
if(day == 6) Console.Write($"{day} - Yep, It is Saturday - a Weekend! Get ready to PARTY!");
if(day == 7) Console.Write($"{day} - Yep, It is Sunday - still a weekend, but get ready to work :-(");
if(day > 7) Console.WriteLine("Come on, it's a week, enter number from 1 to 7!");

// ++OR++

// Console.Clear();

// String[] Week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
// Console.Write("Pls enter week's day number: ");
// int num = int.Parse(Console.ReadLine());

// if (num  >= 6 && num <= 7)
// {
//     Console.WriteLine($"{num} -> Yep, {Week[num-1]} - Is a Weekend, Get ready to PARTY!");
// }
// else
// {
//     Console.WriteLine($"{num} -> Nop, {Week[num-1]} - So sad, still hve to go work :-(");
// }

