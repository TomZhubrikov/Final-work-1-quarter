string[] ArrayOfString = { "asdfsdj", "dfsdaf", "/", "asd", ";adjgji" }; // Задаём массив строк.
Console.WriteLine($"[{string.Join(", ", ArrayOfString)}]"); // Вывод исходного массива.

string[] GetResult(string[] ArrayOfString)
// Метод, получающий массив строк из элементов исходного массива длина которых не превышает 3.
{
    string[] ResultArray = new string[5];
    int i, j;
    for (i = 0, j = 0; i < ArrayOfString.Length; i++)
    {
        if (ArrayOfString[i].Length <= 3)
        {
            ResultArray[j] = ArrayOfString[i];
            j++;
        }
    }
    return ResultArray;
}

Console.WriteLine($"[{string.Join(", ", GetResult(ArrayOfString))}]"); // Вывод полученного массива.
