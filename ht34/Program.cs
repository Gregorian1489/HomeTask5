// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int [] FillArray (int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length;i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr; 
}   
Console.WriteLine ("Введите длину массива:");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(num);

Console.WriteLine(string.Join(",",array));
int count = 0;

for (int j = 0; j < array.Length;j++)
{
    if (array[j]%2 == 0) count++; 
}
Console.WriteLine ($"Количество четных чисел = {count}");