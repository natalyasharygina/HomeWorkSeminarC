// Задача 47. Задайте двумерный массив размером m?n, заполненный случайными вещественными числами.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
int[,] array = new int[rows, columns];
for(int i = 0; i < rows; i++)
   {
       for(int j = 0; j < columns; j ++)   
       {
        array[i,j] = new Random().Next(minValue, maxValue);
       }
   }
return array;
}

double[,] CreateRandom2dDoubleArray(int rows, int columns)
{
double[,] array = new double[rows, columns];
for(int i = 0; i < rows; i++)
   {
       for(int j = 0; j < columns; j ++)   
       {
        array[i,j] = new Random().NextDouble();
       }
   }  
return array;
}

Console.Write("Введите колличество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную значение массиива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную значение массиива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

double[,] newArray2 = CreateRandom2dDoubleArray(rows, columns);
 
double[,] CreateRandom2dDoubleArray3(int rows, int columns)
{
double[,] array = new double[rows, columns];
for(int i = 0; i < rows; i++)
    {
    for(int j = 0; j < columns; j ++)  
    array[i,j] = newArray[i,j] + Math.Round(newArray2[i,j], 2);  
    }
return array;
}

void Show2dArrey3(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}    

double[,] newArray3 = CreateRandom2dDoubleArray3(rows, columns);
Show2dArrey3(newArray3);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
Console.Write("Введите колличество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную значение массиива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную значение массиива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
for(int i = 0; i < rows; i++)
   {
       for(int j = 0; j < columns; j ++)   
       {
        array[i,j] = new Random().Next(minValue, maxValue);
       }
   }
return array;
}

void Show2dArrey(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] newArray = CreateRandom2dArray();
Show2dArrey(newArray);

int num = 0;
Console.Write("Введите интересующий индекс элемента относительно строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите интересующий индекс элемента относительно столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
if (i < newArray.GetLength(0) && j < newArray.GetLength(1)) 
{
num = newArray[i, j];
Console.WriteLine($"Индексы ({i},{j}) соответствуют элементу массива {num}");
}
else 
{
Console.WriteLine($"Элемента с индексами ({i},{j}) в массиве нет");
}
*/

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray()
{
Console.Write("Введите колличество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную значение массиива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную значение массиива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
for(int i = 0; i < rows; i++)
   {
       for(int j = 0; j < columns; j ++)   
       {
        array[i,j] = new Random().Next(minValue, maxValue);
       }
   }
return array;
}

void Show2dArrey(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] newArray = CreateRandom2dArray();
Show2dArrey(newArray);

double [] arithmeticMeanArray()
{
double [] arithmeticMeanArray2 = new double[newArray.GetLength(1)];

for(int j = 0; j < newArray.GetLength(1); j ++)
   {
    double sum = 0;
       for(int i = 0; i < newArray.GetLength(0); i++) 
       {
        sum += newArray[i,j];
       }
       arithmeticMeanArray2[j] = sum / newArray.GetLength(0);
       arithmeticMeanArray2[j] = Math.Round(arithmeticMeanArray2[j], 1);
       sum = 0;
   }
   return arithmeticMeanArray2;
}

void ShowArray2(double[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    Console.Write(newArray[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметическое каждого столбца массива:");
double[] newArray2 = arithmeticMeanArray();
ShowArray2(newArray2);
*/

