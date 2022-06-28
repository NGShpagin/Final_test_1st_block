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



string PrintArray(string[] array)
{
    string txt = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        txt += $"{array[i]}; ";
    }
    return $"[{txt.Remove(txt.Length - 2, 2)}]";
}

string[] myArr = { "1234", "1567", "-2", "computer science" };
Console.WriteLine($"My array: {PrintArray(myArr)}");
string[] resultArr = CountArray(myArr);
Console.WriteLine($"My array: {PrintArray(resultArr)}");