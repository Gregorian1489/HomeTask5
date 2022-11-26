// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

int [] FillArray (int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length;i++)
    {
        arr[i] = new Random().Next(-100,101);
    }
    return arr; 
}   
Console.WriteLine ("Введите длину массива:");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(num);

Console.WriteLine(string.Join(",",array));
int sum = 0;

for (int j = 0; j < array.Length;j++)
{
    if (j%2 == 1) sum += array[j];
}
Console.WriteLine ($"Сумма нечетных элементов = {sum}");
