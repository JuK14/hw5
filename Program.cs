//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива:   ");
int size = int.Parse(Console.ReadLine());
while (size < 0)
{
    Console.Write("Вы ввели отрицательныое значение. Задайте размер массива еще раз: ");
    size = int.Parse(Console.ReadLine());    
}
int count = 0;
int [] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
for (int i=0; i < array.Length; i++)
{
    count += array[i] % 2 == 0 ? 1 : 0;
}
Console.WriteLine("Ответ: в получившимся массиве [" + string.Join(",", array)+ "] количество четных чисел ->"+ count);





// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100 , 100);
        index++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int pos = 0;
    Console.Write("[ ");
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }
    Console.Write("]");
}
Console.WriteLine("Введите количество элементов массива");
int a = int.Parse(Console.ReadLine());
int[] array = new int[a];

FillArray(array);
PrintArray(array);
int b = 0;
int i = 1;
while (i < array.Length)
{
    b = b + array[i];
    i = i + 2;
}


Console.Write (" -> " + b);



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1 , 100);
        index++;
    }
}
void PrintArray(double[] coll)
{
    int count = coll.Length;
    int pos = 0;
    Console.Write("[ ");
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество элементов массива");
int a = int.Parse(Console.ReadLine());
double[] array = new double[a];

FillArray(array);
PrintArray(array);

double max = array[0];
int i = 0;
while (i<array.Length)
{
    if (max < array[i])
    {
        max = array[i];
    }
i++;
}
double min = array[0];
int ind = 0;
while (ind<array.Length)
{
    if (min > array[ind])
    {
        min = array[ind];
    }
ind++;
}
double div = max - min;
Console.Write(" -> " + div);