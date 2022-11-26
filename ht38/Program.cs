// Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
double [] FillArray (int size)
{
    double [] arr = new double [size];      // Как заполнить вещественный массив отрицательными числами в интернете нашел,
    Random rand = new Random();             // но недопонял. Подскажите пожалуйстаб что мы делаем в этой строчке
    for (int i = 0; i < arr.Length;i++)
    {
        arr[i] = rand.Next(-100, 100) + rand.NextDouble(); //и в этой. Спасибо!
        arr[i] = Math.Round(arr[i], 3);
    }
    return arr; 
}
Console.WriteLine ("Введите длину массива:");
int num = Convert.ToInt32(Console.ReadLine());
double [] array = FillArray(num);
Console.WriteLine(string.Join("  ",array));

double min = array[0];
double max = array[0];

for (int j = 0; j < array.Length;j++)
{
    if (array[j]<min) min =array[j];
}

for (int j = 0; j < array.Length;j++)
{
    if (array[j]>max) max =array[j];
}
Console.WriteLine ($"Разница между максимальным {max} и минимальным {min} = {max-min} ");

