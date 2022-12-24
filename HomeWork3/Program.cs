// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int N)
{
    int count = 1;
    while (count <= N)
    {
        int z = count * count * count;
        Console.WriteLine($"куб от {count} - {z}");
        count++;
    }
}

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Cube(numN);
*/

// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double distance(double x1pos, double y1pos, double z1pos, double x2pos, double y2pos, double z2pos)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2pos - x1pos, 2) + Math.Pow(y2pos - y1pos, 2) + Math.Pow(z2pos - z1pos, 2)), 2);
}

Console.Write("Введите x числа А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y числа А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z числа А: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x числа B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y числа B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z числа B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Расстояние между точками А и В: ");
Console.WriteLine(distance(x1, y1, z1, x2, y2, z2));
*/

// Задача 19
// Напишите программу, которая принимает на вход 
//число и проверяет, является ли оно палиндромом.
/*
bool Palindrome(int num)
{
    int rez = 0;
    int newnum = num;
    while (num > 0)
    {
         rez = rez * 10 + num % 10;
         num = num / 10;
    }
    return rez == newnum;
}

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine()); 
if (Palindrome(n))
    Console.WriteLine($"Число {n} является палиндромом");
else    Console.WriteLine($"Число {n} не является палиндромом");
*/