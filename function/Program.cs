Console.Clear();

void CreateRandomArray (int[] Array, int A, int B)
{
    int lenght = Array.Length;
    int i = 0;
    while (i<lenght)
    {
        Array[i] = new Random().Next(A,B);
        i++;
    }

    for (i=0; i<lenght; i++)
    {
        if(i==0)  Console.Write($"[{Array[i]}, ");
        else if(i==(lenght-1))  Console.Write($"{Array[i]}] ");
        else Console.Write($"{Array[i]}, ");
    }
}

Console.Write("Введите необходимое количество элементов массива: ");  
int N = Convert.ToInt32(Console.ReadLine());
int[] workArray = new int[N];

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

CreateRandomArray(workArray, 100, 1000);
int lenghtWorkArray = workArray.Length; 
int count = 0;

for (int i =0; i<lenghtWorkArray; i++)
{
    if(workArray[i]%2==0) count++;
}

Console.WriteLine($" --> В заданном массиве количество четных значений элементов составляет: {count}.");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

CreateRandomArray(workArray, -100, 101);
//int lenghtWorkArray = workArray.Length; 
int Summ = 0;

for (int i =0; i<lenghtWorkArray; i++)
{
    if(i%2==1) Summ  += workArray[i];
}

Console.WriteLine($" --> В заданном массиве суммa значений элементов, стоящих на нечётных позициях, составляет: {Summ}.");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

CreateRandomArray(workArray, 1, 101);
// int lenghtWorkArray = workArray.Length; 
int max = -100;
int min = 100;

for (int i =0; i<lenghtWorkArray; i++)
{
    if(workArray[i]>max) max = workArray[i];
    if(workArray[i]<min) min = workArray[i];
}

Console.WriteLine($"--> Разница между максимальным и минимальным значениями элементов массива составила: {max-min}.");
