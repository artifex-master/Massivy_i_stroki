// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.
char[,] arr = new char[,]{{'a', 'b', 'c'},{'d', 'e', 'f'}};
string str = "";

for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        str += arr[i, j];
    }
}

Console.WriteLine(str);

