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

string[] myArr = {"1234", "1567", "-2", "computer science"};