// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
/*
int Degree(int numA, int numB)
{
   int numAB = 1;
   int n = 1;
    while (n <= numB)
    {
         numAB = numAB * numA;
         n ++;
    }
    return numAB;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
Console.Write($"Данное число, это {a} в степени {b}: ");
Console.WriteLine(Degree(a, b));
}
else Console.WriteLine("Введите натуральное число");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateArray(int size)
{
int[] array = new int[size];
for(int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1} элемент массива : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}
void ShowArrey(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArrey = CreateArray(length);
ShowArrey(newArrey);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int number)
{
    int result = 0;
    while (number > 0)
           {
           result = result + (number % 10);
           number = number / 10;
           }
    return result;       
}
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write($"Сумма цифр числа {n}: ");
Console.WriteLine(Sum(n));
*/
