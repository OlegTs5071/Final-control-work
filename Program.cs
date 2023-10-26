/*
Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами.
*/
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine();

int GetNumber(int max)
{
    int n = new Random().Next(max);
    return n;
}
int max = 8;
int j = 0;
int n = GetNumber(max);
Console.WriteLine(n);

string[] StrArray(int n)
{    
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите символы");
        array[i] = Console.ReadLine();                      
    }
    return array;
}

string[] show = StrArray(n);
PrintArray(show);
Console.WriteLine();

string[] CountSymbols(string[] array)
{
    int m = 4;
    int k = array.Length;   
    string[] result = new string[k];
    for (int i = 0; i < k; i++)
    {
        string number = array[i];
        int c = number.Length;
        if (c < m)
        {
            result[j] = number;
            j++;
        }
    }
    return result;
}

string[] result = CountSymbols(show);
PrintArray(result);
