// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные четные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string AllNumbersToN(int start, int end)
{
    if (end % 2 == 0)
    {
        if (start == end)
        {
            return end.ToString();
        }
        return (end + " " + AllNumbersToN(start, end - 2));
    }
    else
    {
        if (start == end - 1)
        {
            int c = end - 1;
            return c.ToString();
        }
        return (end - 1 + " " + AllNumbersToN(start, end - 2));
    }
}


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(AllNumbersToN(2, N));