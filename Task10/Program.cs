// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if ((number > 99) & (number < 1000))
{
    int result1 = number/10;
    int result = result1%10;
    Console.WriteLine($"Вторая цифра числа {number} - это {result}");
}
else
{
    Console.WriteLine("Задано неверное число. Введите число состоящее из трех символов!");
}
