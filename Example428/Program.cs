// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

Console.Clear();
Console.Write ("Введите число: ");
int limit = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Произведение чисел от 1 до {limit} равна {GetProd (limit)}");

int GetProd (int limit) {
    int prod = 1;
    for (int i = 1; i <= limit; i++)
        prod *= i;
    return prod;
}
