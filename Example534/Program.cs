// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] arr = GetRandomArray(new Random().Next(0, 20), 100, 999);

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
    }
    return result;
}

int EvenCount(int[] arr) {
    int count = 0;
    foreach (var el in arr) {
        if (el % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine($"массив = [{String.Join(",", arr)}]");
Console.WriteLine($"в массиве {EvenCount(arr)} чётных элементов");