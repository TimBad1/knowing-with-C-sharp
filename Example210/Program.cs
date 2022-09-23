Console.Clear();

Console.Write("Введите трёхзначное число ");
int N = Math.Abs(int.Parse(Console.ReadLine()));

if(N < 100 || N > 999) {
    Console.WriteLine("Вы ввели не трёхзначное число");
    return;
}

int division = N / 10;
Console.WriteLine($"{division % 10} вторая цифра числа {N}");