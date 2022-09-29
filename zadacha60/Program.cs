// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

int n1 = InputInt("Введите размерность 1: ");
int n2 = InputInt("Введите размерность 2: ");
int n3 = InputInt("Введите размерность 3: ");
int count = 89;

if (n1 * n2 * n3 > count)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] result = ResultArray(n1, n2, n3);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int k = 0; k < result.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {result[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] ResultArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[count];
    int num = 10;
     
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int t = values[i];
        values[i] = values[randomInd];
        values[randomInd] = t;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}