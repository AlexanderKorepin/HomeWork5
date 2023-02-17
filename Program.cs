
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество //чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
  int [] array = new int[(size)];
  for(int i=0; i<size; i++)
    array[i] = new Random().Next(minValue, maxValue+1);
  return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
      Console.Write(array[i] + " ");
    Console.WriteLine();
}

int NumberOfEvenElements(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            result++;
    return result;
}
Console.Write("Enter the array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine()); 
int[] myArray = CreateRandomArray(arraySize, 100, 999);
ShowArray(myArray);
int num = NumberOfEvenElements(myArray);
Console.WriteLine("Number of even elements in array: " + num);
*/
//=====================================================================================
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
  int [] array = new int[(size)];
  for(int i=0; i<size; i++)
    array[i] = new Random().Next(minValue, maxValue+1);
  return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
      Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOfElementsOnOddPositions(int[] array)
{
    int result = 0;
    if(array.Length > 1)
        for(int i = 1; i < array.Length; i += 2)
            result += array[i];
    return result;
}

Console.Write("Enter the array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum possible value: ");
int arrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum possible value: ");
int arrayMax = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(arraySize, arrayMin, arrayMax);
ShowArray(myArray);
int sum = SumOfElementsOnOddPositions(myArray);
Console.WriteLine("Number of elements on odd positions in array: " + sum);
*/
//=========================================================================
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
double[] CreateArrayDouble(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        array[i] += new Random().NextDouble();
    }
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");
    Console.WriteLine();
}
double doubleMax(double[] array)
{
    double result = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > result)
            result = array[i];
    return result;
}

double doubleMin(double[] array)
{
    double result = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] < result)
            result = array[i];
    return result;
}

double getMinMaxDiff(double min, double max)
{
    return max - min;
}


Console.Write("Enter the array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum possible value: ");
int arrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum possible value: ");
int arrayMax = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArrayDouble(arraySize, arrayMin, arrayMax);
ShowArray(myArray);
double min = doubleMin(myArray);
double max = doubleMax(myArray);
double minMax = getMinMaxDiff(min, max);
Console.WriteLine($"The difference of minimal [{Math.Round(min, 2)}] and maximal [{Math.Round(max, 2)}] is: {Math.Round(minMax, 2)}");
*/