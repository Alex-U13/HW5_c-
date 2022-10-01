// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Clear();

Console.Write("Введите необходимое количество аргументов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
int i =0;
int max =0;
int min =100;

while (i<n)
{
Array[i] = new Random().Next(0,101);
Console.Write($"{Array[i]}, ");
if(Array[i]>max) max = Array[i];
if(Array[i]<min) min = Array[i];
i += 1;;
}

Console.WriteLine();
// Console.WriteLine(max);
// Console.WriteLine(min);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива составила - {max-min}.");
