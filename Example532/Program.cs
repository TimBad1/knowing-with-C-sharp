// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
    }
    return result;
}

int[] GetArray(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        array[i] *= -1;
    }
    return array;
}

int[] arr = GetRandomArray(6, -5, 10);

Console.WriteLine($"массив = [{String.Join(",", arr)}]");
Console.WriteLine($"массив = [{String.Join(",", GetArray(arr))}]");
