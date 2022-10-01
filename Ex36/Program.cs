// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.Write("Введите необходимое количество аргументов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
int Summ = 0;
int i =0;

while (i<n)
{
Array[i] = new Random().Next(-100,101);
Console.Write($"{Array[i]}, ");
if(i%2==1)  Summ += Array[i];
i++;
}

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {Summ}.");