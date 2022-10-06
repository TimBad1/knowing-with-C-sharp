// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using System;
using static System.Console;

Clear();
WriteLine("Введите элементы массива через пробел");
string elements = ReadLine();
int[] baseArray = GetArrayFromString(elements);

int[] GetArrayFromString(string stringArray) {
    string[] nums = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] numsArray = new int[nums.Length];
    for( int i = 0; i < nums.Length; i++) {
        numsArray[i] = int.Parse(nums[i]);
    }
    return numsArray;
}

int MaxMinSubstraction(int[] arr) {
    int max = arr[0];
    int min = arr[0];

    for (int i = 1; i < arr.Length; i++) {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }

    return max - min;
}

WriteLine($"массив = [{String.Join(",", baseArray)}]");
WriteLine($"Разница между max и min = {MaxMinSubstraction(baseArray)}");