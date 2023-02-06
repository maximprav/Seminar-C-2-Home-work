// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if ((number > 99) & (number < 1000))
{
    int result = number%10;
    Console.WriteLine($"Третья цифра числа {number} - это {result}");
}
else if ((number > -1) & (number < 100))
{
    Console.WriteLine($"Третья цифра у числа {number} отсутствует");
}
else if (number < 0)
{
    Console.WriteLine($"Неверно задано число!");
}
else if (number > 999) 
{
    int newNumber = number;
    while (newNumber > 999)
    {
        newNumber = newNumber/10;
    }

Console.WriteLine($"Третья цифра числа {number} - это {newNumber%10}");
}