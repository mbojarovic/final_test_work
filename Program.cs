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

//функция узнаем сколько элементов  массива  меньше или равно n символа и фильтрации.
string[] arrayOfLengthThreeStrings(string[] array, int value)
{

    int cnt = 0;
    foreach (string elements in array)
    {
        if (elements.Length <= value)
        {
            cnt++;
        }
    }
    string[] newArray = new string[cnt];

    cnt = -1;

    foreach (string elements1 in array)
    {
        if (elements1.Length <= value)
        {
            cnt++;
            newArray[cnt] = elements1; // используем каунт как индексацию новава массива
        }
    }
    return newArray;
}

int num = 3; //сколько элементов  массива  меньше или равно num
string[] array = new string[] { "ccc", "4444", "hello", "22", "bbs", "world", "asd", "ttt" };
string[] newArray = arrayOfLengthThreeStrings(array, num);
printFixArray(array, newArray);


