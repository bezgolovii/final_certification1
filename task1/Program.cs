// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] inputArray = new string[] { "aa", "bbbb", "c", "dddd", "e", "ff", "ggg", "hhhh", "iii", "jjj" };

string[] shortStrings = new string[0];

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        string[] temp = new string[shortStrings.Length + 1];
        Array.Copy(shortStrings, temp, shortStrings.Length);
        temp[shortStrings.Length] = inputArray[i];
        shortStrings = temp;
    }
}

foreach (string s in shortStrings)
{
    Console.Write(s + " , ");
}
