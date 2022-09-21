// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillArray(double[,] array) // метод. принимает int m,n создает массив размером m n b, заполняет случайными вещественными от -10000 до 10000
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(-10000, 10001);
    }
    return array;
}                                     // end of metod



System.Console.WriteLine();
System.Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");

System.Console.WriteLine("enter the number of rows M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter the number of columns N");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
arr = FillArray(arr);

for (int i = 0; i < m; i++)
{    for (int j = 0; j < n; j++) System.Console.Write($"  {arr[i, j]}") ;
    System.Console.WriteLine(); }     


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

// для заполнения используем результат Задачи 47 - размерность введена, массив  double arr[m,n] уже заполнен

System.Console.WriteLine();
System.Console.WriteLine("Задача 50.");

System.Console.WriteLine("enter pozition X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter poziton Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > (arr.GetLength(0) - 1) || y > arr.GetLength(1)) System.Console.WriteLine("out of pozition");
else System.Console.WriteLine($" элемент с позицией {x}, {y} = {arr[x, y]}");

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Изменю задачу - возьмем массив из  Задачи 47 - размерность введена, массив  double arr[m,n] уже заполнен

double ArithmeticMean(double[,] array, int column) //метод для подсчета среднего арифметического по колонке
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) sum = sum + array[i, column];
    double arithmeticmean = sum / array.GetLength(0);
    return arithmeticmean;
}

System.Console.WriteLine();
System.Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце");

for (int j = 0; j < arr.GetLength(1); j++) System.Console.WriteLine($" среднее арифметическое колонки  {j} = {ArithmeticMean(arr, j)}");




