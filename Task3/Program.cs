//12. Напишите программу, которая будет 
//принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа 
//выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Clear();

Console.Write("Enter first numbers: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second numbers: ");
int b = int.Parse(Console.ReadLine());

if (0 == a % b)
{
    Console.WriteLine($"{a} кратное {b}");
}
else
{
    int c = a % b;
    Console.WriteLine($"{a} не кратно {b}, Остаток -> {c}");
}
