// 16. Напишите программу, которая принимает на вход два числа и 
//проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();

Console.Write("Enter first numbers: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second numbers: ");
int b = int.Parse(Console.ReadLine());

if ((a == b * b) || (b == a * a)) // || - или, && - и
{
    Console.WriteLine($"{a}, {b} -> Yes");
}
else
{
    Console.WriteLine($"{a}, {b} -> No");
}
