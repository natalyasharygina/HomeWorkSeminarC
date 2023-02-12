// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] newArray = CreateRandom2dArray();
Show2dArrey(newArray);

void decreasing2dArray()
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
    for (int r = 0; r < newArray.GetLength(1) - 1; r++)
    {
      if (newArray[i, r] < newArray[i, r + 1])
      {
       int temp = newArray[i, r + 1];
       newArray[i, r + 1] = newArray[i, r];
       newArray[i, r] = temp;
      }
    }
    }
    }
}
Console.WriteLine("Отсортированный по убыванию массив:");
decreasing2dArray();
Show2dArrey(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void MinSumElements(int[,] newArray)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < newArray.GetLength(1); i++)
    {
    minRow += newArray[0, i];
    }
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) 
        sumRow += newArray[i, j];
        if (sumRow < minRow)
        {
        minRow = sumRow;
        minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine();
    MinSumElements(newArray);
    Console.WriteLine($"{minSumRow + 1} - строка с наименьшей суммой элементов");
}
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] Create2dArray()
{
    Console.WriteLine("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введеите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
        array[i, j] = rnd.Next(100);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write("\t" + array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void CreateProductMatrices(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
        int sum = 0;
        for(int k = 0; k < firstMatrix.GetLength(1); k++)
        {
        sum += firstMatrix[i, k] * secondMatrix[k, j];
        }
        resultMatrix[i, j] = sum;
        }
    }
}
Console.WriteLine("Первая матрица");
int[,] firstMatrix = Create2dArray();
Console.WriteLine("Вторая матрица");
int[,] secondMatrix = Create2dArray();
Show2dArray(firstMatrix);
Show2dArray(secondMatrix);
if(firstMatrix.GetLength(0) == secondMatrix.GetLength(1))
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    CreateProductMatrices(firstMatrix, secondMatrix, resultMatrix);
    Console.WriteLine("Произведение данных матриц: ");
    Show2dArray(resultMatrix);
}
else Console.WriteLine("Введите другие значения, данные матрицы не возможно умножить друг на друга");
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] Create2dSpiralArray(int rows, int columns, int initialvalue)
{
int[,] array = new int[rows, columns];
int i = 0, j = 0;
int moveUp = 0, moveDown = 0, moveLeft = 0, moveRight = 0;
while(initialvalue <= rows * columns)
    {
    array[i, j] = initialvalue;
    if(i == moveUp && j < columns - 1 - moveRight) j++;
    else if(j == columns - 1 - moveRight && i < rows - 1 - moveDown) i++;
    else if(i == rows - 1 - moveDown && j > moveLeft) j--;
    else i--;
    if ((i == moveUp + 1) && (j == moveLeft) && (moveLeft != columns - 1 - moveRight))
    {
    moveUp++;
    moveDown++;
    moveLeft++;
    moveRight++;
    }
    initialvalue++;
    }
    return array;
    }
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write("\t" + array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый элемент матрицы: ");
int initialvalue = Convert.ToInt32(Console.ReadLine());
int[,] spiralArray = Create2dSpiralArray(rows, columns, initialvalue);
Show2dArray(spiralArray);
*/