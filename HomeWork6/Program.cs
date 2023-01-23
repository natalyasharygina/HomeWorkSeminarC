// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите количество чисел для ввода с клавиатуры: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
        count = count + 1;
}
Console.WriteLine($"Чисел больше 0: {count}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Даны уравнения двух прямых y = k1 * x + b1, y = k2 * x + b2, надо ввести данные для вычисления точки пересечения. Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
if(k1 == k2)
{
Console.WriteLine("Данные прямые параллельны, не имеют точки пересечения");
}
else if(k1/k2 == b1/b2)
{
   Console.WriteLine("Данные прямые совпадают"); 
}
else
{
double x = -(b1 - b2) / (k1 - k2); x = Math.Round(x, 2);
double y = k1 * x + b1; y = Math.Round(y, 2);
Console.WriteLine($"Точка пересечения данных прямых имеет координаты: ({x};{y})");
}
*/