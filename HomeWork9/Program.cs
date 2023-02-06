// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 // Выполнить с помощью рекурсии.    
/*
void ShowNumbers(int n)
 {
    Console.Write(n + " ");
    if (n > 1) ShowNumbers(n - 1);
    if (n < 1) ShowNumbers(n + 1);
 }
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все натуральные числа в промежутке от n до 1: "); 
ShowNumbers(n);
Console.WriteLine();
*/

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ShowNumbers(int m, int n, int sum = 0)
{
    if (m == n)
    {
    return sum += m;
    }
    else
    {
    sum += m;
    return ShowNumbers(++m, n, sum);
    }
}
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = ShowNumbers(m, n);
Console.WriteLine($"Сумма всех натуральных числ в данном промежутке равна {sum}");
Console.WriteLine();
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных
/*
int Akkerman(int m, int n)
{
    if (m == 0)
    {
    return n + 1;
    }
    else if (n == 0 && m > 0)
    {
    return Akkerman(m - 1, 1);
    }
    else
    {
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

void AkkermanFunction(int m, int n)
{
Console.WriteLine($"Функция Аккермана чисел {m} и {n} равна: ");
Console.Write(Akkerman(m, n)); 
Console.WriteLine();
}

Console.Write("Введите число m (неотрицательное и не больше 5, так как функция Аккермана растет очень быстро): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n (неотрицательное и не больше 5, так как функция Аккермана растет очень быстро): ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m,n);
*/

