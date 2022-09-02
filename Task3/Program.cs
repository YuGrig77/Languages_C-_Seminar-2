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

// ++OR++

// Console.WriteLine("Введите первое число ");
// int number1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число ");
// int number2 = int.Parse(Console.ReadLine());

// int max = 0;

// if (number1 > number2)
// {
//     max = number1 % number2;
// }
// else
// {
//     max = number2 % number1;
// }
// if (max == 0)
// {
//     Console.WriteLine($"{number1}, {number2} -> кратно");
// }
// else
// {
//     Console.WriteLine($"{number1}, {number2} -> некратно, остаток {max}");
// }
