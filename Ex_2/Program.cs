// Задача №2. Задать двумерный массив следующим правилом: Aₘₙ = m+n.

void PrintArray(int[,] A)
{
    for (int m = 0; m < A.GetLength(0); m++)
    {
        for (int n = 0; n < A.GetLength(1); n++)
        {
            Console.Write($"{A[m, n]} | ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] A)
{       
    for (int m = 0; m < A.GetLength(0); m++)
    {
        for (int n = 0; n < A.GetLength(1); n++)
        {
            A[m, n] = m + n;            
        }
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];

FillArray(matrix);
PrintArray(matrix);