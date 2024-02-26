/*string[] ArrayToArray(string[] array)
{
    string[] newArray = new string[2];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

string[] x = { "A", "B", "C", "D", "E", "F", "G" };
Console.WriteLine(ArrayToArray(x));*/

string[] ArrayToArray(string[] array)
{
    string[] newArray = new string[3];
    Array.Copy(array, newArray, 3);
    return newArray;
}

string[] x = { "A", "B", "C", "D", "E", "F", "G" };

void PrintChar(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

PrintChar(ArrayToArray(x));
