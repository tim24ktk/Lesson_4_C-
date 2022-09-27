/*
    Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    3, 5 -> 243 (3⁵)

    2, 4 -> 16
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

int numberA = GetNumber("Введите число А: ");
int numberB = GetNumber("Введите число B: ");
int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result *= numberA;
}

Console.WriteLine(result);
