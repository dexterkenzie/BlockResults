using System;
using static System.Console;

Clear();

// Задача:
// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 

// Пример:
// ["hello", "2", "world", ":-)"] ==> ["2", ":-)"]

string[] FindLessThan(string[] input, int n)
{
    string[] output = new string[CountLessThan(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}