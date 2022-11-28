// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Enter number1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 ) {    Console.WriteLine($"Первое число {number1} больше второг {number2}");}

if (number2 > number1 ) {   Console.WriteLine($"Второе {number2} число больше первого {number1}");}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Enter number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number3");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max ) {    max=number2;}
if (number3 > max ) {    max=number3;}
Console.WriteLine($"Максимальное введеное число {max} ");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Enter number1");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1%2 == 0 ) {    Console.WriteLine($"Введеное число четное");}
else {    Console.WriteLine($"Введеное число  нечетное");}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter number N");
int number = Convert.ToInt32(Console.ReadLine());
int index=2;
Console.WriteLine("Четные числа от 1 по "+number);
while (index <= number ) {    Console.Write(index+", ");
index=index+2;
}
*/


// *** Home work 2!!! ***
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int second(int numdel)  //модуль вывода второй цифры трехзначного числа
{
    //Console.WriteLine("Ваше число " + numdel);
    int new_num=numdel/10%10; //выборка второй цифры
    return new_num;
}

Console.WriteLine("Ввведите число от 100 до 1000: ");
int usernum=Convert.ToInt32(Console.ReadLine());
if (usernum >=100 && usernum <1000)
{
Console.WriteLine($"Среднее число {second(usernum)}");
}
else Console.WriteLine( "вы ввели число не в диапозоне!!!");


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int ending(int numdel)  //модуль вывода второй цифры трехзначного числа
{
    //Console.WriteLine("Ваше число " + numdel);
    while (numdel>1000)    numdel/=10;
    Console.WriteLine("Ваше число " + numdel);
     int new_num= numdel%10;
    return new_num;
}

Console.WriteLine("Ввведите число от 100: ");
int usernum=Convert.ToInt32(Console.ReadLine());
if (usernum >=100)
{
Console.WriteLine($"Третье число {ending(usernum)}");
}
else Console.WriteLine( "Третьей цифры нет");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Ввведите день недели от 1 до 7: ");
int usernum=Convert.ToInt32(Console.ReadLine());
if (usernum >=1 && usernum <8)
{ if (usernum >5) Console.WriteLine($"Ура, это выходной день!!!");
else Console.WriteLine($"Это не выходной день!!!");
}
else Console.WriteLine( "вы ввели число не в диапозоне!!! ");
*/

//*** Home work 3!!! ***
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void poli(int num)  //модуль поиска полиндрома
{
    if (num/10000 == num%10 && num/1000%10 == num/10%10)
    Console.WriteLine("Введеное число является полиндромом!");
   else  Console.WriteLine("Введеное число НЕ  полиндром!");
}


Console.WriteLine("Ввведите пятизначное число: ");
int curent=Convert.ToInt32(Console.ReadLine());

if (curent >=10000 && curent<=99999)
{
poli(curent);
}
else Console.WriteLine("Вы ввели не пятизначное число");
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double longline(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double  line = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
  return line;
}
Console.WriteLine("x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist=longline(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Long line: {dist:f2}");// dist:f3 вывод до 3х символов после запятой
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void cubed(int N) // Метод выводящий  таблицу кубов чисел от 1 до N
{
    int curent=1;
    while (curent<=N) 

    {Console.Write($" {curent*curent*curent}, ");
    curent++;}
    Console.Write($"\b\b.");
}

Console.WriteLine("Enter number N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сubed 1..N:");
cubed(num);


// Home work 4!!!
Console.WriteLine("Home work 4!!!");

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void stepen(int a, int b)
{int sum=1;
    for (int i=1; i<=b; i++)
    sum=sum*a;
    Console.WriteLine($"Число {a} в степени {b} = {sum}");
}

Console.WriteLine("Enter number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number b: ");
int b = Convert.ToInt32(Console.ReadLine());

stepen(a,b);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine();
Console.WriteLine("Задача 27:");

void NumSum(int num)
{
int sum=0;
int num1=num;
while (num>0)    
    {sum=sum+num%10;
    //Console.WriteLine("Остаток от деления " + num%10);
    num/=10;
    }
    
    Console.WriteLine($"sum of digits in number {num1} = {sum}");
}
Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

NumSum(num);

*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
//Console.WriteLine();
//Console.WriteLine("Задача 29:");

int[] CreatNewArray(int size, int min, int max) // Ввод массива
{
int[] array = new int[size];

for (int i=0;i<size; i++)
    array[i]= new Random().Next(min,max+1); // (min, max+1)
return array;
}

void ShowArray(int [] array) //Вывод массива
{
Console.WriteLine("Array: ");
  for ( int i=0; i<array.Length; i++) 
      Console.Write(array[i]+" ");
}

//int size=8;
//ShowArray(CreatNewArray(size,-32768,32767));

// Home work 5!!!
//Задача 34
Console.WriteLine();
Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

int find_2(int [] array, int size_array) // метод поиска четных чисел
    {
    int n=0;
    for (int i=0; i<size_array; i++)
    {
        if (array[i]%2 == 0) n++;
    }
    Console.WriteLine();
    return n;
    }

Console.WriteLine("Enter size array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array111=CreatNewArray(size,100,999);
ShowArray(array111);
Console.WriteLine();
Console.Write("Кол-во четных чисел: ");
Console.WriteLine(find_2(array111, size));

// Задача 36
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");

int find_36(int [] array, int size_array) // метод поиска четных чисел
    {
    int n=0;
    for (int i=1; i<size_array; i+=2)
    {
        n=n+array[i];
    }
    Console.WriteLine();
    return n;
    }
int [] array36=CreatNewArray(size,-100,100);
ShowArray(array36);
Console.WriteLine("Sum of odd elements:");
Console.WriteLine(find_36(array36,size));
//new Random().NextDouble();
//Math.Round(newArray[i],3)





