using System;

string[] array = new string[4] {"Hi", "Hello", "Boy", "Girl"};
string[] newArray = new string[array.Length];

void MethodSortArray(string[] array1, string[] array2)
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
        Console.Write(array[i] + " ");
    }
}

MethodSortArray(array, newArray);
PrintArray(newArray);
