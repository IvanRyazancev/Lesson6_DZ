// Задача №4. Написать программу, которая обменивает элементы первой строки и последней строки.

Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Исходный массив: ");

int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} | ");
    }
    Console.WriteLine();
}    

Console.WriteLine("Измененный массив: ");
for(int i = 0; i < array.GetLength(1); i++)
{   
    {
        int tmp = array[(rows - 1), i];
        array[(rows - 1), i] = array[0, i];
        array[0, i] = tmp;               
    }      
}

for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} | ");
    }
    Console.WriteLine();
}