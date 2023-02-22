/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int a = Enter();
int b = Enter();

double result = Stepen(a, b);

Console.Write($"{3}, {5} -> {result}");

double Stepen(int a, int b)
{
    return Math.Pow(a, b);
}

int Enter()
{
    int n;
    Console.Write("Введите число: ");
    int.TryParse(Console.ReadLine()!, out n);
    return n;
}

