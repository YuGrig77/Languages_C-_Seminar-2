//11. Напишите программу, которая выводит 
//случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//0782 -> 72
//918 -> 98

Console.Clear();

int a = new Random().Next(100, 1000);
int first = a / 100; // first digit
int mid = a / 10; // second digit
int last = a - mid * 10; // third digit

Console.WriteLine($"{a} -> {first}{last}");
