// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// string[] inputArray = new string[] { "aa", "bbbb", "c", "dddd", "e", "ff", "ggg", "hhhh", "iii", "jjj" };

// string[] shortStrings = new string[0];

// for (int i = 0; i < inputArray.Length; i++)
// {
//     if (inputArray[i].Length <= 3)
//     {
//         string[] temp = new string[shortStrings.Length + 1];
//         Array.Copy(shortStrings, temp, shortStrings.Length);
//         temp[shortStrings.Length] = inputArray[i];
//         shortStrings = temp;
//     }
// }

// foreach (string s in shortStrings)
// {
//     Console.Write(s + " , ");
// }

string[] array1 = new string[6] {"257", "45", "hello", "world", "res","456"};
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray(array2);