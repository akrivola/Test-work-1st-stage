﻿// Итоговая проверочная работа для проверки знаний
// и навыков по итогу прохождения первого блока 
// обучения на программе разработчик

// Написать программу, которая из имеющегося массива 
// строк формирует массив из строк, длина которых меньше, 
// либо равна 3 символа. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);
        if (i != array.GetLength(0))
            Console.Write(",");
    }
    Console.Write("]");
}

string[] arrayTest1 = {"hello", "2", "world", ":-)"};
string[] arrayTest2 = {"1234", "1567", "-2", "computer science"};
string[] arrayTest2 = {"Russia", "Denmark", "Kazan"};

printArray(arrayTest1);