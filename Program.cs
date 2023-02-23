/* Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int a = Enter();
int[] array = { 0 }, Summ();
int result = Summ();
Console.Write($"{3}, {5} -> {result}");

string Length()
{
    string str = a.ToString(); ;
    return str;
}

int[] Summ(int _a)
{
    for (int i = 0; i < a; i++)
    {
        array[i] = Length()[i];
        int q = array[i];
        _a = a;
    }
    return array;
}

int Enter()
{
    int n;
    Console.Write("Введите число: ");
    int.TryParse(Console.ReadLine()!, out n);
    return n;
}

