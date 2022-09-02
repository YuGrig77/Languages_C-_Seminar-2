//11. Напишите программу, которая выводит 
//случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//0782 -> 72
//918 -> 98

Console.Clear();

int a = new Random().Next(100, 999);
int first = a/100;
int mid = a/10;
int last = a-mid*10;

Console.WriteLine($"{a} -> {first}{last}");

