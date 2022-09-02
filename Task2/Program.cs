//11. Напишите программу, которая выводит 
//случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//0782 -> 72
//918 -> 98

Console.Clear();

int a = new Random().Next(100, 1000);
int first = a/100; // first digit
int mid = a/10; // second digit
int last = a-mid*10; // third digit

Console.WriteLine($"{a} -> {first}{last}");

//++Other solution++

//int num = new Random().Next(100, 1000);
//int a1 = num % 10;
//int a2 = num / 10;
//int a3 = num / 100;
//int X= a1 + a3*10;
//Console.WriteLine($"{num} - > {X}");

// ++OR++

//int num = new Random().Next(100, 1000);
//int a1 = num % 10;
//int a2 = num / 100;
//Console.WriteLine($"{num} -> {a2 * 10 + a1}");
