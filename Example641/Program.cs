// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

using System;
using static System.Console;

Clear();
WriteLine("Введите элементы массива через пробел");

int amount = 8;
int[] numbers = GetNumberArray(amount);

int[] GetNumberArray(int length) {
    int[] numsArray = new int[length];
    WriteLine("Введите элементы массива");
    for( int i = 0; i < length; i++) {
        Write($"{i + 1} элемент: ");
        numsArray[i] = int.Parse(ReadLine());
    }
    return numsArray;
}

int GetPositive(int[] arr) {
    int count = 0;
    foreach( int el in arr ) {
        if( el > 0 ) {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"В массиве {GetPositive(numbers)} элементов > 0");