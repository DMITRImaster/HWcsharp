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
/*

int ending(int numdel)  //модуль вывода второй цифры трехзначного числа
{
    //Console.WriteLine("Ваше число " + numdel);n
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
