// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
/*
int CurtNumber(int number)
{
    int ed = number / 10;
    int result = ed % 10;
    return result;
}

Console.Write("Введите число: ");
int randNumber = Convert.ToInt32(Console.ReadLine());

if (randNumber >= 100 && randNumber < 1000)
{
    int newNumber = CurtNumber(randNumber);
    Console.Write($"Новая версия числа {randNumber} это {newNumber}");
}
else 
{
    Console.WriteLine("Входные данные несоответствуют условию задачи");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool OfWeek(int day)
{
    if(day >= 6 && day <= 7)
    return true;
    else 
    return false;
}
Console.Write("Введите день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine()); 
if(OfWeek(dayWeek)) 
    Console.WriteLine("Данный день является выходным");
else if(dayWeek >= 1 && dayWeek <= 5)
   Console.WriteLine("Данный день не является выходным");
      else Console.WriteLine("Это не день недели!");

*/

// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdDigit (int number)
{
    while (number >= 1000)
           number = number / 10;
           int result = number % 10;
    return result;       
}

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine()); 
if (n < 100)
{
Console.WriteLine ($"Третьей цифры в числе {n} нет");
}
else
{
int newNumber = ThirdDigit(n);
Console.WriteLine($"Третья цифра числа {n} это {newNumber}");
}
*/