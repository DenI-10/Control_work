string[] firstArray = new string[5] { "43", "11", "array", "python", "add" };
string[] secondArray = new string[firstArray.Length];

void FormingArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FormingArray(firstArray, secondArray);
PrintArray(secondArray);
