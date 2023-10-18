/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


Console.Clear();

string[] userArray = { "Hello", "2", "world", ":-)"};

string[] ArrayWithElementsLess3Symbols(string[] baseArray)
{
    int size = 0;

    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length < 4) 
            size++;
    }

    string[] result = new string[size];
    int index = 0;

    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length < 4)
        {
            result[index] = baseArray[i];
            index++;
        }
    }

    return result;
}

Console.WriteLine(string.Join(", ", userArray));
string[] newArray = ArrayWithElementsLess3Symbols(userArray);
Console.WriteLine(string.Join(", ", newArray));
if (newArray.Length == 0) Console.WriteLine("элеметов нет");