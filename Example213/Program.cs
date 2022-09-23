Console.Clear();

Console.Write("Введите число ");
int N = Math.Abs(int.Parse(Console.ReadLine()));

if(N < 100 && N > -100) {
    Console.WriteLine("У введённого числа нет третьей цифры");
    return;
}

string str = N.ToString();
    Console.WriteLine($"Третья цифра {str[2]} числа {N}");