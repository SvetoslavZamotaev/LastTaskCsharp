﻿// Создать репозиторий на GitHub
// Создать readme-файл c описанием основных пунктов решения задачи.
// Дополнительно добавить в репозиторий блок-схему с алгоритмом самой сложной
// (по вашему мнению) части задачи из п.2
// Написать программу, решающую поставленную задачу
// Вся работа разбивается на логические единицы зафиксированнаые отдельным коммитом
// Задача: Написать программу, которая из сформированного массива строк содержащих 
// символы и числа создать массив из строк, в который попадут только символы, не являющиеця цифрами.
// Входные данные можно получить путём ввода с клавиатуры, но лучше сделать автогенерацию данных.
//  При решении не использовать "читерство".

string MakeRandomWords(int length)
{
    char[] collect = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'a', 's', 'd' };
    int len = collect.Length;
    char[] result = new char[length];
    for (int i = 0; i < length; i++)
    {
        int rand = new Random().Next(0, len);
        result[i] = collect[rand];
    }
    string resu = new string(result);
    return resu;
}
Console.WriteLine(MakeRandomWords(8));