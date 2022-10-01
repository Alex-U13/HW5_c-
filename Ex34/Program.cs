// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();

Console.Write("Введите необходимое количество аргументов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
int count = 0;
int i =0;

while (i<n)
{
Array[i] = new Random().Next(100,1000);
Console.Write($"{Array[i]}, ");
if(Array[i]%2==0)  count += 1;
i++;
}

Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве - {count}.");