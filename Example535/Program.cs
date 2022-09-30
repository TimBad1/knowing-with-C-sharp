// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
int[] arr = GetRandomArray(123, 0, 150);

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
    }
    return result;
}

int SumCounter (int[] array,int min = 0,int  max = 100) {
    int count = 0;
    foreach( var el in array) {
        if( el > min && el < max) {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"массив = [{String.Join(",", arr)}]");
Console.WriteLine($"в массиве {SumCounter(arr)} элементов от 0 до 99");
