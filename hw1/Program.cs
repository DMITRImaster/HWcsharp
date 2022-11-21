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
    Console.WriteLine("Введеное число является полиндромом");
   else  Console.WriteLine("Введеное число НЕ  полиндром");
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