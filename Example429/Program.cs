// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = GetBinaryArr(8);

// Console.WriteLine (array);

int[] GetBinaryArr(int length) {
    int[] arr = new int[length];
    for(int i = 0; i < length; i++) {
        arr[i] = new Random().Next(100);
    }

    return arr;
}

Console.WriteLine($"[{String.Join(",", array)}]");
