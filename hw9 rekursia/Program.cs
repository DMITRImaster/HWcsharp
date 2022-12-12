//Home work #9

//Задача 64:Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNum(int n)
{

    if (n>=1) 
    {
        Console.Write($"{(n)}, ");
        ShowNum(n-1);
    }
}

Console.WriteLine("input  N: ");
int n1 = Convert.ToInt32(Console.ReadLine());

ShowNum(n1);
Console.WriteLine();

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120


int ShowSum(int m, int n)
{
    
    if (m<n) return ShowSum(m,n-1)+n;
    else return m;
 
}

Console.WriteLine("input  smal M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input  bigest N: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Sum digits from M to N = ");

Console.WriteLine(ShowSum(Math.Min(N,M), Math.Max(N,M)));

// Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную

void Binar(int n)
{
    if (n>0)
    {
        Binar(n/2);
        Console.Write(n%2);
    }
    else if (n==0) Console.Write(n);
    else Console.Write("num must be > 0 ");
}
Console.WriteLine("Enter num ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Binar num");
Binar(num);