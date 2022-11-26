// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int [] FillArray (int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length;i++)
    {
        arr[i] = new Random().Next(-100,100);
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
    if ((array[j]>9) && (array[j]<101))
    {
        count=count + 1;
    }
}
Console.WriteLine ($"Чисел входящих в отрезок: {count}");