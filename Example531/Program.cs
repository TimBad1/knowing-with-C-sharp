// **Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

int GetSumPos(int[] arr) {
    int sum = 0;
    for( int i = 0; i < arr.Length; i++) {
        if(arr[i] > 0) {
            sum+= arr[i];
        }
    }
    return sum;
}

int GetSumNeg(int[] arr) {
    int sum = 0;
    for( int i = 0; i < arr.Length; i++) {
        if(arr[i] < 0) {
            sum+= arr[i];
        }
    }
    return sum;
}


int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Сумма положительных элементов массива = {GetSumPos(array)}");
Console.WriteLine($"Сумма отрицательных элементов массива = {GetSumNeg(array)}");

