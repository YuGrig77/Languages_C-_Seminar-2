// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

if (100 <= num && num < 1000)
{
    int ThirdDigit = num-((num/10)*10); 
    Console.WriteLine($"{num} -> {ThirdDigit}");
}
if (0 <= num && num < 100)
{
    Console.WriteLine($"{num} -> there is no third digit");
}
if (num > 999)
 {
    Console.WriteLine(num.ToString()[2]); // выводит в string
 }