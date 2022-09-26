// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write ("Введите число: ");
int number = int.Parse (Console.ReadLine ());
Console.WriteLine ($"В числе {number} {CountNumber(number)} цифр");

int CountNumber (int number) {
    int count = 0;

    if(number < 0) {
        number = Math.Abs(number);
    }
    
    if(number == 0) {
        return 1;
    }
    
    while(number >= 1) {
        number /= 10;
        count++;
    }
    return count;
}