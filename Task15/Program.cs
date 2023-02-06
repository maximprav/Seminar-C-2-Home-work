// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите очередность интересующего дня недели");
int number = int.Parse(Console.ReadLine());
if ((number > 0) & (number < 6))
{
    Console.WriteLine("Увы! Сегодня на работу!");
}
else if ((number == 6) || (number == 7))
{
    Console.WriteLine("Ура! Сегодня выходной!");
}
else if ((number < 1) || (number > 7))
{
    Console.WriteLine("Введенные данные не соответствуют дню недели!");
}