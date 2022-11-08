int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
       

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] CreateRandom2dArrayDouble()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    double maxValue = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = minValue + new Random().NextDouble() * (maxValue - minValue);
       

    return array;
}

void Show2dArrayDouble(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 2) + " ");

        Console.WriteLine();    
    }
}
/*
double[,] array = CreateRandom2dArrayDouble();
Show2dArrayDouble(array);
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = CreateRandom2dArray();
Show2dArray(array);
Console.Write("Imput row number: ");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Imput column number: ");
int column = Convert.ToInt32(Console.ReadLine()) - 1;

if(row < array.GetLength(0) && column < array.GetLength(1))
    Console.WriteLine(array[row, column]);
else 
    Console.WriteLine($"{row + 1} {column + 1} - no such number");


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[] SumAverage2dArray(int[,] array)
{
    double[] avg = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        avg[j] = sum / array.GetLength(0);
    }
    return avg;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");

    Console.WriteLine();
}
/*
int[,] array = CreateRandom2dArray();
Show2dArray(array);
Console.WriteLine();
ShowArray(SumAverage2dArray(array));
*/