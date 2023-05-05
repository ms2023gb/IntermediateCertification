/*
    Задача: Написать программу, которая из имеющегося массива строк 
    формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
    Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    Примеры:

    ["Hello", "2", "world", ":-)"] → ["2", ":-)"]

    ["1234", "1567", "-2", "computer science"] → ["-2"]

    ["Russia", "Denmark", "Kazan"] → []
*/

Console.Clear();
const int len = 3;

string[] array = new string[] { "Hello", "2", "world", ":-)" };
PrintArray(array);
PrintArray(FindInArray(array));
System.Console.WriteLine();

array = new string[] { "1234", "1567", "-2", "computer science" };
PrintArray(array);
PrintArray(FindInArray(array));
System.Console.WriteLine();

array = new string[] { "Russia", "Denmark", "Kazan" };
PrintArray(array);
PrintArray(FindInArray(array));

/* 
    Метод создание нового массива за два цикла перебора
    Первый раз считаем количество нужных элементов
    Создаем массив нужного размера и вторым циклом заполняем новый массив

*/

string[] FindInArray(string[] arrayForFind)
{
    int count = 0;
    for (int i = 0; i < arrayForFind.Length; i++)
    {
        if (arrayForFind[i].Length <= len)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int index = 0;
    for (int j = 0; j < arrayForFind.Length; j++)
    {
        if (arrayForFind[j].Length <= len)
        {
            newArray[index] = arrayForFind[j];
            index++;
        }
    }
    return newArray;
}

void PrintArray(string[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}