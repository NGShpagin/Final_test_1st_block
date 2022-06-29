// Создание массива, путемм ввода каждого элемента массива с клавиатуры
string[] CreateArray()
{
    string text = string.Empty;
    int len = 0;
    string[] myArray = new string[len];
    while (true)
    {
        Console.WriteLine("Print element for massive: ");
        text = Console.ReadLine();
        if (text == "q") break;
        len++;
        Array.Resize(ref myArray, len);
        myArray[len-1] = text;
    }
    return myArray;
}

// Выделение элементов, состоящие из менне 4 символов, из входного массива в новый массив
string[] CountArray(string[] array)
{
    int len = array.Length;
    string[] resultArray = new string[len];
    int index = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length < 4)
        {
            resultArray[index] = array[i];
            index++;
        }
    }
    Array.Resize(ref resultArray, index);
    return resultArray;
}

// Печать входного массива
string PrintArray(string[] array)
{
    string txt = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        txt += $"{array[i]}; ";
    }
    return $"[{txt.Remove(txt.Length - 2, 2)}]";
}

string[] myArr = CreateArray();
Console.WriteLine($"My array: {PrintArray(myArr)}");
string[] resultArr = CountArray(myArr);
Console.WriteLine($"My array: {PrintArray(resultArr)}");