// // // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // // [3 7 22 2 78] -> 76

System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] arr = GetRandomArray(length);
PrintArray(arr);
int min1 = min(arr);
int max1 = max(arr);
int diff = max1 - min1;
Console.WriteLine("максимальное значение - " + max1);
Console.WriteLine("минимальное значение - " + min1);
System.Console.WriteLine("разница = " + diff);

int max(int[] count)
{
    int max = count[0];
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i] > max)
        {
            max = count[i];
        }
    }
    return max;
}

int min(int[] count)
{
    int min = count[0];
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i] < min)
        {
            min = count[i];
        }
    }
    return min;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(1, 9);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}






