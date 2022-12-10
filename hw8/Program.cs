// See https://aka.ms/new-console-template for more information
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}

void FillArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(min,max+1);
        }
    }
}


//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine();
Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива");

void roundMatr(int[,] matr)
{
    int min=matr[0,0];
    int temp= 0;
   
 for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1)-1; k++)
        {
        for (int j = 0; j < matr.GetLength(1)-1; j++)
        { 
         if (matr[i,j+1]>matr[i,j])  
         {temp=matr[i,j];
         matr[i,j]=matr[i,j+1];
         matr[i,j+1]=temp;
         } 

        }
        }
        
    }
    PrintArray(matr);
}

Console.Write("input array row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("input array column: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.Write("input min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("input max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix3=new int[row,column];
FillArray(matrix3,min,max);
Console.WriteLine("This is matrix:");
PrintArray(matrix3);

roundMatr(matix3);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void numberMinRows(int[,] matr)
{
    int  sum= 0, minRows=-1, minsum=0;
    Console.WriteLine();
 for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum+=matr[i,j];
        }
        Console.Write($"{sum}  ");
        if (i==0) minsum = sum; 
        if (sum<=minsum) 
        {
        minsum=sum;
        minRows=i+1;
        }
        sum=0;
    }
    Console.WriteLine($"Result min rows is: {minRows}");
}

Console.Write("input array size: ");
int row = Convert.ToInt32(Console.ReadLine());

int column = row;

Console.Write("input min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("input max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix3=new int[row,column];
FillArray(matrix3,min,max);
Console.WriteLine("This is matrix:");
PrintArray(matrix3);
numberMinRows(matrix3);

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
void spiralArray()
{
    int [,] matr= new int[5,5];
    int imin=0,
        imax=4,
        number=10;
    
        while ( imin<=imax)
        {
        for (int i = imin; i < imax; i++)  // Заполнение верхней строки слева направо
        {   matr[imin,i]=number;
            number++;
        
        }
        
        for (int i = imin; i <= imax; i++) // Заполнение правого столбца сверху вниз 
        {
        matr[i,imax]=number;
        number++;
        }
        
        for (int i = imax-1; i >= imin; i--) //Заполнение нижней строки  cправо налево
    {
        matr[imax,i]=number;
        number++;
    }
    
        for (int i = imax-1; i > imin; i--) // Заполнение правого столбца сверху вниз
    {
        matr[i,imin]=number;
                number++;
    }
     imin++;
     imax--;
     
    }
PrintArray(matr);
    
}
spiralArray();


// Задача 60(дополнительно): ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// 

void FillArray3d(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {         
                matr[i,j,k]= new Random().Next(10,100);
                     
        }
    }
    }
}

void PrintArray3d(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
                
            Console.Write ($"{matr[i, j, k]}({i},{j},{k}) ");   

        }
        Console.WriteLine();
        }
    }
 Console.WriteLine();
 }

int[,,] matrix3d=new int[2,2,2];
FillArray3d(matrix3d);
Console.WriteLine("This is matrix3d:");
PrintArray3d(matrix3d);

//
