// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

// Console.Write ("Введите число: ");
// int a = int.Parse (Console.ReadLine ());
// Console.Write (" И показатель степени в которую нужно возвести это число: ");
// int b = int.Parse (Console.ReadLine ());

// Console.WriteLine ($"{a}^{b} = {GetExp (a, b)}");

int GetExpPos (int number, int exp) {
    int prod = 1;
    for (int i = 1; i <= exp; i++)
        prod *= number;
    return prod;
}

// int GetExpNeg (int number, int exp) {
//     int prod = 1;
//     for (int i = -1; i >= exp; i--)
//         prod /= number;
//     return prod;
// }

void Input () {
    Console.Write ("Введите число: ");
    int a = int.Parse (Console.ReadLine ());
    Console.Write (" И показатель степени в которую нужно возвести это число: ");
    int b = int.Parse (Console.ReadLine ());

    if (b == 0) {
        Console.WriteLine ($"{a}^{b} = 1");
        return;
    }

    if (a == 0) {
        Console.WriteLine ("Вы ввели не корректное число");
        Input();
        return;
    }
    if (b > 0) {
        Console.WriteLine ($"{a}^{b} = {GetExpPos (a, b)}");
        return;
    }
    if (b < 0) {
        Console.WriteLine ($"{a}^{b} = {GetExpNeg (a, b)}");
        return;
    }
}

Input();