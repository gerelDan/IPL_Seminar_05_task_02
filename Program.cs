﻿// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последнюю строку массива.
int [,] FillArray(int columns, int rows, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
void Exchange(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0)-1, i];
        arr[arr.GetLength(0)-1, i] = temp;
    }
}

int [,] arr = FillArray(5, 5, 0, 10);
PrintArray(arr);
Exchange(arr);
Console.WriteLine();
PrintArray(arr);