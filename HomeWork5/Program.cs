// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int[] array = new int[size];
for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue);
return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();  
}
Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;
int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);  
int evenNum = 0;
for (int j = 0; j < newArray.Length; j++)
{
if (newArray[j] % 2 == 0)
evenNum = evenNum + 1;
}
Console.WriteLine($"Четных чисел в данном массиве - {evenNum}" );  
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int[] array = new int[size];
for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);
return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную позицию массиива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную  позицию массиива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
int sum = 0;
for (int j = 1; j < newArray.Length; j = j + 2)
sum = sum + newArray[j];
Console.WriteLine($"Сумма элементов на нечетных индексах в данном массиве: {sum}" );  
//(НЕ ОЧЕНЬ ПОНЯЛА УСЛОВИЕ, ВЗЯЛА НЕЧЕТНЫЕ ИНДЕКСЫ МАССИВА).
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int[] array = new int[size];
for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue);
return array;
}

double[] CreateRandomDoubleArray(int size)
{
double[] array = new double[size];
for(int i = 0; i < size; i++)
    array[i] = new Random().NextDouble();
return array;
}

Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную значение массиива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную значение массиива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);

double[] newArray2 = CreateRandomDoubleArray(length);
 
double[] CreateRandomDoubleArray3(int size)
{
double[] array = new double[size];
for(int i = 0; i < size; i++)
    array[i] = newArray[i] + Math.Round(newArray2[i], 2);
return array;
}

void ShowArrey3(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

double[] newArray3 = CreateRandomDoubleArray3(length);
ShowArrey3(newArray3);

double difference = 0;
double maxMeaning = newArray3[0];
double minMeaning = newArray3[0];
for (int i = 0; i < newArray3.Length; i++)
{
if (newArray3[i] > maxMeaning)
maxMeaning = newArray3[i];
else if(newArray3[i] < minMeaning)
minMeaning = newArray3[i];
}
difference = maxMeaning - minMeaning;
Console.WriteLine($"Разница между максимальным {maxMeaning} и минимальным {minMeaning} значениями в данном массиве: {Math.Round(difference, 2)}"); 
*/