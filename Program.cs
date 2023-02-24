/* Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int a = Enter();
int find = 0;
int result = 0;
Summ(a);
Console.Write($"Суммы цифр равна -> {result}");

int Length()
{
    int len = a.ToString().Length;
    return len;
}

int Summ(int a)
{
    for (int i = 0; i < Length(); i++)
    {
        find = a - a % 10;
        result = result + (a - find);
        a = a / 10;
    }
    return result;
}

int Enter()
{
    int n;
    Console.Write("Введите число: ");
    int.TryParse(Console.ReadLine()!, out n);
    return n;
}

