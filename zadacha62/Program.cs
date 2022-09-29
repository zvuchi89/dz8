//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, m];

int n = 1;
int i = 0;
int j = 0;

while (n <= m * m)
{
    matrix[i, j] = n;
    if (i <= j + 1 && i + j < m - 1)
        ++j;
    else if (i < j && i + j >= m - 1)
        ++i;
    else if (i >= j && i + j > m - 1)
        --j;
    else
        --i;
    ++n;
}

PrintArray(matrix);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
