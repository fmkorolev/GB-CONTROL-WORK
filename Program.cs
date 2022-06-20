string[] ReadStringArrayFromConsole(string msg)
{
RepeatInput:
    Console.WriteLine(msg);
    string? strResult = Console.ReadLine();
    if (strResult != String.Empty)
    {
        string[] result = strResult.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        return result;
    }
    else
    {
        Console.WriteLine("Неверный ввод!");
        goto RepeatInput;
    }
}

void PrintStringArray(string[] array)
{
    foreach (var item in array) Console.Write($" {item} ");
    Console.WriteLine();
}

// Возвращает новый строковый массив, состоящий из элементов старого массива, длина которых не больше заданного значения
string[] NewStringArray(string[] array, int length)
{
    int amount = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            amount++;
        }
    }
    string[] result = new string[amount];
    int j=0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            result[j]=array[i];
            j++;
        }
    }
    return result;
}

string[] strArray = ReadStringArrayFromConsole("Введите элементы массива через пробел или запятую:");
Console.WriteLine("Исходный массив:");
PrintStringArray(strArray);
Console.WriteLine();
string[] newStrArray = NewStringArray(strArray, 3);
Console.WriteLine("Новый массив:");
PrintStringArray(newStrArray);
Console.WriteLine();