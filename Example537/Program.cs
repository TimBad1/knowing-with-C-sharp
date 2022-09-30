// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.Clear();

int[] arr = GetRandomArray(9, -10, 10);

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
    }
    return result;
}

int[] GetProductArray(int[] arr) {
    int[] newArr = new int [((arr.Length + 1) / 2)];
    for(int i = 0; i < arr.Length / 2; i++) {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 != 0) {
        newArr[newArr.Length - 1] = arr[newArr.Length - 1];
    }
    return newArr;
}


Console.WriteLine($"массив = [{String.Join(",", arr)}]");
Console.WriteLine($"массив = [{String.Join(",", GetProductArray(arr))}]");