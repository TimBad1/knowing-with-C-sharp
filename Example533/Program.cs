// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool IsNumber(int[] arr, int num) {
    foreach (int el in arr) {
        if ( el == num ) {
            return true;
        }
    }
    return false;
}

Console.Write ("Введите число: ");
int number = int.Parse (Console.ReadLine ());

int[] array = GetRandomArray(8, -5, 10);
Console.WriteLine($"массив = [{String.Join(",", array)}]");
Console.WriteLine($"{IsNumber(array, number)}");