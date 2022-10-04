string[] array = {"hello", "2", "world", ":-)", "123", "1"};

string[] FilterArray(string[] arr)
{
    string[] processedArray = new string[arr.Length];
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            processedArray[counter] = arr[i];
            counter++;
        }
    }

    return processedArray;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintArray(FilterArray(array));