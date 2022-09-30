// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] arr = GetRandomArray(new Random().Next(0, 20), -100, 100);

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
    }
    return result;
}

int SunOddIndex(int[] arr) {
    int sum = 0;

    for (int i = 1; i < arr.Length; i += 2) {
        sum += arr[i];
        Console.WriteLine($"{i} = {arr[i]} sum = {sum}");
    }
    return sum;
}

Console.WriteLine($"массив = [{String.Join(",", arr)}]");
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {SunOddIndex(arr)}");