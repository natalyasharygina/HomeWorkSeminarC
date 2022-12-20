// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;

if (a == b) 
{ 
    Console.WriteLine("Числа одинакое, введите другие!");  
}
else 
{
if (a > b) 
{
    max = a; min = b;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
else
{
    max = b; min = a;    
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
}

*/
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) 
{
    Console.WriteLine($"Число {a} является ЧЕТНЫМ");
}
else 
{
    Console.WriteLine($"Число {a} является НЕЧЕТНЫМ");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int a = 1;

if (n <= 1)
{
    Console.WriteLine("Нет результата соответствующего условию задачи");
}
else
    while(a <= n)
    {
      if (a % 2 == 0)
      {
         Console.Write(a + " ");
      }
    a = a + 1;
    }
*/
