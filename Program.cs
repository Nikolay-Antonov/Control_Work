string[] array = { "Hello", "2", "World", ":-)" };


void PrintArray(string[] array)
{
    int length = array.Length;
    string result = String.Empty;
    for (int i = 0; i < length; i++)
    {
        result = result + array[i] + ", ";
    }
    if (result.Length > 1) result = result.Substring(0, result.Length - 2);
    Console.Write("[" + result + "]");
}

string[] ChangeArray(string[] array)
{
    int count = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

PrintArray(ChangeArray(array));
