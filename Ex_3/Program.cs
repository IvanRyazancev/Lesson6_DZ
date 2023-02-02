// Задача №3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{          
    for (int i = 0; i < matr.GetLength(0); i++)
    {   
        Random random = new Random();
        for (int j = 0; j < matr.GetLength(1); j++)
        {                     
            matr[i, j] = random.Next(10);                                   
        }
    }
}

void ChangeArray(double[,] matr)
{          
    for (int i = 0; i < matr.GetLength(0); i++)
    {           
        for (int j = 0; j < matr.GetLength(1); j++)
        {                        
            if (i % 2 == 0 && j % 2 == 0)
            {                
                matr[i, j] = Math.Pow(matr[i, j], 2);
            }                        
        }
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[rows, columns];

Console.WriteLine("Исходный массив: ");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Измененный массив: ");
ChangeArray(matrix);
PrintArray(matrix);