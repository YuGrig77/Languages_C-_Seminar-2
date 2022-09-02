// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Enter numbers: ");
int a = int.Parse(Console.ReadLine());

int second = (a % 100)/10;

Console.WriteLine($"{a} -> {first}");
