void printArray(string[] array)
{
    Console.Write("[");
    foreach (string elements in array)
    {
        Console.Write($"\"{elements}\",");
    }
    Console.Write("]");
}

//красивый вывод как в примере
void printFixArray(string[] array, string[] newArray)
{
    printArray(array);
    Console.Write("->");
    printArray(newArray);
}


