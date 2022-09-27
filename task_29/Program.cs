/*
    Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

    6, 1, 33 -> [6, 1, 33]

    ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/

Console.WriteLine("Введите элементы через запятую!");

string inputStr = Console.ReadLine() ?? "";
string[] words = inputStr.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
int[] arr = new int[8];

for (int i = 0; i < words.Length; i++)
{
    arr[i] = int.Parse(words[i]);
}

Console.WriteLine("[{0}]", string.Join(", ", arr));