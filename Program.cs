// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Count(int number)
{
    int Count = 0;
    if (number == 0)
    {
        Console.WriteLine("0 -> 1");
    }

    else
    {
        while (number != 0)
        {
            number = number / 10;
            Count = Count + 1;
        }
    }
    return Count;
}
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{A} -> {Count(A)}");
