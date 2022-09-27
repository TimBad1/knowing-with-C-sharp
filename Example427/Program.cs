// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write ("Введите число: ");
int a = int.Parse (Console.ReadLine ());

Console.WriteLine ($"Сумма цифр числа {a} = {GetSumDigit (a)}");

int GetSumDigit (int number) {
    int sum = 0;
    while(number > 0) {
        sum += number % 10;
        number /= 10;
        // Console.WriteLine ($" number = {number}; number % 10 = {number % 10}; sum = {sum}");
    }
        
    return sum;
}