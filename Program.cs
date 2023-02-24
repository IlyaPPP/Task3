/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Random();
int Random()
{
    for (int i = 0; i < 8; i++) { }
    return new Random().Next(0, 9);
}

int[] array = { Random(), Random(), Random(), Random(), Random(), Random(), Random(), Random() };

Console.Write($"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]} -> ");
Console.Write($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");

