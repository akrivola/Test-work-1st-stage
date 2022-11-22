// Итоговая проверочная работа для проверки знаний
// и навыков по итогу прохождения первого блока 
// обучения на программе разработчик

// Написать программу, которая из имеющегося массива 
// строк формирует массив из строк, длина которых меньше, 
// либо равна 3 символа. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void printArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i != array.GetLength(0) - 1)
            Console.Write(", ");
    }
    Console.Write("]");
}

string[] RemoveOver3Symbols(string[] array)
{
    string[] result = new string[array.GetLength(0)];
    int countResult = 0;
    for (int countArray = 0; countArray < array.GetLength(0); countArray++)
    {
        if (array[countArray].Length <= 3)
            {
                result[countResult] = array[countArray];
                countResult++;
            }
    }
    return result;
}

string[] arrayTest1 = {"hello", "2", "world", ":-)"};
string[] arrayTest2 = {"1234", "1567", "-2", "computer science"};
string[] arrayTest3 = {"Russia", "Denmark", "Kazan"};

printArray(arrayTest1);
Console.Write("->");
printArray(RemoveOver3Symbols(arrayTest1));
Console.WriteLine();