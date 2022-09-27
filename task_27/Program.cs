/*
    Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    452 -> 11

    82 -> 10

    9012 -> 12
*/

int GetNumber(string message)
{
    int result = 0;
    bool correctInput = false;

    while (!correctInput)
    {
        Console.WriteLine(message);
        correctInput = int.TryParse(Console.ReadLine(), out result);

        if (result < 1)
            correctInput = false;

        if (!correctInput)
            Console.WriteLine("Вы ввели некорректное число");

        Console.WriteLine();
    }

    return result;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine($"{prefix} {value}");
}

int GetSumm(int number)
{
    int result = 0;

    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }

    return result;
}

int number = GetNumber("Введите чиcло: ");
int summ = GetSumm(number);

PrintData($"Сумма цифр числа {number} - ", summ.ToString());
