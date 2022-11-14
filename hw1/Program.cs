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
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter number N");
int number = Convert.ToInt32(Console.ReadLine());
int index=2;
Console.WriteLine("Четные числа от 1 по "+number);
while (index <= number ) {    Console.Write(index+", ");
index=index+2;
}
