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
// переменные для длины строк больше или равно 1 и меньше или равно 3
int minStringLength = 1;
int maxStringLength = 3;

string[] array = new string[] { "Hello", "2", "world", ":-)" };
PrintArray(array);
PrintArray(FindInArray(array, minStringLength, maxStringLength));
System.Console.WriteLine();

array = new string[] { "1234", "1567", "-2", "computer science" };
PrintArray(array);
PrintArray(FindInArray(array, minStringLength, maxStringLength));
System.Console.WriteLine();

array = new string[] { "Russia", "Denmark", "Kazan" };
PrintArray(array);
PrintArray(FindInArray(array, minStringLength, maxStringLength));

/*
    Метод создания нового массива за один проход, путем добавление нового элемента в массив
*/

string[] FindInArray(string[] arrayForFind, int minStringLengthForFind, int maxStringLengthForFind)
{
    string[] newArray = new string[0];
    for (int i = 0; i < arrayForFind.Length; i++)
    {
        if (arrayForFind[i].Length >= minStringLengthForFind && arrayForFind[i].Length <= maxStringLengthForFind)
        {
            newArray = newArray.Append(arrayForFind[i]).ToArray();
        }
    }
    return newArray;
}

void PrintArray(string[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}