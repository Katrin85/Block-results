﻿//Задача: Написать программу, которая из имеющегося массива строк
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] InputArray(int n)
{
    string[] inputArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        inputArray[i] = Console.ReadLine();
    }
    return inputArray;
}
string[] SortArray(string[] inputArray)
{
    string[] sortArray = new string[inputArray.Length];
    int j = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            sortArray[j] = inputArray[i];
            j++;
        }
    }
    return sortArray;
}
void OutputArray(string[] outputArray)
{
    for (int i = 0; i < outputArray.Length; i++)
        Console.Write(outputArray[i] + "    ");
}
