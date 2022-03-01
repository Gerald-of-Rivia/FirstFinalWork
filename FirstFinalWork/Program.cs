//Задача:
// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

using static System.Console;

void PrintStringArray(string[] springArray)
{
    Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Write($"\"{stringArray[i]}\"");
        if (i!=PrintStringArray.Length - 1)
        {
            Write(", ");
        }
    }
    Write("]");
}
int SearchStringsWithSizeLessOrEqual3(string[] stringArray)
{
    int numberOfStrings = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            numberOfStrings++;
        }
    }
    return numberOfStrings;
}

string[] CreateArrayWithSizeLessOrEqual3 (string[] stringArray, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            newStringArray[j] = stringArray[i];
            j++;
        }
    }
    return newStringArray;
}

string[] stringArray = { "hello", "word", "2", ":-)"};
PrintStringArray(stringArray);
//WriteLine(SearchStringsWithSizeLessOrEqual3(stringArray));
int sizeNewArray = SearchStringsWithSizeLessOrEqual3(stringArray);
string[] newStringArray = CreateArrayWithSizeLessOrEqual3(stringArray,sizeNewArray);
Write(" => ");
PrintStringArray(newStringArray);
WriteLine();
