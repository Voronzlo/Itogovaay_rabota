string[] array = {"10", "Word", "yes"};

PrintArray(array);
Console.WriteLine();
string[] array2 = GetNewArray(array);
PrintArray(array2);

string[] GetNewArray(string[] array)
{ 
    string[] arr = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[count] = array[i];
            count++;
        }
    }
    return arr;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
